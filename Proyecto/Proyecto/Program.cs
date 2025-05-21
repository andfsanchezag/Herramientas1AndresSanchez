using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Servicios servicio = new Servicios(new Biblioteca(new List<Persona>(), new List<Material>(), new List<Movimiento>()));
            Personas personas = new Personas();
            personas.SetServicio(servicio);
            Application.Run(personas);
        }
    }
}
