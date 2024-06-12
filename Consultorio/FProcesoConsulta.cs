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
    public partial class FProcesoConsulta : Form
    {
        public string valorparametro = "", mensaje = "";
        public FProcesoConsulta()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void LimpiaObjetos()
        {
            tbidconsulta.Clear();
           

            tbcodpaciente.Clear();
            tbnombre.Clear();
            tbapellido.Clear();
            tbtelefono.Clear();


            tbmotivo.Clear();
            tbenfermedades.Clear();
            tbsintomas.Clear();
            tbantecedentes.Clear();
            tbdiagnostico.Clear();
        }
        public void HabilitarControles(bool valor)
        {
            tbidconsulta.ReadOnly = true;
            tbnombre.Enabled = false;
            tbapellido.Enabled = false;
            tbtelefono.Enabled = false;
            tbfecha.Enabled = valor;
            tbmotivo.Enabled = valor;
            tbenfermedades.Enabled = valor;
            tbsintomas.Enabled = valor;
            tbdiagnostico.Enabled = valor;
            tbantecedentes.Enabled = valor;



        }
        private void HabilitarBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitarControles(true); //Llamada al método para habilitar los objetos
                bnuevo.Enabled = false;
                bguardar.Enabled = true;
                tbfecha.Enabled = false;
                
                bbuscarpaciente.Enabled = true;
                bcancelar.Enabled = true;
            }
            else
            {
                HabilitarControles(false); //Llamada al método para inhabilitar los objetos
                bnuevo.Enabled = true;
                bguardar.Enabled = false;
               
                bbuscarpaciente.Enabled = true;
                bcancelar.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiaObjetos(); //LLama al método LimpiaObjetos para prepararlos para la nueva entrada
            Program.nuevo = true; //Se especifica que se agregará un nuevo registro
            Program.modificar = false;
            HabilitarBotones(); //Se habilitan solo aquellos botones que sean necesarios
            tbcodpaciente.Focus(); //Coloca el cursor en el TextBox indicado
            tbfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void FProcesoConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Esto le hara salir de la aplicaci!\n seguro que desea hacerlo?", "Mensaje de Consultorio", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            //Validamos los datos requeridos entes de Insertar o Actualizar
           
            if (tbcodpaciente.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar los Datos del Paciente!");
                tbcodpaciente.Focus();
            }
            else
            
            
            if (tbmotivo.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el Motivo de la consulta!");
                tbmotivo.Focus();
            }
            else
            if (tbenfermedades.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar las enfermedades del paciente!");
                tbenfermedades.Focus();
            }
            else
            if (tbfecha.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la Fecha!");
                tbfecha.Focus();
            }
            else
            if (tbdiagnostico.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar El diagnostico del paciente!");
                tbdiagnostico.Focus();
            }
            else
            if (tbantecedentes.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar los antecedentes del paciente!");
                tbantecedentes.Focus();
            }

            else {
                if (Program.nuevo)
                {

                    mensaje = CNconsulta.Insertar(Program.vidConsulta, Convert.ToInt32(tbcodpaciente.Text), tbmotivo.Text,
                     tbenfermedades.Text, tbsintomas.Text, tbantecedentes.Text, tbfecha.Text, tbdiagnostico.Text);
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

        private void bcancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitarBotones(); //Habilita los objetos y botones correspondientes
            LimpiaObjetos(); //Llama al método LimpiaObjetos
        }

        private void bbuscarpaciente_Click(object sender, EventArgs e)
        {
            FBuscarpaciente fBuscarpaciente = new FBuscarpaciente();
            fBuscarpaciente.ShowDialog();
            if (Program.modificar) //Si se está en modo de edición
            {
                RecuperaDatos(); //Llamo al método para recuperar el registro seleccionado
                beditar_Click(sender, e); //Llamo el método del botón Editar
            }
            else //Si no estamos en modo de edición no permite la acción.
            {
                LimpiaObjetos(); //Llama al método LimpiaObjetos
                bbuscarpaciente.Focus();
            }
        }

        private void FProcesoConsulta_Load(object sender, EventArgs e)
        {

        }

        private void beditar_Click(object sender, EventArgs e)
        {

        }

        private void tbfecha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                tbcodpaciente.Text = row["ID_Paciente"].ToString();
                tbnombre.Text = row["Nombre"].ToString();
                tbapellido.Text = row["Apellido"].ToString();
                tbtelefono.Text = row["Telefono"].ToString();
            }
        } //Fin del método RecuperarDatos
    }
}
