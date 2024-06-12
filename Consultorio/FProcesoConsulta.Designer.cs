
namespace Consultorio
{
    partial class FProcesoConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProcesoConsulta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bbuscarpaciente = new System.Windows.Forms.Button();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbcodpaciente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbfecha = new System.Windows.Forms.TextBox();
            this.tbidconsulta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbantecedentes = new System.Windows.Forms.TextBox();
            this.tbsintomas = new System.Windows.Forms.TextBox();
            this.tbenfermedades = new System.Windows.Forms.TextBox();
            this.tbmotivo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbdiagnostico = new System.Windows.Forms.TextBox();
            this.bnuevo = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.bcancelar = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 115);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(466, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proceso Consulta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bbuscarpaciente);
            this.groupBox1.Controls.Add(this.tbtelefono);
            this.groupBox1.Controls.Add(this.tbapellido);
            this.groupBox1.Controls.Add(this.tbnombre);
            this.groupBox1.Controls.Add(this.tbcodpaciente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 171);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(514, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paciente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bbuscarpaciente
            // 
            this.bbuscarpaciente.Location = new System.Drawing.Point(282, 35);
            this.bbuscarpaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bbuscarpaciente.Name = "bbuscarpaciente";
            this.bbuscarpaciente.Size = new System.Drawing.Size(112, 35);
            this.bbuscarpaciente.TabIndex = 8;
            this.bbuscarpaciente.Text = "Buscar";
            this.bbuscarpaciente.UseVisualStyleBackColor = true;
            this.bbuscarpaciente.Click += new System.EventHandler(this.bbuscarpaciente_Click);
            // 
            // tbtelefono
            // 
            this.tbtelefono.Enabled = false;
            this.tbtelefono.Location = new System.Drawing.Point(94, 160);
            this.tbtelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(247, 30);
            this.tbtelefono.TabIndex = 7;
            // 
            // tbapellido
            // 
            this.tbapellido.Enabled = false;
            this.tbapellido.Location = new System.Drawing.Point(96, 117);
            this.tbapellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(373, 30);
            this.tbapellido.TabIndex = 6;
            // 
            // tbnombre
            // 
            this.tbnombre.Enabled = false;
            this.tbnombre.Location = new System.Drawing.Point(94, 78);
            this.tbnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(374, 30);
            this.tbnombre.TabIndex = 5;
            // 
            // tbcodpaciente
            // 
            this.tbcodpaciente.Location = new System.Drawing.Point(148, 35);
            this.tbcodpaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcodpaciente.Name = "tbcodpaciente";
            this.tbcodpaciente.ReadOnly = true;
            this.tbcodpaciente.Size = new System.Drawing.Size(120, 30);
            this.tbcodpaciente.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Paciente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "No. Consulta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fecha:";
            // 
            // tbfecha
            // 
            this.tbfecha.Enabled = false;
            this.tbfecha.Location = new System.Drawing.Point(400, 131);
            this.tbfecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbfecha.Name = "tbfecha";
            this.tbfecha.Size = new System.Drawing.Size(148, 26);
            this.tbfecha.TabIndex = 4;
            this.tbfecha.TextChanged += new System.EventHandler(this.tbfecha_TextChanged);
            // 
            // tbidconsulta
            // 
            this.tbidconsulta.Enabled = false;
            this.tbidconsulta.Location = new System.Drawing.Point(130, 131);
            this.tbidconsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbidconsulta.Name = "tbidconsulta";
            this.tbidconsulta.ReadOnly = true;
            this.tbidconsulta.Size = new System.Drawing.Size(148, 26);
            this.tbidconsulta.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbantecedentes);
            this.groupBox2.Controls.Add(this.tbsintomas);
            this.groupBox2.Controls.Add(this.tbenfermedades);
            this.groupBox2.Controls.Add(this.tbmotivo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 415);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(936, 258);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Consulta";
            // 
            // tbantecedentes
            // 
            this.tbantecedentes.Location = new System.Drawing.Point(554, 32);
            this.tbantecedentes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbantecedentes.Multiline = true;
            this.tbantecedentes.Name = "tbantecedentes";
            this.tbantecedentes.Size = new System.Drawing.Size(342, 93);
            this.tbantecedentes.TabIndex = 7;
            // 
            // tbsintomas
            // 
            this.tbsintomas.Location = new System.Drawing.Point(96, 188);
            this.tbsintomas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbsintomas.Multiline = true;
            this.tbsintomas.Name = "tbsintomas";
            this.tbsintomas.Size = new System.Drawing.Size(307, 59);
            this.tbsintomas.TabIndex = 6;
            // 
            // tbenfermedades
            // 
            this.tbenfermedades.Location = new System.Drawing.Point(134, 105);
            this.tbenfermedades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbenfermedades.Multiline = true;
            this.tbenfermedades.Name = "tbenfermedades";
            this.tbenfermedades.Size = new System.Drawing.Size(270, 61);
            this.tbenfermedades.TabIndex = 5;
            // 
            // tbmotivo
            // 
            this.tbmotivo.Location = new System.Drawing.Point(78, 32);
            this.tbmotivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbmotivo.Multiline = true;
            this.tbmotivo.Name = "tbmotivo";
            this.tbmotivo.Size = new System.Drawing.Size(325, 46);
            this.tbmotivo.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(438, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Antecedentes:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 188);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Sintomas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Enfermedades:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Motivo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(574, 185);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 23);
            this.label12.TabIndex = 7;
            this.label12.Text = "Diagnostico";
            // 
            // tbdiagnostico
            // 
            this.tbdiagnostico.Location = new System.Drawing.Point(579, 214);
            this.tbdiagnostico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbdiagnostico.Multiline = true;
            this.tbdiagnostico.Name = "tbdiagnostico";
            this.tbdiagnostico.Size = new System.Drawing.Size(366, 142);
            this.tbdiagnostico.TabIndex = 8;
            // 
            // bnuevo
            // 
            this.bnuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnuevo.BackgroundImage")));
            this.bnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnuevo.Location = new System.Drawing.Point(1048, 158);
            this.bnuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(76, 75);
            this.bnuevo.TabIndex = 9;
            this.bnuevo.Tag = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = true;
            this.bnuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // bguardar
            // 
            this.bguardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bguardar.BackgroundImage")));
            this.bguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bguardar.Enabled = false;
            this.bguardar.Location = new System.Drawing.Point(1048, 243);
            this.bguardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(76, 69);
            this.bguardar.TabIndex = 10;
            this.bguardar.Tag = "Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // bcancelar
            // 
            this.bcancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bcancelar.BackgroundImage")));
            this.bcancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bcancelar.Location = new System.Drawing.Point(1048, 322);
            this.bcancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(76, 68);
            this.bcancelar.TabIndex = 12;
            this.bcancelar.Tag = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = true;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // bsalir
            // 
            this.bsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bsalir.BackgroundImage")));
            this.bsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bsalir.Location = new System.Drawing.Point(1048, 422);
            this.bsalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(76, 74);
            this.bsalir.TabIndex = 13;
            this.bsalir.Tag = "Salir";
            this.bsalir.UseVisualStyleBackColor = true;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(1029, 134);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 382);
            this.panel2.TabIndex = 14;
            // 
            // FProcesoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.bcancelar);
            this.Controls.Add(this.bguardar);
            this.Controls.Add(this.bnuevo);
            this.Controls.Add(this.tbdiagnostico);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbidconsulta);
            this.Controls.Add(this.tbfecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FProcesoConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FProcesoConsulta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FProcesoConsulta_FormClosing);
            this.Load += new System.EventHandler(this.FProcesoConsulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbcodpaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbfecha;
        private System.Windows.Forms.TextBox tbidconsulta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbantecedentes;
        private System.Windows.Forms.TextBox tbsintomas;
        private System.Windows.Forms.TextBox tbenfermedades;
        private System.Windows.Forms.TextBox tbmotivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbdiagnostico;
        private System.Windows.Forms.Button bbuscarpaciente;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.Panel panel2;
    }
}