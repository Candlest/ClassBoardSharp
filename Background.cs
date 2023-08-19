using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            this.browser = new CefSharp.WinForms.ChromiumWebBrowser();
            CefSharpSettings.WcfEnabled = true;
            browser.JavascriptObjectRepository.Settings.LegacyBindingEnabled = true;
            browser.JavascriptObjectRepository.Register("cef_obj", new JSObject(), isAsync: false, options: BindingOptions.DefaultBinder);
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
            this.browser.LoadUrl(String.Format("file:///{0}/Background/main.html", AppDomain.CurrentDomain.BaseDirectory.Replace('\\', '/')));
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
            settingPage.Close();
            //notifyIcon.ShowBalloonTip(15, "Class Board", "Class Board 已重载", ToolTipIcon.Info);
            Application.Restart();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(String.Format("{0}\\README.pdf", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingPage.Show();
        //    //explorer
        //    System.Diagnostics.Process.Start("explorer.exe", String.Format("{0}\\Background\\", System.IO.Directory.GetCurrentDirectory()));

        //    /*告示牌 */
        //    System.Diagnostics.Process.Start("notepad.exe", String.Format("{0}\\Background\\js\\help.js", System.IO.Directory.GetCurrentDirectory()));

        //    /*倒计日*/
        //    System.Diagnostics.Process.Start("notepad.exe", String.Format("{0}\\Background\\js\\event_cal.js", System.IO.Directory.GetCurrentDirectory()));

        //    /*课表 */
        //    System.Diagnostics.Process.Start("notepad.exe", String.Format("{0}\\Background\\js\\class.js", System.IO.Directory.GetCurrentDirectory()));
        //
        }

        private SettingPage settingPage;

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip.Show(Control.MousePosition.X, Control.MousePosition.Y);
        }
    }
    public class JSObject
    {
        public string getClass()
        {
            return File.ReadAllText("schedule.txt");
        }
        public string getEvents()
        {
            return File.ReadAllText("events.txt");
        }
        public string getBoard()
        {
            return File.ReadAllText("board.txt");
        }
    }
}
