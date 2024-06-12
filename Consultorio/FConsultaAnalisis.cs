using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Consultorio
{
    public partial class FConsultaAnalisis : Form
    {
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";

        CNanalisis cNanalisis = new CNanalisis();

        public FConsultaAnalisis()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text != String.Empty) //Si se introdujo un dato en el textbox
            {
                vtieneparametro = 1; //se indica que se trabajará con parámetros
                                     //Se coloca el signo % para que el dato indicado se busque en cualquier parte del campo
                valorparametro = "%" + tbBuscar.Text.Trim() + "%";
                //valorparametro = tbBuscar.Text.Trim();
            }
            else //si el textbox está vacío
            {
                vtieneparametro = 0; //se indica que no se trabajará con parámetros
                valorparametro = ""; //Se vuelve vacío la variable del parámetro.
            }
            MostrarDatos(); //Se llama al método MostrarDatos
        }

        private void FConsultaAnalisis_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Analisis' Puede moverla o quitarla según sea necesario.
            //this.analisisTableAdapter.Fill(this.database1DataSet.Analisis);

        }

        private void tbBuscar_Enter(object sender, EventArgs e)
        {
            valorparametro = tbBuscar.Text.Trim();
            if (cNanalisis.ObtenerAnalisis(valorparametro) != null)
            {
                DGVdatos.DataSource = cNanalisis.ObtenerAnalisis(valorparametro);
                //Se ejecuta el método para mostrar los datos
                DGVdatos.Columns[0].Width = 80; //IDSuplidor
                DGVdatos.Columns[1].Width = 200; //Suplidor
            }
            else
                MessageBox.Show("No se retornó ningún valor!");

            DGVdatos.Refresh(); //Se refresca el DataGridView

        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBuscar_DoubleClick(object sender, EventArgs e)
        {
            valorparametro = tbBuscar.Text.Trim();
            if (cNanalisis.ObtenerAnalisis(valorparametro) != null)
            {
                DGVdatos.DataSource = cNanalisis.ObtenerAnalisis(valorparametro);
                //Se ejecuta el método para mostrar los datos
                DGVdatos.Columns[0].Width = 80; //IDSuplidor
                DGVdatos.Columns[1].Width = 200; //Suplidor
            }
            else
                MessageBox.Show("No se retornó ningún valor!");

            DGVdatos.Refresh(); //Se refresca el DataGridView
        }

        private void tbBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            valorparametro = tbBuscar.Text.Trim();
            if (cNanalisis.ObtenerAnalisis(valorparametro) != null)
            {
                DGVdatos.DataSource = cNanalisis.ObtenerAnalisis(valorparametro);
                //Se ejecuta el método para mostrar los datos
                DGVdatos.Columns[0].Width = 80; //IDSuplidor
                DGVdatos.Columns[1].Width = 200; //Suplidor
            }
            else
                MessageBox.Show("No se retornó ningún valor!");

            DGVdatos.Refresh(); //Se refresca el DataGridView
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RAnalisisParametros rAnalisisParametros = new RAnalisisParametros();
            rAnalisisParametros.parametro = tbBuscar.Text;
            rAnalisisParametros.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DGVdatos.Rows.Count > 1) //Si no estamos al inicio del DataGridView, vamos al inicio
            {
                indice = 0;
                DGVdatos.CurrentCell = DGVdatos.Rows[indice].Cells[DGVdatos.CurrentCell.ColumnIndex];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVdatos.RowCount - 1) //Si no estamos al final del DataGridView
            {
                indice = DGVdatos.Rows.Count - 1; //vamos a la última fila del DataGridView
                DGVdatos.CurrentCell =
               DGVdatos.Rows[indice].Cells[DGVdatos.CurrentCell.ColumnIndex];
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (indice > 0) //Si no estamos al inicio del DataGridView, retrocedemos 1 fila
            {
                indice = indice - 1;
                DGVdatos.CurrentCell =
                DGVdatos.Rows[indice].Cells[DGVdatos.CurrentCell.ColumnIndex];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVdatos.RowCount - 1) //Si no estamos al final del DataGridView, avanzamos 1 fila
            {
                indice++;
                DGVdatos.CurrentCell =
               DGVdatos.Rows[indice].Cells[DGVdatos.CurrentCell.ColumnIndex];
            }
        }

        private void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            if (cNanalisis.ObtenerAnalisis(valorparametro) != null)
            {
                DGVdatos.DataSource = cNanalisis.ObtenerAnalisis(valorparametro);
                //Se ejecuta el método para mostrar los datos
                DGVdatos.Columns[0].Width = 80; //IDSuplidor
                DGVdatos.Columns[1].Width = 200; //Suplidor
            }
            else
                MessageBox.Show("No se retornó ningún valor!");

            DGVdatos.Refresh(); //Se refresca el DataGridView

        } //Fin del método mostrar
    }
}
