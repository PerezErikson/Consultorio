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
    public partial class FPacienteParametro : Form
    {
        public string parametro { get; set; }
        public FPacienteParametro()
        {
            InitializeComponent();
        }

        private void FPacienteParametro_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Paciente' Puede moverla o quitarla según sea necesario.
            //this.PacienteTableAdapter.FillBy2(this.Database1DataSet.Paciente,parametro);

            this.reportViewer1.RefreshReport();
        }
    }
}
