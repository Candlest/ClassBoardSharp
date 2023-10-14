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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassBoard
{
    public partial class Background : Form
    {
        public Background()
        {
            InitializeComponent();
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }

        private void Background_Load(object sender, EventArgs e)
        {
            var settings = new CefSettings()
            {
                LogFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\log\\debug.log", //You can customise this path
                LogSeverity = LogSeverity.Error, // You can change the log level
            };
            settings.DisableGpuAcceleration();
            settings.RemoteDebuggingPort = 14241;

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
                this.browser.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.chromiumWebBrowser1_LoadingStateChanged);
                this.Controls.Add(this.browser);
            }
            settingPage = new SettingPage();
            notifyIcon.ShowBalloonTip(15, "Class Board", "Class Board 已启动，了解新版内容请打开 HELP 页面", ToolTipIcon.Info);
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Location = new Point(0, 0);
            this.browser.LoadUrl(String.Format("file:///{0}/Background/index.html", AppDomain.CurrentDomain.BaseDirectory.Replace('\\', '/')));
            //Load a different url
            IntPtr hProgman = DllImports.FindWindow("Progman", "Program Manager");
            DllImports.SendMessageTimeout(hProgman, 0x52c, 0, 0, 0, 100, out _);

            IntPtr workerW = IntPtr.Zero;
            do
            {
                workerW = DllImports.FindWindowEx(IntPtr.Zero, workerW, "workerW", null);
                if (DllImports.GetParent(workerW) == hProgman)
                {
                    DllImports.ShowWindow(workerW, 0);
                }
            } while (workerW != IntPtr.Zero);
            DllImports.SetParent(this.Handle, hProgman);
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
            var about = new AboutPage();
            about.Show();
            //System.Diagnostics.Process.Start(String.Format("{0}\\README.pdf", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingPage = new SettingPage();
            settingPage.Show();
        }

        private SettingPage settingPage = null;

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip.Show(Control.MousePosition.X, Control.MousePosition.Y);
        }

        private void Background_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
