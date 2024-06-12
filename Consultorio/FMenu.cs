using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace Consultorio
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultasYReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void procesosClinicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

        }

        private void FMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir de la aplicaci!\n seguro que desea hacerlo?", "Mensaje de Consultorio", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPaciente fpaciente = new FPaciente();
                fpaciente.ShowDialog();
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmantmedicamentos fmedicamentos = new Fmantmedicamentos();
            fmedicamentos.ShowDialog();

        }

        private void analisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmantanalisis fmantanalisis = new Fmantanalisis();
            fmantanalisis.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FProcesoConsulta fprocesoconsulta = new FProcesoConsulta();
            fprocesoconsulta.ShowDialog();
        }
        
        private void datosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportePacientes reportePaciente = new ReportePacientes();
            reportePaciente.ShowDialog();
        }

        private void generalMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FreporteMedicamento freporteMedicamento = new FreporteMedicamento();
            freporteMedicamento.ShowDialog();
        }

        private void pacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FConsultaPaciente fConsultaPaciente = new FConsultaPaciente();
            fConsultaPaciente.ShowDialog();
        }

        private void analisisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FConsultaAnalisis fConsultaAnalisis = new FConsultaAnalisis();
            fConsultaAnalisis.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMantUsuario fMantUsuario = new FMantUsuario();
            fMantUsuario.ShowDialog();
        }

        private void medicamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaMedicamentos consultaMedicamentos = new ConsultaMedicamentos();
            consultaMedicamentos.ShowDialog();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FConsultarConsulta fConsultarConsulta = new FConsultarConsulta();
            fConsultarConsulta.ShowDialog();
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WINWORD.EXE");
        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe");
        }

        private void sexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPacienteReporteParametros fPacienteReporteParametros = new FPacienteReporteParametros();
            fPacienteReporteParametros.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acercade acercade = new Acercade();
            acercade.ShowDialog();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();

        }

        private void salirSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FReporteConsultaFecha fReporteConsultaFecha = new FReporteConsultaFecha();
            fReporteConsultaFecha.ShowDialog();
        }
    }
}
