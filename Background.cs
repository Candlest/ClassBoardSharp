using CefSharp;
using CefSharp.WinForms;
using ClassBoard.ClassBoardAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassBoard
{
    public partial class Background : Form
    {
        private bool hasMess = false;
        private string ini;
        private IntPtr programHandle;
        public Background()
        {
            InitializeComponent();
        }

        private void Background_Load(object sender, EventArgs e)
        {
            ini = $"{AppDomain.CurrentDomain.BaseDirectory}\\Config\\config.ini";
            initCEF();
            if(Boolean.Parse(DllImports.IniReadValue("window", "AsBackground", ini)))
                initBackground();
            if (!Boolean.Parse(DllImports.IniReadValue("window", "QuietLoad", ini))) 
                notifyIcon.ShowBalloonTip(15, "Class Board", "Class Board 已启动", ToolTipIcon.Info);

            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Location = new Point(0, 0);
            // BackgroundUrl
            var BackgroundUrl = DllImports.IniReadValue("window", "BackgroundUrl", ini);
            this.browser.LoadUrl(String.Format("file:///{0}{1}", AppDomain.CurrentDomain.BaseDirectory.Replace('\\', '/'), BackgroundUrl));

            if (Boolean.Parse(DllImports.IniReadValue("Fix_Task_View", "Timer", ini)))
            {
                timer_task_view.Interval = Int32.Parse(DllImports.IniReadValue("Fix_Task_View", "Interval", ini));
                timer_task_view.Enabled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //notifyIcon.ShowBalloonTip(15, "Class Board", "Class Board 已重载", ToolTipIcon.Info);
            Application.Restart();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(String.Format("{0}\\README\\README.chm", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(ini);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip.Show(Control.MousePosition.X, Control.MousePosition.Y);
        }

        private void Background_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void initCEF()
        {
            var settings = new CefSettings()
            {
                LogFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\Log\\debug.log", //You can customise this path
                LogSeverity = (LogSeverity)Int16.Parse(DllImports.IniReadValue("CEF", "LogSeverity",ini)) // You can change the log level
            };
            if (Boolean.Parse(DllImports.IniReadValue("CEF", "DisableGPU", ini))) 
                settings.DisableGpuAcceleration();
            settings.RemoteDebuggingPort = Int32.Parse(DllImports.IniReadValue("CEF", "RemoteDebuggingPort", ini));

            //Perform dependency check to make sure all relevant resources are in our output directory.
            Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);


            this.browser = new CefSharp.WinForms.ChromiumWebBrowser();
            CefSharpSettings.WcfEnabled = true;
            browser.JavascriptObjectRepository.Settings.LegacyBindingEnabled = true;
            //在这里塞API
            browser.JavascriptObjectRepository.Register("cbio", new Cbio(), isAsync: false, options: BindingOptions.DefaultBinder);
            browser.JavascriptObjectRepository.Register("cbsys", new Cbsys(), isAsync: false, options: BindingOptions.DefaultBinder);

            //From 设计器
            {
                this.browser.ActivateBrowserOnCreation = false;
                this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
                this.browser.Location = new System.Drawing.Point(0, 0);
                this.browser.Name = "browser";
                this.browser.Size = new System.Drawing.Size(800, 450);
                this.browser.TabIndex = 0;
                this.Controls.Add(this.browser);
            }
        }

        private void initBackground()
        {
            // 桌面窗口句柄，在外部定义，用于后面将我们自己的窗口作为子窗口放入
            programHandle = DllImports.FindWindow("Progman", null);

            IntPtr result = IntPtr.Zero;
            // 向 Program Manager 窗口发送消息 0x52c 的一个消息，超时设置为2秒
            DllImports.SendMessageTimeout(programHandle, 0x52c, IntPtr.Zero, IntPtr.Zero, 0, 2, result);

            // 遍历顶级窗口
            DllImports.EnumWindows((hwnd, lParam) =>
            {
                // 找到第一个 WorkerW 窗口，此窗口中有子窗口 SHELLDLL_DefView，所以先找子窗口
                if (DllImports.FindWindowEx(hwnd, IntPtr.Zero, "SHELLDLL_DefView", null) != IntPtr.Zero)
                {
                    // 找到当前第一个 WorkerW 窗口的，后一个窗口，及第二个 WorkerW 窗口。
                    IntPtr tempHwnd = DllImports.FindWindowEx(IntPtr.Zero, hwnd, "WorkerW", null);

                    // 隐藏第二个 WorkerW 窗口
                    DllImports.ShowWindow(tempHwnd, 0);
                }
                return true;
            }, IntPtr.Zero);

            DllImports.SetParent(this.Handle, programHandle);
        }

        private void timer_task_view_Tick(object sender, EventArgs e)
        {
            // 应对Task view的暂时方法，学习 https://stackoverflow.com/questions/46653985/detect-wintab-task-view
            var fgwin = DllImports.GetForegroundWindow();
            StringBuilder outText = new StringBuilder(256);
            int a = DllImports.GetWindowText(fgwin, outText, outText.Capacity);
            //Console.WriteLine(outText.ToString());
            // TO DO: 根据不同Locate改变，虽然用这程序的大概都是SC区的
            if(outText.ToString() == "任务视图" && (!hasMess))
            {
                hasMess = true;
                MessageBox.Show(this, "检测到壁纸接管失效，确认后重新接管壁纸", "Class Board");
                initBackground();
                hasMess = false;
            }
        }

        //[Obsolete]
        //private void initBackground_old()
        //{
        //    hProgman = DllImports.FindWindow("Progman", "Program Manager");
        //    DllImports.SendMessageTimeout(hProgman, 0x52c, 0, 0, 0, 100, out _);

        //    IntPtr workerW = IntPtr.Zero;
        //    do
        //    {
        //        workerW = DllImports.FindWindowEx(IntPtr.Zero, workerW, "workerW", null);
        //        if (DllImports.GetParent(workerW) == hProgman)
        //        {
        //            DllImports.ShowWindow(workerW, 0);
        //        }
        //    } while (workerW != IntPtr.Zero);
        //    DllImports.SetParent(this.Handle, hProgman);
        //}
    }
}
