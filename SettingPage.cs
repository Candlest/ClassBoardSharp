using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassBoard
{
    public partial class SettingPage : Form
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        private void SettingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void SettingPage_Load(object sender, EventArgs e)
        {
            pfc = new PrivateFontCollection();
            pfc.AddFontFile("LXGWWenKaiGBScreenR.ttf");
            this.Font = new Font(pfc.Families[0], 15);
            this.textBox_board.Lines =  File.ReadAllLines("board.txt");
            this.textBox_events.Lines = File.ReadAllLines("events.txt");
            this.textBox_schedule.Lines = File.ReadAllLines("schedule.txt");
        }

        PrivateFontCollection pfc;

        private void button_save_board_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("board.txt", textBox_board.Lines);
            Message_OK();
        }

        private void button_save_events_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("events.txt", textBox_events.Lines);
            Message_OK();
        }

        private void button_save_schedule_Click(object sender, EventArgs e)
        {
            File.WriteAllLines("schedule.txt", textBox_schedule.Lines);
            Message_OK();
        }

        private void Message_OK()
        {
            MessageBox.Show(this, "保存成功，将在重新打开程序或者 Restart 后应用更改。", "设置成功", MessageBoxButtons.OK);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://github.com/Candlest/ClassBoardSharp");
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "shell:Startup");
            string[] s = { string.Format("{0}\\ClassBoard.lnk", AppDomain.CurrentDomain.BaseDirectory)};
            CopyToClipboard(s, false);
        }

        // <summary>
        /// 复制或剪切文件至剪贴板(方法）
        /// </summary>
        /// <param name="files">需要添加到剪切板的文件路径数组</param>
        /// <param name="cut">是否剪切true为剪切，false为复制</param>
        public static void CopyToClipboard(string[] files, bool cut)
        {
            if (files == null) return;
            IDataObject data = new DataObject(DataFormats.FileDrop, files);
            MemoryStream memo = new MemoryStream(4);
            byte[] bytes = new byte[] { (byte)(cut ? 2 : 5), 0, 0, 0 };
            memo.Write(bytes, 0, bytes.Length);
            data.SetData("Preferred DropEffect", memo);
            Clipboard.SetDataObject(data);
        }

        /// <summary>
        /// 获取剪贴板中的文件列表（方法）
        /// </summary>
        /// <returns>System.Collections.List<string>返回剪切板中文件路径集合</returns>
        public static List<string> GetClipboardList()
        {
            List<string> clipboardList = new List<string>();
            System.Collections.Specialized.StringCollection sc = Clipboard.GetFileDropList();
            for (int i = 0; i < sc.Count; i++)
            {
                string listfileName = sc[i];
                clipboardList.Add(listfileName);
            }
            return clipboardList;
        }
    }
}
