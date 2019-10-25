using System;
using System.Windows.Forms;
using pentago.Forms;

namespace pentago
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameField());
        }
    }
}
