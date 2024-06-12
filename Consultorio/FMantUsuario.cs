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
    public partial class FMantUsuario : Form
    {
        public string valorparametro = "", mensaje = "";
        public FMantUsuario()
        {
            InitializeComponent();
        }
        public void LimpiaObjetos()
        {
            tbIdUsuario.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            tbNombreusuario.Clear();
            tbContrasena.Clear();

        }
        private void HabilitarBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitarControles(true); //Llamada al método para habilitar los objetos
                Bnuevo.Enabled = false;
                Bguardar.Enabled = true;
                Beditar.Enabled = false;
                Btbuscar.Enabled = false;
                Bcancelar.Enabled = true;
            }
            else
            {
                HabilitarControles(false); //Llamada al método para inhabilitar los objetos
                Bnuevo.Enabled = true;
                Bguardar.Enabled = false;
                Beditar.Enabled = false;
                Btbuscar.Enabled = true;
                Bcancelar.Enabled = false;
            }
        }
        public void HabilitarControles(bool valor)
        {
            tbIdUsuario.ReadOnly = true;
            tbNombre.Enabled = valor;
            tbApellido.Enabled = valor;
            tbApellido.Enabled = valor;
            tbNombreusuario.Enabled = valor;
            tbContrasena.Enabled = valor;

        }
        private void Bnuevo_Click(object sender, EventArgs e)
        {
            LimpiaObjetos(); //LLama al método LimpiaObjetos para prepararlos para la nueva entrada
            Program.nuevo = true; //Se especifica que se agregará un nuevo registro
            Program.modificar = false;
            HabilitarBotones(); //Se habilitan solo aquellos botones que sean necesarios
            tbNombre.Focus(); //Coloca el cursor en el TextBox indicado
        }

        private void Bguardar_Click(object sender, EventArgs e)
        {
            //Validamos los datos requeridos entes de Insertar o Actualizar
            if (tbNombre.Text == String.Empty) //Si el textbox está vacío mostrar un error y ubicar
            { // el cursor en dicho textbox
                MessageBox.Show("Debe indicar el nombre");
                tbNombre.Focus();
            }
            else
            if (tbApellido.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el apellido");
                tbApellido.Focus();
            }
            else
            {
                if (Program.nuevo)
                {

                    mensaje = CNusuario.Insertar(Program.vidUsuario, tbNombre.Text, tbApellido.Text, tbNombreusuario.Text, tbContrasena.Text);
                }
                else //de lo contrario se Modificarán los datos del registro correspondiente
                {
                    //Se llama al método Insertar de la clase CNSuplidor de la capa de negocio
                    //pasándole como parámetros los valores leídos en los controles del formulario.
                    // como: textbox, combobox, DateTimePicker, etc.
                    //Los parámetros se pasan en el orden en que se reciben y con el tipo de dato esperado
                    mensaje = CNusuario.Actualizar(Program.vidUsuario, tbNombre.Text, tbApellido.Text, tbNombreusuario.Text, tbContrasena.Text);
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
            
            
        }

        private void Beditar_Click(object sender, EventArgs e)
        {
            //Si no ha seleccionado un Suplidor no se puede modificar
            if (!tbIdUsuario.Equals(""))
            {
                Program.modificar = true; //el formulaario se prepara para modificar datos
                HabilitarBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Usuario para poder Modificar sus datos!");
            }
        }

        private void Btbuscar_Click(object sender, EventArgs e)
        {
            FBuscarUsuario fBuscarUsuario = new FBuscarUsuario();
            fBuscarUsuario.ShowDialog();
            if (Program.modificar) //Si se está en modo de edición
            {
                RecuperaDatos(); //Llamo al método para recuperar el registro seleccionado
                Beditar_Click(sender, e); //Llamo el método del botón Editar
            }
            else //Si no estamos en modo de edición no permite la acción.
            {
                LimpiaObjetos(); //Llama al método LimpiaObjetos
                Btbuscar.Focus();
            }

        }
        public void RecuperaDatos()
        {
            string vparametro = Program.vidUsuario.ToString();
            CNusuario cNUsuario = new CNusuario();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = cNUsuario.ObtenerUsuario(vparametro); //Llenamos el DataTable
            foreach (DataRow row in dt.Rows)
            {
                tbIdUsuario.Text = row["ID_usuario"].ToString();
                tbNombre.Text = row["Nombre"].ToString();
                tbApellido.Text = row["Apellido"].ToString();
                tbNombreusuario.Text = row["NUsuario"].ToString();
                tbContrasena.Text = row["Contrasena"].ToString();
                
            }
        } //Fin del método RecuperarDatos

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitarBotones(); //Habilita los objetos y botones correspondientes
            LimpiaObjetos(); //Llama al método LimpiaObjetos
        }
    }
}
