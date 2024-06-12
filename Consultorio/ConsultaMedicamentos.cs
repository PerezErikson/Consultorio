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
    public partial class ConsultaMedicamentos : Form
    {
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";

        CNmedicamento cNmedicamento = new CNmedicamento();
        public ConsultaMedicamentos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaMedicamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Medicamentos' Puede moverla o quitarla según sea necesario.
            //this.medicamentosTableAdapter.Fill(this.database1DataSet.Medicamentos);
           

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RMedicamentoParametro rMedicamento = new RMedicamentoParametro();
            rMedicamento.parametro = tbBuscar.Text;
            rMedicamento.ShowDialog();
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
            if (cNmedicamento.ObtenerMedicamento(valorparametro) != null)
            {
                DGVdatos.DataSource = cNmedicamento.ObtenerMedicamento(valorparametro);
                //Se ejecuta elmétodo para mostrar los datos
                DGVdatos.Columns[0].Width = 80; //IDMedicamento
                DGVdatos.Columns[1].Width = 200; //Nombre
                DGVdatos.Columns[2].Width = 225; //Componenetes
                DGVdatos.Columns[3].Width = 100; //Laboratorio
                DGVdatos.Columns[4].Width = 125; //Dosis
                DGVdatos.Columns[5].Width = 125; //Contraindicaciones


            }
            else
                MessageBox.Show("No se retornó ningún valor!");

            DGVdatos.Refresh(); //Se refresca el DataGridView

        } //Fin del método mostrar
    }
}
