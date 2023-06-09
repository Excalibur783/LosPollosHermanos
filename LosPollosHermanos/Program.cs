using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosPollosHermanos
{
    internal static class Program
    {
        public static Dueño gustavo = new Dueño();
        public static ArrayList empleados = new ArrayList();
        public static ArrayList clientes = new ArrayList();

        public static VentanaInicioSesion ventanaInicioSesion;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(ventanaInicioSesion = new VentanaInicioSesion());
        }
    }
}
