
namespace Consultorio
{
    partial class ConsultaMedicamentos
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
            this.DGVdatos = new System.Windows.Forms.DataGridView();
            this.iDMedicamentosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laboratorioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraindicacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Consultorio.Database1DataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Bbuscar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.medicamentosTableAdapter = new Consultorio.Database1DataSetTableAdapters.MedicamentosTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVdatos
            // 
            this.DGVdatos.AllowUserToAddRows = false;
            this.DGVdatos.AllowUserToDeleteRows = false;
            this.DGVdatos.AutoGenerateColumns = false;
            this.DGVdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMedicamentosDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.componentesDataGridViewTextBoxColumn,
            this.laboratorioDataGridViewTextBoxColumn,
            this.dosisDataGridViewTextBoxColumn,
            this.contraindicacionesDataGridViewTextBoxColumn});
            this.DGVdatos.DataSource = this.medicamentosBindingSource;
            this.DGVdatos.Location = new System.Drawing.Point(4, 220);
            this.DGVdatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVdatos.Name = "DGVdatos";
            this.DGVdatos.ReadOnly = true;
            this.DGVdatos.RowHeadersWidth = 62;
            this.DGVdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVdatos.Size = new System.Drawing.Size(1202, 355);
            this.DGVdatos.TabIndex = 11;
            // 
            // iDMedicamentosDataGridViewTextBoxColumn
            // 
            this.iDMedicamentosDataGridViewTextBoxColumn.DataPropertyName = "ID_Medicamentos";
            this.iDMedicamentosDataGridViewTextBoxColumn.HeaderText = "ID_Medicamentos";
            this.iDMedicamentosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDMedicamentosDataGridViewTextBoxColumn.Name = "iDMedicamentosDataGridViewTextBoxColumn";
            this.iDMedicamentosDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDMedicamentosDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // componentesDataGridViewTextBoxColumn
            // 
            this.componentesDataGridViewTextBoxColumn.DataPropertyName = "Componentes";
            this.componentesDataGridViewTextBoxColumn.HeaderText = "Componentes";
            this.componentesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.componentesDataGridViewTextBoxColumn.Name = "componentesDataGridViewTextBoxColumn";
            this.componentesDataGridViewTextBoxColumn.ReadOnly = true;
            this.componentesDataGridViewTextBoxColumn.Width = 150;
            // 
            // laboratorioDataGridViewTextBoxColumn
            // 
            this.laboratorioDataGridViewTextBoxColumn.DataPropertyName = "Laboratorio";
            this.laboratorioDataGridViewTextBoxColumn.HeaderText = "Laboratorio";
            this.laboratorioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.laboratorioDataGridViewTextBoxColumn.Name = "laboratorioDataGridViewTextBoxColumn";
            this.laboratorioDataGridViewTextBoxColumn.ReadOnly = true;
            this.laboratorioDataGridViewTextBoxColumn.Width = 150;
            // 
            // dosisDataGridViewTextBoxColumn
            // 
            this.dosisDataGridViewTextBoxColumn.DataPropertyName = "Dosis";
            this.dosisDataGridViewTextBoxColumn.HeaderText = "Dosis";
            this.dosisDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dosisDataGridViewTextBoxColumn.Name = "dosisDataGridViewTextBoxColumn";
            this.dosisDataGridViewTextBoxColumn.ReadOnly = true;
            this.dosisDataGridViewTextBoxColumn.Width = 150;
            // 
            // contraindicacionesDataGridViewTextBoxColumn
            // 
            this.contraindicacionesDataGridViewTextBoxColumn.DataPropertyName = "Contraindicaciones";
            this.contraindicacionesDataGridViewTextBoxColumn.HeaderText = "Contraindicaciones";
            this.contraindicacionesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contraindicacionesDataGridViewTextBoxColumn.Name = "contraindicacionesDataGridViewTextBoxColumn";
            this.contraindicacionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.contraindicacionesDataGridViewTextBoxColumn.Width = 150;
            // 
            // medicamentosBindingSource
            // 
            this.medicamentosBindingSource.DataMember = "Medicamentos";
            this.medicamentosBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Bbuscar);
            this.panel2.Controls.Add(this.tbBuscar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 95);
            this.panel2.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(859, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 57);
            this.button2.TabIndex = 5;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(1046, 585);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bbuscar
            // 
            this.Bbuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Bbuscar.Location = new System.Drawing.Point(640, 21);
            this.Bbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bbuscar.Name = "Bbuscar";
            this.Bbuscar.Size = new System.Drawing.Size(141, 57);
            this.Bbuscar.TabIndex = 3;
            this.Bbuscar.Text = "Buscar";
            this.Bbuscar.UseVisualStyleBackColor = false;
            this.Bbuscar.Click += new System.EventHandler(this.Bbuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(256, 35);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(319, 26);
            this.tbBuscar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el dato a buscar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 114);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(346, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta Medicamentos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // medicamentosTableAdapter
            // 
            this.medicamentosTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 579);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 68);
            this.button4.TabIndex = 19;
            this.button4.Text = "Primero";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 579);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 68);
            this.button3.TabIndex = 18;
            this.button3.Text = "Ultimo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(364, 579);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 68);
            this.button5.TabIndex = 17;
            this.button5.Text = "Siguiente";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(244, 579);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 68);
            this.button6.TabIndex = 16;
            this.button6.Text = "Anterior";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ConsultaMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 654);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.DGVdatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsultaMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaMedicamentos";
            this.Load += new System.EventHandler(this.ConsultaMedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVdatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Bbuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource medicamentosBindingSource;
        private Database1DataSetTableAdapters.MedicamentosTableAdapter medicamentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMedicamentosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laboratorioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraindicacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}