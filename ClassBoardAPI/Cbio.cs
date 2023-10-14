using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoard.ClassBoardAPI
{
    internal class Cbio
    {
        public string readFileToString(string path) => File.ReadAllText(String.Format("{0}\\{1}", AppDomain.CurrentDomain.BaseDirectory, path));

        public void writeStringToFile(string path, string context) => File.WriteAllText(String.Format("{0}\\{1}", AppDomain.CurrentDomain.BaseDirectory, path), context);
    }
}
