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
    public partial class FreporteMedicamento : Form
    {
        public FreporteMedicamento()
        {
            InitializeComponent();
        }

        private void FreporteMedicamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Medicamentos' Puede moverla o quitarla según sea necesario.
            //this.MedicamentosTableAdapter.Fill(this.Database1DataSet.Medicamentos);//

            this.reportViewer1.RefreshReport();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
