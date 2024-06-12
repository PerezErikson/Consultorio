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
    public partial class RAnalisisParametros : Form
    {
        public string parametro { get; set; }
        public RAnalisisParametros()
        {
            InitializeComponent();
        }

        private void RAnalisisParametros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Analisis' Puede moverla o quitarla según sea necesario.
            //this.AnalisisTableAdapter.FillBy(this.Database1DataSet.Analisis,parametro);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
