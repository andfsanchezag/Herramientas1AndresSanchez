using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Biblioteca
    {
       private List<Persona> personas;
        private List<Material> catalogo;
        private List<Movimiento> historial;

        public Biblioteca(List<Persona> personas, List<Material> catalogo, List<Movimiento> historial)
        {
            this.Personas = personas;
            this.Catalogo = catalogo;
            this.Historial = historial;
        }

        internal List<Persona> Personas { get => personas; set => personas = value; }
        internal List<Material> Catalogo { get => catalogo; set => catalogo = value; }
        internal List<Movimiento> Historial { get => historial; set => historial = value; }
    }
}
