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
    public partial class FReporteAnalisis : Form
    {
        public FReporteAnalisis()
        {
            InitializeComponent();
        }

        private void FReporteAnalisis_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Analisis' Puede moverla o quitarla según sea necesario.
            this.AnalisisTableAdapter.Fill(this.Database1DataSet.Analisis);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
