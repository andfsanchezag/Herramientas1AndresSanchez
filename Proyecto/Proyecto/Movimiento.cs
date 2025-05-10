using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Movimiento
    {
        private DateTime fecha;
        private Material material;
        private Persona persona;
        private string tipo;

        public Movimiento(DateTime fecha, Material material, Persona persona, string tipo)
        {
            this.Fecha = fecha;
            this.Material = material;
            this.Persona = persona;
            this.Tipo = tipo;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        internal Material Material { get => material; set => material = value; }
        internal Persona Persona { get => persona; set => persona = value; }
    }
}
