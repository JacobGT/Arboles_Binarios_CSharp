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
    public partial class frmMantenimientoCarrera : Form
    {
        public frmMantenimientoCarrera()
        {
            InitializeComponent();
        }

        private void frmMantenimientoCarrera_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsFinal.carrera' table. You can move, or remove it, as needed.
            this.carreraTableAdapter.Fill(this.dsFinal.carrera);


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.carreraTableAdapter.Update(this.dsFinal.carrera);
                this.carreraTableAdapter.Fill(this.dsFinal.carrera);
            } catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
            
        }
    }
}
