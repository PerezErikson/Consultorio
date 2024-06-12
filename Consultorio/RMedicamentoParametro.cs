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
    public partial class RMedicamentoParametro : Form
    {
        public string parametro { get; set; }
        public RMedicamentoParametro()
        {
            InitializeComponent();
        }

        private void RMedicamentoParametro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Medicamentos' Puede moverla o quitarla según sea necesario.
            //this.MedicamentosTableAdapter.FillBy(this.Database1DataSet.Medicamentos,parametro);

            this.reportViewer1.RefreshReport();
        }
    }
}
