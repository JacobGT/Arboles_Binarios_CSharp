using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProgra3
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoAlumno mantenimientoAlumno = new frmMantenimientoAlumno();
            mantenimientoAlumno.MdiParent = this;
            mantenimientoAlumno.Show();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoCarrera mantenimientoCarrera = new frmMantenimientoCarrera();
            mantenimientoCarrera.MdiParent = this;
            mantenimientoCarrera.Show();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void genereacionDeArbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario arbolBinario = new frmArbolBinario();
            arbolBinario.MdiParent = this;
            arbolBinario.Show();
        }
    }
}
