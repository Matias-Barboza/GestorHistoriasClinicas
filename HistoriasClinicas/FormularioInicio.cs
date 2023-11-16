using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoriasClinicas
{
    public partial class FormularioInicio : Form
    {
        private FormularioAdministrarPacientes administrarPacientes;
        private FormularioAdministrarCitas administrarCitas;
        private FormularioHistoriasClinicas historiasClinicas;
        private FormularioGenerarInforme generarInforme;

        public FormularioInicio()
        {
            InitializeComponent();
            this.administrarPacientes = new FormularioAdministrarPacientes();
            this.administrarCitas = new FormularioAdministrarCitas();
            this.historiasClinicas = new FormularioHistoriasClinicas();
            this.generarInforme = new FormularioGenerarInforme();
        }

        private void buttonAdministrarPacientes_Click(object sender, EventArgs e)
        {
            this.Hide();

            administrarPacientes.ShowDialog();

            if (administrarPacientes.UsuarioCerro) this.Show();
        }

        private void buttonAdministrarCitas_Click(object sender, EventArgs e)
        {
            this.Hide();

            //if (administrarCitas.DtCitas == null) administrarCitas.DtCitas = this.dtCitas;

            administrarCitas.ShowDialog();

            if (administrarCitas.UsuarioCerro) this.Show();
        }

        private void buttonAdministrarHC_Click(object sender, EventArgs e)
        {
            this.Hide();

            //if (historiasClinicas.DtHistoriasClinicas == null) historiasClinicas.DtHistoriasClinicas = this.dtHistoriasClinicas;

            historiasClinicas.ShowDialog();

            if (historiasClinicas.UsuarioCerro) this.Show();
        }

        private void buttonGenerarInforme_Click(object sender, EventArgs e)
        {
            this.Hide();

            generarInforme.ShowDialog();

            if (generarInforme.UsuarioCerro) this.Show();
        }

    }
}
