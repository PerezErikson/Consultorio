using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class FPacienteReporteParametros : Form
    {
        
        public FPacienteReporteParametros()
        {
            InitializeComponent();
        }
        

        private void FPacienteReporteParametros_Load(object sender, EventArgs e)

        {
            // TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Paciente' Puede moverla o quitarla según sea necesario.
            this.PacienteTableAdapter.Fill(this.Database1DataSet.Paciente);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.PacienteTableAdapter.FillBy1(this.Database1DataSet.Paciente);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.PacienteTableAdapter.Masculino(this.Database1DataSet.Paciente);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Btsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
