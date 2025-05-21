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
    public partial class Inicio : Form


    {

        private Servicios servicio;

        internal Servicios Servicio { get => servicio; set => servicio = value; }

        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personas personas = new Personas();
            personas.SetServicio(this.servicio);
            personas.Show();
            this.Hide();

        }

        internal void SetServicio(Servicios servicio) {
            this.Servicio = servicio;
        }
    }
}
