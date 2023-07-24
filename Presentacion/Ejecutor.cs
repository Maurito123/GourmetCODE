using System;
using System.Windows.Forms;
using proyecto.Presentacion;
using proyecto.Presentacion;

namespace TuProyecto
{
    static class Ejecutor
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Iniciar la ventana de inicio de sesión.
            Application.Run(new FormLogin());
        }
    }
}
