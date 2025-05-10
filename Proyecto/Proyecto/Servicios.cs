using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class Servicios
    {
        private Biblioteca biblioteca;
        private Dictionary<string, int> capacidadPrestamo;

        public Servicios(Biblioteca biblioteca)
        {
            this.Biblioteca = biblioteca;
            capacidadPrestamo = new Dictionary<string, int>();
            capacidadPrestamo.Add("Estudiante", 5);
            capacidadPrestamo.Add("Profesor", 3);
            capacidadPrestamo.Add("Administrativo", 1);
        }

        internal Biblioteca Biblioteca { get => biblioteca; set => biblioteca = value; }


        public void CrearPersona(Persona persona) {
            Persona existente = buscarPersona(persona.Cedula);
            if (existente != null) {
                Console.WriteLine("ya existe una persona con esa cedula");
                return;
            }
            Biblioteca.Personas.Add(persona);
            Console.WriteLine("se ha creado la persona");
        
        }
        public void EliminarPersona(string cedula)
        {
            Persona existente = buscarPersona(cedula);
            if (existente == null)
            {
                Console.WriteLine("no existe una persona con esa cedula");
                return;
            }
            Biblioteca.Personas.Remove(existente);
            Console.WriteLine("se ha eliminado la persona");

        }

        public void CrearMaterial(Material material) {
            Material existente = buscarMaterial(material.Id);
            if (existente != null) {
                Console.WriteLine("ya existe un material con ese id");
                return;
            }
            Biblioteca.Catalogo.Add(material);
            Console.WriteLine("se ha creado el material");
        }

        public void RegistrarPrestamo(string cedula, int id) {
            Material material = buscarMaterial(id);
            if (material == null)
            {
                Console.WriteLine("no existe un material con ese id");
                return;
            }
            if (material.CantidadActual == 0) {
                Console.WriteLine("no hay ejemplares disponibles");
                return;
            }
            Persona persona = buscarPersona(cedula);
            if (persona == null)
            {
                Console.WriteLine("no existe una persona con esa cedula");
                return;
            }
            if (persona.Prestamos.Count() == capacidadPrestamo[persona.Role]) {
                Console.WriteLine("la persona ha alcanzado el limite de prestamos");
                return;
            }
            material.CantidadActual -= 1;
            persona.Prestamos.Add(material);
            Movimiento movimiento = new Movimiento(new DateTime(), material, persona, "prestamo");
            Biblioteca.Historial.Add(movimiento);
            Console.WriteLine("se ha prestado el material exitosamente");

        }

        public void RegistrarDevolucion(string cedula, int id)
        {
            Material material = buscarMaterial(id);
            if (material == null)
            {
                Console.WriteLine("no existe un material con ese id");
                return;
            }
            Persona persona = buscarPersona(cedula);
            if (persona == null)
            {
                Console.WriteLine("no existe una persona con esa cedula");
                return;
            }
            if (!persona.Prestamos.Contains(material))
            {
                Console.WriteLine("la persona no posee ese material prestado");
                return;
            }
            material.CantidadActual += 1;
            persona.Prestamos.Remove(material);
            Movimiento movimiento = new Movimiento(new DateTime(), material, persona, "Devolucion");
            Biblioteca.Historial.Add(movimiento);
            Console.WriteLine("se ha regresado el material exitosamente");
        }

        public List<Movimiento> VerHistorial() {
            return Biblioteca.Historial;
        }

        public void AumentarCantidad(int cantidad, int id) {
            Material material = buscarMaterial(id);
            if (material == null)
            {
                Console.WriteLine("no existe un material con ese id");
                return;
            }
            material.CantidadRegistrada += cantidad;
            material.CantidadActual += cantidad;
        }

        private Persona buscarPersona(string cedula) {
            foreach (Persona persona in Biblioteca.Personas) {
                if (persona.Cedula.Equals(cedula)) {
                    return persona;
                }
            }
            return null;
        }

        private Material buscarMaterial(int id) {
            foreach (Material material in Biblioteca.Catalogo) {
                if (material.Id == id) {
                    return material;
                }
            }
            return null;
        }
    }
}
