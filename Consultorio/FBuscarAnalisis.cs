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
    public partial class FBuscarAnalisis : Form
    {
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";

        CNanalisis cNanalisis = new CNanalisis();

        public FBuscarAnalisis()
        {
            InitializeComponent();
        }

        private void FBuscarAnalisis_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir del formulario! \n Seguro que desea hacerlo?",
 "Mensaje de Consultorio",
 MessageBoxButtons.YesNo,
 MessageBoxIcon.Question,
 MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;

        }

        private void FBuscarAnalisis_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Analisis' Puede moverla o quitarla según sea necesario.
            this.analisisTableAdapter.Fill(this.database1DataSet.Analisis);

        }

        private void DGVdatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVdatos.CurrentRow != null) //Si el DataGridView no está vacío
                indice = DGVdatos.CurrentRow.Index; //El valor de índice será la fila actual
        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {
            Program.modificar = false; //variable global a toda la solución
            Close(); //Se cierra el formulario
        }

        private void Baceptar_Click(object sender, EventArgs e)
        {
            if (DGVdatos.CurrentRow != null) //Si el DataGridView no está vacío
            {
                //variable global a toda la solución se hace verdadera y se le asigna a la variable global vidSuplidor
                // el valor de la clave correspondiente
                Program.modificar = true;
                Program.vidAnalisis = Convert.ToInt32(DGVdatos.CurrentRow.Cells[0].Value);
            }
            Close();

        }

        private void DGVdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVdatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //si se pulsa en el encabezado, RowIndex será menor que cero y no se hará nada
            if (!(e.RowIndex > -1))
            {
                return;
            }
            Baceptar_Click(sender, e); //Se ejecuta el método del botón Aceptar
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DGVdatos.Rows.Count > 1) //Si no estamos al inicio del DataGridView, vamos al inicio
            {
                indice = 0;
                DGVdatos.CurrentCell = DGVdatos.Rows[indice].Cells[DGVdatos.CurrentCell.ColumnIndex];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVdatos.RowCount - 1) //Si no estamos al final del DataGridView, avanzamos 1 fila
            {
                indice++;
                DGVdatos.CurrentCell =
               DGVdatos.Rows[indice].Cells[DGVdatos.CurrentCell.ColumnIndex];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (indice > 0) //Si no estamos al inicio del DataGridView, retrocedemos 1 fila
            {
                indice = indice - 1;
                DGVdatos.CurrentCell =
                DGVdatos.Rows[indice].Cells[DGVdatos.CurrentCell.ColumnIndex];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVdatos.RowCount - 1) //Si no estamos al final del DataGridView
            {
                indice = DGVdatos.Rows.Count - 1; //vamos a la última fila del DataGridView
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
