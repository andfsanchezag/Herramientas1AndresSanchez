using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Personas : Form

    {
        private Servicios servicio;

        internal Servicios Servicio { get => servicio; set => servicio = value; }

        public Personas()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            string cedula = Cedula.Text;
            string role = Role.Text;
            if (nombre == "") {
                MessageBox.Show("el nombre no puede ser vacio");
                return;
            }
            if (cedula == "")
            {
                MessageBox.Show("la cedula no puede ser vacio");
                return;
            }
            if (!Servicio.validarRole(role))
            {
                MessageBox.Show("el role debe ser Estudiante, Administrativo o Profesor");
                return;
            }
            List<Material> prestamos = new List<Material>();
            Persona persona = new Persona(nombre, cedula, role, prestamos);
            MessageBox.Show(this.Servicio.CrearPersona(persona));
            Nombre.ResetText();
            Cedula.ResetText();
            Role.ResetText();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        internal void SetServicio(Servicios servicio)
        {
            this.servicio = servicio;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.SetServicio(this.servicio);
            inicio.Show();
            this.Hide();
        }
    }
}
