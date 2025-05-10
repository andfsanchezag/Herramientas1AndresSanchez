using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Persona
    {
        private string nombre;
        private string cedula;
        private string role;
        private List<Material> prestamos;

        public Persona(string nombre, string cedula, string role, List<Material> prestamos)
        {
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.Role = role;
            this.Prestamos = prestamos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Role { get => role; set => role = value; }
        internal List<Material> Prestamos { get => prestamos; set => prestamos = value; }
    }
}
