using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassBoard.ClassBoardAPI
{
    internal class Cbsys
    {
        public void message(string title, string context) => MessageBox.Show(title, context);
        public int getWidth() => System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
        public int getHeight() => System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
    }
}
