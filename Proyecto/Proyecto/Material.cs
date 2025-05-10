using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Material
    {
        private int id;
        private string titulo;
        private int cantidadRegistrada;
        private int cantidadActual;
        private DateTime fechaDeRegistro;

        public Material(int id, string titulo, int cantidadRegistrada, int cantidadActual, DateTime fechaDeRegistro)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.CantidadRegistrada = cantidadRegistrada;
            this.CantidadActual = cantidadActual;
            this.FechaDeRegistro = fechaDeRegistro;
        }

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int CantidadRegistrada { get => cantidadRegistrada; set => cantidadRegistrada = value; }
        public int CantidadActual { get => cantidadActual; set => cantidadActual = value; }
        public DateTime FechaDeRegistro { get => fechaDeRegistro; set => fechaDeRegistro = value; }
    }
}
