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
    public partial class ReportePacientes : Form
    {
        
        public ReportePacientes()
        {
            InitializeComponent();
        }

        private void ReportePacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Paciente' Puede moverla o quitarla según sea necesario.
            //this.PacienteTableAdapter.Fill(this.Database1DataSet.Paciente);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
