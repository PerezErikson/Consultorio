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
    public partial class FReporteConsultaFecha : Form
    {
        public FReporteConsultaFecha()
        {
            InitializeComponent();
        }

        private void FReporteConsultaFecha_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Consulta' Puede moverla o quitarla según sea necesario.
            //this.ConsultaTableAdapter.Fill(this.Database1DataSet.Consulta);//

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime valor;
            valor = Convert.ToDateTime(dateTimePicker1.Value);

            // TODO: esta línea de código carga datos en la tabla 'Database1DataSet.Consulta' Puede moverla o quitarla según sea necesario.
            //this.ConsultaTableAdapter.FillBy(this.Database1DataSet.Consulta,valor);//

            this.reportViewer1.RefreshReport();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
