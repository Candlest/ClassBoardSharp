using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CefBackend
{
    public partial class ClassBoard : Form
    {
        public ClassBoard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(15, "Class Board", "Class Board 已启动，了解新版内容请打开 HELP 页面", ToolTipIcon.Info);
            this.Height = 1080;
            this.Width = 1920;
            this.Location = new Point(0, 0);
            this.chromiumWebBrowser1.LoadUrl(String.Format("file:///{0}/Background/main.html", System.IO.Directory.GetCurrentDirectory().Replace('\\','/')));
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

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }

        private void exitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(15, "Class Board", "Class Board 已重载", ToolTipIcon.Info);
            Application.Restart();
            
        }

        private void helpHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(String.Format("{0}\\README.html", System.IO.Directory.GetCurrentDirectory()));
        }

        private void settingSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //explorer
            System.Diagnostics.Process.Start("explorer.exe", String.Format("{0}\\Background\\", System.IO.Directory.GetCurrentDirectory()));

            /*告示牌 */
            System.Diagnostics.Process.Start("notepad.exe", String.Format("{0}\\Background\\js\\help.js", System.IO.Directory.GetCurrentDirectory()));

            /*倒计日*/
            System.Diagnostics.Process.Start("notepad.exe", String.Format("{0}\\Background\\js\\event_cal.js", System.IO.Directory.GetCurrentDirectory()));

            /*课表 */
            System.Diagnostics.Process.Start("notepad.exe", String.Format("{0}\\Background\\js\\class.js", System.IO.Directory.GetCurrentDirectory()));
        }
    }
}
