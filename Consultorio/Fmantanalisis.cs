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
    public partial class Fmantanalisis : Form
    {
        public string valorparametro = "", mensaje = "";
        public Fmantanalisis()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Fmantanalisis_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir de la aplicaci!\n seguro que desea hacerlo?", "Mensaje de Consultorio", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
        public void LimpiaObjetos()
        {
            tbIdanalisis.Clear();
            tbNombre.Clear();
            tbDescripcion.Clear();

        }

        public void HabilitarControles(bool valor)
        {
            tbIdanalisis.ReadOnly = true;
            tbNombre.Enabled = valor;
            tbDescripcion.Enabled = valor;

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BNuevo_Click(object sender, EventArgs e)
        {
            LimpiaObjetos(); //LLama al método LimpiaObjetos para prepararlos para la nueva entrada
            Program.nuevo = true; //Se especifica que se agregará un nuevo registro
            Program.modificar = false;
            HabilitarBotones(); //Se habilitan solo aquellos botones que sean necesarios
            tbNombre.Focus(); //Coloca el cursor en el TextBox indicado
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            //Validamos los datos requeridos entes de Insertar o Actualizar
            if (tbNombre.Text == String.Empty) //Si el textbox está vacío mostrar un error y ubicar
            { // el cursor en dicho textbox
                MessageBox.Show("Debe indicar el nombre del Analisis!");
                tbNombre.Focus();
            }
            else
            if (tbDescripcion.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la descipcion del Analisis!");
                tbDescripcion.Focus();
            }
            if (Program.nuevo)
            {

                mensaje = CNanalisis.Insertar(Program.vidAnalisis, tbNombre.Text, tbDescripcion.Text);
            }
            else //de lo contrario se Modificarán los datos del registro correspondiente
            {
                //Se llama al método Insertar de la clase CNSuplidor de la capa de negocio
                //pasándole como parámetros los valores leídos en los controles del formulario.
                // como: textbox, combobox, DateTimePicker, etc.
                //Los parámetros se pasan en el orden en que se reciben y con el tipo de dato esperado
                mensaje = CNanalisis.Actualizar(Program.vidAnalisis, tbNombre.Text, tbDescripcion.Text);
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

        private void BEditar_Click(object sender, EventArgs e)
        {
            //Si no ha seleccionado un Suplidor no se puede modificar
            if (!tbIdanalisis.Equals(""))
            {
                Program.modificar = true; //el formulaario se prepara para modificar datos
                HabilitarBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Analisis!");
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitarBotones(); //Habilita los objetos y botones correspondientes
            LimpiaObjetos(); //Llama al método LimpiaObjetos
        }

        private void Bbuscar_Click(object sender, EventArgs e)
        {
            FBuscarAnalisis fBuscarAnalisis = new FBuscarAnalisis();
            fBuscarAnalisis.ShowDialog();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fmantanalisis_Load(object sender, EventArgs e)
        {

        }

        public void RecuperaDatos()
        {
            string vparametro = Program.vidAnalisis.ToString();
            CNanalisis cNanalisis = new CNanalisis();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = cNanalisis.ObtenerAnalisis(vparametro); //Llenamos el DataTable
            foreach (DataRow row in dt.Rows)
            {
                tbIdanalisis.Text = row["ID_Analisis"].ToString();
                tbNombre.Text = row["Nombre"].ToString();
                tbDescripcion.Text = row["Descripcion"].ToString();
                
            }
        } //Fin del método RecuperarDatos
    }
}

