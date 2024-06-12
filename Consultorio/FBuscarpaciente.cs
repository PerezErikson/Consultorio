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
using CapaDatos;


namespace Consultorio
{
    public partial class FBuscarpaciente : Form
    {
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";

        CNpaciente cNpaciente = new CNpaciente();

        public FBuscarpaciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FBuscarpaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Paciente' Puede moverla o quitarla según sea necesario.
            //this.pacienteTableAdapter.Fill(this.database1DataSet.Paciente);//
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidPaciente = 0; //variable global que tomará el valor seleccionado
            MostrarDatos(); //Llamo al Método que llena el DataGrid
            tbBuscar.Focus(); //El TextBox Buscar recibe el cursor
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FBuscarpaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir del formulario! \n Seguro que desea hacerlo?",
 "Mensaje Consultorio",
 MessageBoxButtons.YesNo,
 MessageBoxIcon.Question,
 MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DGVdatos.CurrentRow != null) //Si el DataGridView no está vacío
            {
                //variable global a toda la solución se hace verdadera y se le asigna a la variable global vidSuplidor
                // el valor de la clave correspondiente
                Program.modificar = true;
                Program.vidPaciente = Convert.ToInt32(DGVdatos.CurrentRow.Cells[0].Value);
            }
            Close();

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

        private void DGVdatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //si se pulsa en el encabezado, RowIndex será menor que cero y no se hará nada
            if (!(e.RowIndex > -1))
            {
                return;
            }
            button2_Click(sender, e); //Se ejecuta el método del botón Aceptar
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (indice > 0) //Si no estamos al inicio del DataGridView, retrocedemos 1 fila
            {
                indice = indice - 1;
                DGVdatos.CurrentCell =
                DGVdatos.Rows[indice].Cells[DGVdatos.CurrentCell.ColumnIndex];
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
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
            if (cNpaciente.ObtenerPaciente(valorparametro) != null)
            {
                DGVdatos.DataSource = cNpaciente.ObtenerPaciente(valorparametro); 
                //Se ejecuta elmétodo para mostrar los datos
            DGVdatos.Columns[0].Width = 80; //IDPaciente
                DGVdatos.Columns[1].Width = 200; //Nombre
                DGVdatos.Columns[2].Width = 225; //Apellido
                DGVdatos.Columns[3].Width = 100; //TipoDocumento
                DGVdatos.Columns[4].Width = 125; //NoDocumento
                DGVdatos.Columns[5].Width = 125; //sexo
                DGVdatos.Columns[6].Width = 150; //FechaNacimiento
                DGVdatos.Columns[7].Width = 100; //Telefono
              
            }
            else
                MessageBox.Show("No se retornó ningún valor!");

            DGVdatos.Refresh(); //Se refresca el DataGridView

        } //Fin del método mostrar

    }
}
