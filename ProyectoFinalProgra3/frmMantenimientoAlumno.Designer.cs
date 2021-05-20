
namespace ProyectoFinalProgra3
{
    partial class frmMantenimientoAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoAlumno));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsFinal = new ProyectoFinalProgra3.dsFinal();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoTableAdapter = new ProyectoFinalProgra3.dsFinalTableAdapters.alumnoTableAdapter();
            this.carreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carreraTableAdapter = new ProyectoFinalProgra3.dsFinalTableAdapters.carreraTableAdapter();
            this.idalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idarbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcarreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnGuardar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1760, 667);
            this.splitContainer1.SplitterDistance = 141;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 64);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 54);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalumnoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.carnetDataGridViewTextBoxColumn,
            this.idarbolDataGridViewTextBoxColumn,
            this.idcarreraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alumnoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1615, 667);
            this.dataGridView1.TabIndex = 0;
            // 
            // dsFinal
            // 
            this.dsFinal.DataSetName = "dsFinal";
            this.dsFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "alumno";
            this.alumnoBindingSource.DataSource = this.dsFinal;
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // carreraBindingSource
            // 
            this.carreraBindingSource.DataMember = "carrera";
            this.carreraBindingSource.DataSource = this.dsFinal;
            // 
            // carreraTableAdapter
            // 
            this.carreraTableAdapter.ClearBeforeFill = true;
            // 
            // idalumnoDataGridViewTextBoxColumn
            // 
            this.idalumnoDataGridViewTextBoxColumn.DataPropertyName = "id_alumno";
            this.idalumnoDataGridViewTextBoxColumn.HeaderText = "ID Alumno";
            this.idalumnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idalumnoDataGridViewTextBoxColumn.Name = "idalumnoDataGridViewTextBoxColumn";
            this.idalumnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // carnetDataGridViewTextBoxColumn
            // 
            this.carnetDataGridViewTextBoxColumn.DataPropertyName = "carnet";
            this.carnetDataGridViewTextBoxColumn.HeaderText = "# Carnet";
            this.carnetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carnetDataGridViewTextBoxColumn.Name = "carnetDataGridViewTextBoxColumn";
            this.carnetDataGridViewTextBoxColumn.Width = 125;
            // 
            // idarbolDataGridViewTextBoxColumn
            // 
            this.idarbolDataGridViewTextBoxColumn.DataPropertyName = "id_arbol";
            this.idarbolDataGridViewTextBoxColumn.HeaderText = "ID Arbol";
            this.idarbolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idarbolDataGridViewTextBoxColumn.Name = "idarbolDataGridViewTextBoxColumn";
            this.idarbolDataGridViewTextBoxColumn.Width = 125;
            // 
            // idcarreraDataGridViewTextBoxColumn
            // 
            this.idcarreraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idcarreraDataGridViewTextBoxColumn.DataPropertyName = "id_carrera";
            this.idcarreraDataGridViewTextBoxColumn.DataSource = this.carreraBindingSource;
            this.idcarreraDataGridViewTextBoxColumn.DisplayMember = "descripcion";
            this.idcarreraDataGridViewTextBoxColumn.HeaderText = "ID Carrera";
            this.idcarreraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcarreraDataGridViewTextBoxColumn.Name = "idcarreraDataGridViewTextBoxColumn";
            this.idcarreraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idcarreraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idcarreraDataGridViewTextBoxColumn.ValueMember = "id_carrera";
            // 
            // frmMantenimientoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 667);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMantenimientoAlumno";
            this.Text = "Mantenimiento - Alumno";
            this.Load += new System.EventHandler(this.frmMantenimientoAlumno_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dsFinal dsFinal;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private dsFinalTableAdapters.alumnoTableAdapter alumnoTableAdapter;
        private System.Windows.Forms.BindingSource carreraBindingSource;
        private dsFinalTableAdapters.carreraTableAdapter carreraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idarbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idcarreraDataGridViewTextBoxColumn;
    }
}