﻿
namespace Consultorio
{
    partial class Fmantanalisis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmantanalisis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Bbuscar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BNuevo = new System.Windows.Forms.Button();
            this.BEditar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbIdanalisis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 106);
            this.panel1.TabIndex = 73;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(262, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 47);
            this.label4.TabIndex = 51;
            this.label4.Text = "Mantenimiento Analisis";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Bbuscar
            // 
            this.Bbuscar.Location = new System.Drawing.Point(648, 175);
            this.Bbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bbuscar.Name = "Bbuscar";
            this.Bbuscar.Size = new System.Drawing.Size(112, 54);
            this.Bbuscar.TabIndex = 71;
            this.Bbuscar.Text = "Buscar";
            this.Bbuscar.UseVisualStyleBackColor = true;
            this.Bbuscar.Click += new System.EventHandler(this.Bbuscar_Click);
            // 
            // BSalir
            // 
            this.BSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BSalir.BackgroundImage")));
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BSalir.Location = new System.Drawing.Point(28, 374);
            this.BSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(82, 75);
            this.BSalir.TabIndex = 53;
            this.BSalir.Tag = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BCancelar.BackgroundImage")));
            this.BCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BCancelar.Location = new System.Drawing.Point(28, 268);
            this.BCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(82, 77);
            this.BCancelar.TabIndex = 70;
            this.BCancelar.Tag = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BNuevo
            // 
            this.BNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BNuevo.BackgroundImage")));
            this.BNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BNuevo.Location = new System.Drawing.Point(28, 12);
            this.BNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BNuevo.Name = "BNuevo";
            this.BNuevo.Size = new System.Drawing.Size(82, 74);
            this.BNuevo.TabIndex = 69;
            this.BNuevo.Tag = "Nuevo";
            this.BNuevo.UseVisualStyleBackColor = true;
            this.BNuevo.Click += new System.EventHandler(this.BNuevo_Click);
            // 
            // BEditar
            // 
            this.BEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BEditar.BackgroundImage")));
            this.BEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BEditar.Location = new System.Drawing.Point(28, 183);
            this.BEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(82, 75);
            this.BEditar.TabIndex = 68;
            this.BEditar.Tag = "Editar";
            this.BEditar.UseVisualStyleBackColor = true;
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BGuardar.BackgroundImage")));
            this.BGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BGuardar.Location = new System.Drawing.Point(28, 95);
            this.BGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(82, 78);
            this.BGuardar.TabIndex = 67;
            this.BGuardar.Tag = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(364, 349);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(294, 95);
            this.tbDescripcion.TabIndex = 63;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(364, 263);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(294, 26);
            this.tbNombre.TabIndex = 62;
            // 
            // tbIdanalisis
            // 
            this.tbIdanalisis.Location = new System.Drawing.Point(513, 188);
            this.tbIdanalisis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIdanalisis.Name = "tbIdanalisis";
            this.tbIdanalisis.Size = new System.Drawing.Size(106, 26);
            this.tbIdanalisis.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Codigo Analisis";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.BNuevo);
            this.panel2.Controls.Add(this.BGuardar);
            this.panel2.Controls.Add(this.BEditar);
            this.panel2.Controls.Add(this.BSalir);
            this.panel2.Controls.Add(this.BCancelar);
            this.panel2.Location = new System.Drawing.Point(852, 120);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 469);
            this.panel2.TabIndex = 72;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(18, 175);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 282);
            this.panel3.TabIndex = 74;
            // 
            // Fmantanalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 608);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Bbuscar);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbIdanalisis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Fmantanalisis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fmantanalisis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fmantanalisis_FormClosing);
            this.Load += new System.EventHandler(this.Fmantanalisis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bbuscar;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BNuevo;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbIdanalisis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}