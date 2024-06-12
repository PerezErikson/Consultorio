using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//para poder utilizar las instrucciones de SQL
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
//Para acceder a la capa de negocio
using CapaNegocio;


namespace Consultorio
{
    public partial class FPaciente : Form
    {
        public string valorparametro = "", mensaje = "";


        public FPaciente()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validamos los datos requeridos entes de Insertar o Actualizar
            if (tbNombre.Text == String.Empty) //Si el textbox está vacío mostrar un error y ubicar
            { // el cursor en dicho textbox
                MessageBox.Show("Debe indicar el nombre del Paciente!");
                tbNombre.Focus();
            }
            else
            if (tbApellido.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el Apellido del Paciente!");
                tbApellido.Focus();
            }
            else
            if (cbTipoDocumento.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el Tipo de Documento del Paciente!");
                cbTipoDocumento.Focus();
            }
            else
            if (tbDocumento.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el Numero de Documento del Paciente!");
                tbDocumento.Focus();
            }
            else
            if (cbSexo.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el Sexo del Paciente!");
                cbSexo.Focus();
            }
            else
            if (cbTipoSangre.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el Tipo de Sangre del Paciente!");
                cbTipoSangre.Focus();
            }
            else
            if (tbFechaNacimiento.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la Fecha de Nacimiento del Paciente!");
                tbFechaNacimiento.Focus();
            }
            else
            if (tbTelefono.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el Telefono del Paciente!");
                tbTelefono.Focus();
            }
            else

            if (Program.nuevo)
            {

                mensaje = CNpaciente.Insertar(Program.vidPaciente, tbNombre.Text, tbApellido.Text,
                 cbTipoDocumento.Text, tbDocumento.Text, cbSexo.Text, cbTipoSangre.Text, tbFechaNacimiento.Text, tbTelefono.Text);
            }
            else //de lo contrario se Modificarán los datos del registro correspondiente
            {
                //Se llama al método Insertar de la clase CNSuplidor de la capa de negocio
                //pasándole como parámetros los valores leídos en los controles del formulario.
                // como: textbox, combobox, DateTimePicker, etc.
                //Los parámetros se pasan en el orden en que se reciben y con el tipo de dato esperado
                mensaje = CNpaciente.Actualizar(Program.vidPaciente, tbNombre.Text, tbApellido.Text,
                 cbTipoDocumento.Text, tbDocumento.Text, cbSexo.Text, cbTipoSangre.Text, tbFechaNacimiento.Text, tbTelefono.Text);
            }
            //Se muestra el mensaje devuelto por la capa de negocio respecto al resultado de la operación
            MessageBox.Show(mensaje, "Mensage de Consultorio", MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            //Se prepara todo para la próxima operación
            Program.nuevo = false;
            Program.modificar = false;
            HabilitarBotones(); //Habilita los objetos y botones correspondientes
            LimpiaObjetos(); //Llama al método LimpiaObjetos




        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FBuscarpaciente fBuscarpaciente = new FBuscarpaciente();
            fBuscarpaciente.ShowDialog();
            if (Program.modificar) //Si se está en modo de edición
            {
                RecuperaDatos(); //Llamo al método para recuperar el registro seleccionado
                BEditar_Click(sender, e); //Llamo el método del botón Editar
            }
            else //Si no estamos en modo de edición no permite la acción.
            {
                LimpiaObjetos(); //Llama al método LimpiaObjetos
                Bbuscar.Focus();
            }

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void FPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir de la aplicaci!\n seguro que desea hacerlo?", "Mensaje de Consultorio", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void FPaciente_Load(object sender, EventArgs e)
        {



        }

        public void LimpiaObjetos()
        {
            tbIdpaciente.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            cbTipoDocumento.SelectedItem = 0;
            tbDocumento.Clear();
            cbSexo.SelectedItem = 0;
            cbTipoSangre.SelectedItem = 0;
            tbFechaNacimiento.Clear();
            tbTelefono.Clear();
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            LimpiaObjetos(); //LLama al método LimpiaObjetos para prepararlos para la nueva entrada
            Program.nuevo = true; //Se especifica que se agregará un nuevo registro
            Program.modificar = false;
            HabilitarBotones(); //Se habilitan solo aquellos botones que sean necesarios
            tbNombre.Focus(); //Coloca el cursor en el TextBox indicado

        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitarBotones(); //Habilita los objetos y botones correspondientes
            LimpiaObjetos(); //Llama al método LimpiaObjetos
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            //Si no ha seleccionado un Paciente no se puede modificar
            if (!tbIdpaciente.Equals(""))
            {
                Program.modificar = true; //el formulaario se prepara para modificar datos
                HabilitarBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Paciente para poder Modificar sus datos!");
            }

        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTipoSangre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbFechaNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIdpaciemte_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void HabilitarControles(bool valor)
        {
            tbIdpaciente.ReadOnly = true;
            tbNombre.Enabled = valor;
            tbApellido.Enabled = valor;
            cbTipoDocumento.Enabled = valor;
            tbDocumento.Enabled = valor;
            cbSexo.Enabled = valor;
            cbTipoSangre.Enabled = valor;
            tbFechaNacimiento.Enabled = valor;
            tbTelefono.Enabled = valor;



        }

        private void FPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }

        }

        private void HabilitarBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitarControles(true); //Llamada al método para habilitar los objetos
                BNuevo.Enabled = false;
                BGuardar.Enabled = true;
                BEditar.Enabled = false;
                Bbuscar.Enabled = false;
                BCancelar.Enabled = true;
            }
            else
            {
                HabilitarControles(false); //Llamada al método para inhabilitar los objetos
                BNuevo.Enabled = true;
                BGuardar.Enabled = false;
                BEditar.Enabled = false;
                Bbuscar.Enabled = true;
                BCancelar.Enabled = false;
            }




        }
        public void RecuperaDatos()
        {
            string vparametro = Program.vidPaciente.ToString();
            CNpaciente cNpaciente = new CNpaciente();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = cNpaciente.ObtenerPaciente(vparametro); //Llenamos el DataTable
                                                         //Recorremos cada fila del DataTable asignando a los controles de edición los valores de
                                                         //los campos correspondientes. 

            foreach (DataRow row in dt.Rows)
            {
                tbIdpaciente.Text = row["ID_Paciente"].ToString();
                tbNombre.Text = row["Nombre"].ToString();
                tbApellido.Text = row["Apellido"].ToString();
                cbTipoDocumento.Text = row["TipoDocumento"].ToString();
                tbDocumento.Text = row["NoDocumento"].ToString();
                cbSexo.Text = row["Sexo"].ToString();
                cbTipoSangre.Text = row["TipoSangre"].ToString();
                tbFechaNacimiento.Text = Convert.ToDateTime( row["FechaNacimiento"]).ToString("yyyy-MM-dd");
                tbTelefono.Text = row["Telefono"].ToString();
            }
        } //Fin del método RecuperarDatos
    }



}



