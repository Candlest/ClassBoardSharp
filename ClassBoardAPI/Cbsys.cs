using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace ClassBoard.ClassBoardAPI
{
    internal class Cbsys
    {
        public void message(string title, string context) => MessageBox.Show(title, context);
        public int getWidth() => System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
        public int getHeight() => System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

        public string getConfigFromIni(string section, string skey, string path) => DllImports.IniReadValue(section, skey, String.Format("{0}\\{1}", AppDomain.CurrentDomain.BaseDirectory, path));
        public void setConfigToIni(string section, string skey, string str, string path) => DllImports.IniWrite(section, skey, str ,String.Format("{0}\\{1}", AppDomain.CurrentDomain.BaseDirectory, path));
    }
}
