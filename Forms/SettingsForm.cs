using CefSharp.WinForms;
using CefSharp;
using ClassBoard.ClassBoardAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassBoard.Forms
{
    public partial class SettingsForm : Form
    {
        private string ini;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ini = $"{AppDomain.CurrentDomain.BaseDirectory}\\Config\\config.ini";

            initConfig();
        }

        private void initConfig()
        {
            this.checkBox_AsBackground.Checked = Boolean.Parse(DllImports.IniReadValue("window", "AsBackground", ini));
            this.checkBox_QuietLoad.Checked = Boolean.Parse(DllImports.IniReadValue("window", "QuietLoad", ini));
            this.checkBox_Timer.Checked = Boolean.Parse(DllImports.IniReadValue("Fix_Task_View", "Timer", ini));
            this.checkBox_DisableGPU.Checked = Boolean.Parse(DllImports.IniReadValue("CEF", "DisableGPU", ini));
            this.numericUpDown_Interval.Value = Int32.Parse(DllImports.IniReadValue("Fix_Task_View", "Interval", ini));
            this.numericUpDown_LogSeverity.Value = Int32.Parse(DllImports.IniReadValue("CEF", "LogSeverity", ini));
            this.numericUpDown_RemoteDebuggingPort.Value = Int32.Parse(DllImports.IniReadValue("CEF", "RemoteDebuggingPort", ini));
            //this.textBox_WinText.Text = DllImports.IniReadValue("Fix_Task_View", "WinText", ini);
        }

        private void textBox_WinText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            WriteConfig();
        }
        private void WriteConfig()
        {
            DllImports.IniWrite("window", "AsBackground", this.checkBox_AsBackground.Checked.ToString(), ini);
            DllImports.IniWrite("window", "QuietLoad", this.checkBox_QuietLoad.Checked.ToString(), ini);
            DllImports.IniWrite("Fix_Task_View", "Timer", this.checkBox_Timer.Checked.ToString(), ini);
            DllImports.IniWrite("CEF", "DisableGPU", this.checkBox_DisableGPU.Checked.ToString(), ini);
            DllImports.IniWrite("Fix_Task_View", "Interval", this.numericUpDown_Interval.Value.ToString(), ini);
            DllImports.IniWrite("CEF", "LogSeverity", this.numericUpDown_LogSeverity.Value.ToString(), ini);
            DllImports.IniWrite("CEF", "RemoteDebuggingPort", this.numericUpDown_RemoteDebuggingPort.Value.ToString(), ini);
            // DllImports.IniWrite("Fix_Task_View", "WinText", this.textBox_WinText.Text, ini);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(String.Format("{0}\\Config\\board.txt", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(String.Format("{0}\\Config\\events.txt", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(String.Format("{0}\\Config\\class.csv", AppDomain.CurrentDomain.BaseDirectory));
        }
    }
}
