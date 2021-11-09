using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //HandyControls
            new HandyControlsProject.MainWindow().ShowDialog();
            //HandyControl
            //new HandyControlProject2.MainWindow().ShowDialog();
        }
    }
}
