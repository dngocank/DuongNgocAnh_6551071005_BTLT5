using System;
using System.Windows.Forms;

namespace Bai_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormBangVe());
        }
    }
}