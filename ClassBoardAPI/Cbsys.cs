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
        public void Message(string title, string context)
        {
            MessageBox.Show(title, context);
        }
    }
}
