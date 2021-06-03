using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ProyectoFinalProgra3
{
    public partial class frmArbolBinario : Form
    {
        public static string ccCadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jacob\Progra\USPG\C#\FinalProgra3\ProyectoFinalProgra3\bin\Debug\FinalProject.mdb";
        public OleDbConnection cnAlumno = new OleDbConnection(ccCadenaConexion);

        public frmArbolBinario()
        {
            InitializeComponent();
        }

        Arbol_Binario binaryTree = new Arbol_Binario(null);
        Graphics grafico;
        bool busqueda = false;

        // Creamos un list para poder almacenar a los alumnos
        List<alumno> listaAlumnos = new List<alumno>();

        Nodo_Arbol tempColorear = null;

        public Rectangle areaNodo;

        public int numNodos = 0;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void agregarAlumno(int idArbol)
        {
            OleDbCommand cmdAlumno = new OleDbCommand();
            cmdAlumno.CommandText = "select * from alumno where id_arbol = @id_arbol";
            cmdAlumno.Parameters.AddWithValue("@id_arbol", idArbol);
            cmdAlumno.Connection = cnAlumno;
            cnAlumno.Open();

            OleDbDataReader drAlumno = cmdAlumno.ExecuteReader();

            alumno tempAlumno = new alumno();

            while (drAlumno.Read())
            {
                tempAlumno.IdAlumno = int.Parse(drAlumno[0].ToString());
                tempAlumno.Nombre = drAlumno[1].ToString();
                tempAlumno.Apellido = drAlumno[2].ToString();
                tempAlumno.Carnet = drAlumno[3].ToString();
                tempAlumno.IdArbol = int.Parse(drAlumno[4].ToString());
                tempAlumno.IdCarrera = int.Parse(drAlumno[5].ToString());
            }
            cnAlumno.Close();
            drAlumno.Close();

            listaAlumnos.Add(tempAlumno);
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsFinal.vista_alumno' table. You can move, or remove it, as needed.
            this.vista_alumnoTableAdapter.Fill(this.dsFinal.vista_alumno);

        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            DataRowView fila = (DataRowView)cbAlumnos.SelectedItem;
            int dato = int.Parse(fila.Row[2].ToString());
            binaryTree.Insertar(dato);
            agregarAlumno(dato);
            pbArbolBinario.Refresh();
            numNodos++;
        }

        private void pbArbolBinario_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            grafico = e.Graphics;
            binaryTree.DibujarArbol(grafico, this.Font, Brushes.DarkOliveGreen, Brushes.White, Pens.Black, Brushes.Black);

            if (busqueda == true)
            {
                if (tempColorear != null)
                {
                    tempColorear.colorear(grafico, this.Font, Brushes.Red, Brushes.Black, Pens.Black);
                }
                //binaryTree.colorear(grafico, this.Font, Brushes.Red, Brushes.Black, Pens.Black, binaryTree.aux, true, true, true);
                busqueda = false;
            }

        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            DataRowView fila = (DataRowView)cbAlumnos.SelectedItem;
            int dato = int.Parse(fila.Row[2].ToString());
            binaryTree.Buscar(dato);
            tempColorear = binaryTree.TransversaColorear(dato, binaryTree.Raiz);
            busqueda = true;
            pbArbolBinario.Refresh();
            
            foreach (alumno student in listaAlumnos)
            {
                if (student.IdArbol == dato)
                {
                    MessageBox.Show(student.IterarInformacion(), "Informacion del Nodo: ");
                }
            }
        }

        private void btnTransversa_Click(object sender, EventArgs e)
        {
            binaryTree.TransversaPreOrder(binaryTree.Raiz);
            MessageBox.Show(binaryTree.IteracionPreOrder, "Transversa PreOrder:");
            binaryTree.IteracionPreOrder = "";

            binaryTree.TransversaInOrder(binaryTree.Raiz);
            MessageBox.Show(binaryTree.IteracionInOrder, "Transversa InOrder");
            binaryTree.IteracionInOrder = "";

            binaryTree.TransversaPostOrder(binaryTree.Raiz);
            MessageBox.Show(binaryTree.IteracionPostOrder, "Transversa PostOrder");
            binaryTree.IteracionPostOrder = "";
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            binaryTree.TransversaAltura(binaryTree.Raiz);
            MessageBox.Show("Altura: " + (binaryTree.AlturaMax + 1).ToString(), "Altura de Arbol: ");
        }

        private void btnExtra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El valor más pequeño es: " + binaryTree.ValorPequeño(binaryTree.Raiz), "Extra - Valor Pequeño: ");
            MessageBox.Show("El valor más grande es: " + binaryTree.ValorGrande(binaryTree.Raiz), "Extra - Valor Grande: ");
        }

        private void pbArbolBinario_Click(object sender, EventArgs e)
        {

        }

        private void pbArbolBinario_MouseClick(object sender, MouseEventArgs e)
        {
            int infoNodoBuscar = binaryTree.encontrarInfoNodo(binaryTree.Raiz, e);

            foreach (alumno student in listaAlumnos)
            {
                if (student.IdArbol == infoNodoBuscar)
                {
                    MessageBox.Show(student.IterarInformacion(), "Informacion del Nodo: ");
                }
            }

            /*bool found = false;
            binaryTree.AreaNodo(binaryTree.Raiz);
            int length = binaryTree.areasNodos.Count();
            int posicionNodo = 0;
            for (int cont = 0; cont < length; cont++)
            {
                foreach (Rectangle rect in binaryTree.areasNodos)
                {
                    if (rect.Contains(e.Location))
                    {
                        found = true;
                        posicionNodo = cont;
                    }
                }
            }

            foreach (alumno student in listaAlumnos)
            {
                if (student.IdArbol == binaryTree.identificadorAreasNodos[posicionNodo])
                {
                    MessageBox.Show(student.IterarInformacion(), "Informacion del Nodo: ");
                }
            }*/

            /*foreach (Rectangle rect in binaryTree.areasNodos)
            {
                if (rect.Contains(e.Location))
                {
                    foreach (alumno student in listaAlumnos)
                    {
                        if (student.IdArbol == binaryTree.identificadorAreasNodos[cont])
                        {
                            MessageBox.Show(student.IterarInformacion(), "Informacion del Nodo: ");
                        }
                    }
                }
            }*/
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataRowView fila = (DataRowView)cbAlumnos.SelectedItem;
            int dato = int.Parse(fila.Row[2].ToString());
            binaryTree.Eliminar(dato);
            pbArbolBinario.Refresh();
            numNodos--;
        }

        private void btnEncontrarPadre_Click(object sender, EventArgs e)
        {
            DataRowView fila = (DataRowView)cbAlumnos.SelectedItem;
            int dato = int.Parse(fila.Row[2].ToString());
            Nodo_Arbol temp = binaryTree.BuscarPadre(dato, binaryTree.Raiz);
            int idPadre = temp.info;

            foreach (alumno student in listaAlumnos)
            {
                if (student.IdArbol == idPadre)
                {
                    MessageBox.Show(student.IterarInformacion(), "Informacion del Nodo Padre: ");
                }
            }
        }

        private void btnNumNodos_Click(object sender, EventArgs e)
        {
            binaryTree.TransversaNumeroNodos(binaryTree.Raiz);
            MessageBox.Show(binaryTree.RevisionNumeroNodos(binaryTree.NumeroNodos).ToString(), "Cantidad de Nodos Existentes: ");
            binaryTree.NumeroNodos = "";

            //MessageBox.Show(numNodos.ToString(), "Cantidad de Nodos Existentes: ");
        }
    }
}
