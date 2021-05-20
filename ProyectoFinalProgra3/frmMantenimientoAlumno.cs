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
    public partial class frmMantenimientoAlumno : Form
    {
        public frmMantenimientoAlumno()
        {
            InitializeComponent();
        }

        private void frmMantenimientoAlumno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsFinal.carrera' table. You can move, or remove it, as needed.
            this.carreraTableAdapter.Fill(this.dsFinal.carrera);
            // TODO: This line of code loads data into the 'dsFinal.alumno' table. You can move, or remove it, as needed.
            this.alumnoTableAdapter.Fill(this.dsFinal.alumno);


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.alumnoTableAdapter.Update(this.dsFinal.alumno);
            this.alumnoTableAdapter.Fill(this.dsFinal.alumno);
        }
    }
}
