using System;
using System.Windows.Forms;

namespace WinForms
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Bootstrapper bootrapper = new Bootstrapper();
            bootrapper.Run();
        }
    }
}
