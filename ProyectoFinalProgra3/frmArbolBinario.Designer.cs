
namespace ProyectoFinalProgra3
{
    partial class frmArbolBinario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbolBinario));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnNumNodos = new System.Windows.Forms.Button();
            this.btnEncontrarPadre = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnExtra = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnTransversa = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.cbAlumnos = new System.Windows.Forms.ComboBox();
            this.vistaalumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFinal = new ProyectoFinalProgra3.dsFinal();
            this.pbArbolBinario = new System.Windows.Forms.PictureBox();
            this.vista_alumnoTableAdapter = new ProyectoFinalProgra3.dsFinalTableAdapters.vista_alumnoTableAdapter();
            this.txtPreOrder = new System.Windows.Forms.TextBox();
            this.txtInOrder = new System.Windows.Forms.TextBox();
            this.txtPostOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaalumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArbolBinario)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtPostOrder);
            this.splitContainer1.Panel1.Controls.Add(this.txtInOrder);
            this.splitContainer1.Panel1.Controls.Add(this.txtPreOrder);
            this.splitContainer1.Panel1.Controls.Add(this.btnNumNodos);
            this.splitContainer1.Panel1.Controls.Add(this.btnEncontrarPadre);
            this.splitContainer1.Panel1.Controls.Add(this.btnEliminar);
            this.splitContainer1.Panel1.Controls.Add(this.btnExtra);
            this.splitContainer1.Panel1.Controls.Add(this.btnBusqueda);
            this.splitContainer1.Panel1.Controls.Add(this.btnAltura);
            this.splitContainer1.Panel1.Controls.Add(this.btnTransversa);
            this.splitContainer1.Panel1.Controls.Add(this.btninsertar);
            this.splitContainer1.Panel1.Controls.Add(this.cbAlumnos);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbArbolBinario);
            this.splitContainer1.Size = new System.Drawing.Size(1983, 929);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnNumNodos
            // 
            this.btnNumNodos.Location = new System.Drawing.Point(1605, 31);
            this.btnNumNodos.Name = "btnNumNodos";
            this.btnNumNodos.Size = new System.Drawing.Size(167, 34);
            this.btnNumNodos.TabIndex = 7;
            this.btnNumNodos.Text = "# Nodos";
            this.btnNumNodos.UseVisualStyleBackColor = true;
            this.btnNumNodos.Click += new System.EventHandler(this.btnNumNodos_Click);
            // 
            // btnEncontrarPadre
            // 
            this.btnEncontrarPadre.Location = new System.Drawing.Point(1411, 31);
            this.btnEncontrarPadre.Name = "btnEncontrarPadre";
            this.btnEncontrarPadre.Size = new System.Drawing.Size(176, 34);
            this.btnEncontrarPadre.TabIndex = 6;
            this.btnEncontrarPadre.Text = "Encontrar Padre";
            this.btnEncontrarPadre.UseVisualStyleBackColor = true;
            this.btnEncontrarPadre.Click += new System.EventHandler(this.btnEncontrarPadre_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1218, 31);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(177, 34);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnExtra
            // 
            this.btnExtra.Location = new System.Drawing.Point(1795, 31);
            this.btnExtra.Name = "btnExtra";
            this.btnExtra.Size = new System.Drawing.Size(167, 34);
            this.btnExtra.TabIndex = 4;
            this.btnExtra.Text = "Extra";
            this.btnExtra.UseVisualStyleBackColor = true;
            this.btnExtra.Click += new System.EventHandler(this.btnExtra_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(1026, 31);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(174, 34);
            this.btnBusqueda.TabIndex = 2;
            this.btnBusqueda.Text = "Busqueda";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(835, 31);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(171, 34);
            this.btnAltura.TabIndex = 3;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btnTransversa
            // 
            this.btnTransversa.Location = new System.Drawing.Point(645, 31);
            this.btnTransversa.Name = "btnTransversa";
            this.btnTransversa.Size = new System.Drawing.Size(171, 34);
            this.btnTransversa.TabIndex = 2;
            this.btnTransversa.Text = "Transversa";
            this.btnTransversa.UseVisualStyleBackColor = true;
            this.btnTransversa.Click += new System.EventHandler(this.btnTransversa_Click);
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(465, 31);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(163, 34);
            this.btninsertar.TabIndex = 1;
            this.btninsertar.Text = "Insertar Nodo";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // cbAlumnos
            // 
            this.cbAlumnos.DataSource = this.vistaalumnoBindingSource;
            this.cbAlumnos.DisplayMember = "nombre_completo";
            this.cbAlumnos.FormattingEnabled = true;
            this.cbAlumnos.Location = new System.Drawing.Point(12, 37);
            this.cbAlumnos.Name = "cbAlumnos";
            this.cbAlumnos.Size = new System.Drawing.Size(435, 24);
            this.cbAlumnos.TabIndex = 0;
            this.cbAlumnos.ValueMember = "id_alumno";
            // 
            // vistaalumnoBindingSource
            // 
            this.vistaalumnoBindingSource.DataMember = "vista_alumno";
            this.vistaalumnoBindingSource.DataSource = this.dsFinal;
            // 
            // dsFinal
            // 
            this.dsFinal.DataSetName = "dsFinal";
            this.dsFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pbArbolBinario
            // 
            this.pbArbolBinario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbArbolBinario.Location = new System.Drawing.Point(0, 0);
            this.pbArbolBinario.Name = "pbArbolBinario";
            this.pbArbolBinario.Size = new System.Drawing.Size(1983, 644);
            this.pbArbolBinario.TabIndex = 0;
            this.pbArbolBinario.TabStop = false;
            this.pbArbolBinario.Click += new System.EventHandler(this.pbArbolBinario_Click);
            this.pbArbolBinario.Paint += new System.Windows.Forms.PaintEventHandler(this.pbArbolBinario_Paint);
            this.pbArbolBinario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbArbolBinario_MouseClick);
            // 
            // vista_alumnoTableAdapter
            // 
            this.vista_alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // txtPreOrder
            // 
            this.txtPreOrder.Location = new System.Drawing.Point(45, 102);
            this.txtPreOrder.Multiline = true;
            this.txtPreOrder.Name = "txtPreOrder";
            this.txtPreOrder.Size = new System.Drawing.Size(359, 152);
            this.txtPreOrder.TabIndex = 8;
            // 
            // txtInOrder
            // 
            this.txtInOrder.Location = new System.Drawing.Point(779, 103);
            this.txtInOrder.Multiline = true;
            this.txtInOrder.Name = "txtInOrder";
            this.txtInOrder.Size = new System.Drawing.Size(359, 151);
            this.txtInOrder.TabIndex = 9;
            // 
            // txtPostOrder
            // 
            this.txtPostOrder.Location = new System.Drawing.Point(1588, 103);
            this.txtPostOrder.Multiline = true;
            this.txtPostOrder.Name = "txtPostOrder";
            this.txtPostOrder.Size = new System.Drawing.Size(359, 151);
            this.txtPostOrder.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Recorrido PreOrder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(776, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Recorrido InOrder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1585, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Recorrido PostOrder:";
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1983, 929);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArbolBinario";
            this.Text = "Generacion & Analisis Arbol Binario Busqueda";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vistaalumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArbolBinario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbAlumnos;
        private System.Windows.Forms.PictureBox pbArbolBinario;
        private dsFinal dsFinal;
        private System.Windows.Forms.BindingSource vistaalumnoBindingSource;
        private dsFinalTableAdapters.vista_alumnoTableAdapter vista_alumnoTableAdapter;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnTransversa;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btnExtra;
        private System.Windows.Forms.Button btnEncontrarPadre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNumNodos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPostOrder;
        private System.Windows.Forms.TextBox txtInOrder;
        private System.Windows.Forms.TextBox txtPreOrder;
    }
}