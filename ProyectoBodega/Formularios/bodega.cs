using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBodega
{
    public partial class bodega : Form
    {
        public bodega()
        {
            InitializeComponent();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearUsuario crearUsuario= new CrearUsuario();
            crearUsuario.Show();
            this.Hide();
        }

    }
}
