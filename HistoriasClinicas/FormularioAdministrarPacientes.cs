using HistoriasClinicas.DataSetPCHCTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoriasClinicas
{
    public partial class FormularioAdministrarPacientes : Form
    {
        private bool usuarioCerro;
        private DataSetPCHC dsPCHC;
        private PacientesTableAdapter tableAdapterP;
        private CitasTableAdapter tableAdapterC;
        private HistoriasClinicasTableAdapter tableAdapterHC;
        private int filaSeleccionada;
        public bool UsuarioCerro { get => usuarioCerro; set => usuarioCerro = value; }
        public DataSetPCHC DsPCHC { get => dsPCHC; set => dsPCHC = value; }
        public PacientesTableAdapter TableAdapterP { get => tableAdapterP; set => tableAdapterP = value; }
        public int FilaSeleccionada { get => filaSeleccionada; set => filaSeleccionada = value; }
        public CitasTableAdapter TableAdapterC { get => tableAdapterC; set => tableAdapterC = value; }
        public HistoriasClinicasTableAdapter TableAdapterHC { get => tableAdapterHC; set => tableAdapterHC = value; }

        public FormularioAdministrarPacientes()
        {
            InitializeComponent();
            InicializarComboBoxGenero();
            this.UsuarioCerro = false;
        }

        private void InicializarComboBoxGenero()
        {
            comboBoxGenero.Items.AddRange(new String[] { "Masculino", "Femenino", "Indefinido", "Prefiero no responder" });
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (!panelOperacion.Enabled)
            {
                panelOperacion.Enabled = true;
                buttonOperacion.Text = "Agregar paciente";
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (panelOperacion.Enabled)
            {
                LimpiarTextBoxs();
                buttonOperacion.Text = "";
                panelOperacion.Enabled = false;
            }

            if (dataGridViewPacientes.SelectedRows.Count > 0)
            {
                int filaSelecc = dataGridViewPacientes.CurrentRow.Index;

                DialogResult respuesta = MessageBox.Show($"¿Está seguro de eliminar la fila {(filaSelecc + 1)}? \n" +
                    $"Tenga en cuenta que esto además elimina la información asociada (citas programadas, historial clínico).",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    DataSetPCHC.PacientesRow dr = (DataSetPCHC.PacientesRow)DsPCHC.Pacientes.Rows[filaSelecc];
                    
                    EliminarCitasAsociadas(dr.Id);

                    EliminarHistoriasAsociadas(dr.Id);
                    
                    dr.Delete();

                    TableAdapterP.Update(DsPCHC.Pacientes);
                    dataGridViewPacientes.Update();
                }
            }
            else
            {
                MessageBox.Show("No seleccionó ninguna fila", "Selección invalida",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (panelOperacion.Enabled) 
            {
                LimpiarTextBoxs();
                buttonOperacion.Text = "";
                panelOperacion.Enabled = false;
            }

            if (dataGridViewPacientes.SelectedRows.Count > 0)
            {
                FilaSeleccionada = dataGridViewPacientes.CurrentRow.Index;

                DialogResult respuesta = MessageBox.Show($"¿Está seguro de traer para una modificación la fila {(FilaSeleccionada + 1)}?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    DataSetPCHC.PacientesRow dr = (DataSetPCHC.PacientesRow)DsPCHC.Pacientes.Rows[FilaSeleccionada];

                    textBoxNombre.Text = dr.Nombre;
                    textBoxApellido.Text = dr.Apellido;
                    textBoxDNI.Text = dr.DNI.ToString();
                    comboBoxGenero.Text = dr.Genero;
                    textBoxDireccion.Text = dr.Direccion;
                    textBoxTelefono.Text = dr.Telefono;

                    panelOperacion.Enabled = true;
                    buttonOperacion.Text = "Modificar paciente";
                }
            }
            else
            {
                MessageBox.Show("No seleccionó ninguna fila", "Selección invalida",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonOperacion_Click(object sender, EventArgs e)
        {
            if (DatosValidos() && buttonOperacion.Text == "Agregar paciente")
            {
                DataSetPCHC.PacientesRow dr = dsPCHC.Pacientes.NewPacientesRow();

                dr[1] = textBoxNombre.Text;
                dr[2] = textBoxApellido.Text;
                dr[3] = textBoxDNI.Text;
                dr[4] = comboBoxGenero.SelectedItem.ToString();
                dr[5] = textBoxDireccion.Text;
                dr[6] = textBoxTelefono.Text;

                DsPCHC.Pacientes.AddPacientesRow(dr);
                TableAdapterP.Update(DsPCHC.Pacientes);
                dataGridViewPacientes.Update();
            }
            else if (DatosValidos() && buttonOperacion.Text == "Modificar paciente")
            {
                DataSetPCHC.PacientesRow dr = (DataSetPCHC.PacientesRow)DsPCHC.Pacientes.Rows[FilaSeleccionada];

                dr[1] = textBoxNombre.Text;
                dr[2] = textBoxApellido.Text;
                dr[3] = textBoxDNI.Text;
                dr[4] = comboBoxGenero.SelectedItem.ToString();
                dr[5] = textBoxDireccion.Text;
                dr[6] = textBoxTelefono.Text;

                tableAdapterP.Update(DsPCHC.Pacientes);
                dataGridViewPacientes.Update();
            }
            else
            {
                MessageBox.Show("Algún dato es invalido, Reviselos por favor.", "Datos ingresados invalidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (buttonOperacion.Text == "Agregar paciente")
            {
                DialogResult respuesta = MessageBox.Show("¿Desea continuar agregando pacientes?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    LimpiarTextBoxs();
                    return;
                }
            }

            LimpiarTextBoxs();
            buttonOperacion.Text = "";
            panelOperacion.Enabled = false;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            LimpiarTextBoxs();
            buttonOperacion.Text = "";
            panelOperacion.Enabled = false;
            UsuarioCerro = true;
        }

        private bool DatosValidos()
        {
            long dni = 0, telefono = 0;

            bool nombreValido = textBoxNombre.Text != "";
            bool apellidoValido = textBoxApellido.Text != "";
            bool dniValido = long.TryParse(textBoxDNI.Text, out dni);
            bool generoValido = comboBoxGenero.SelectedIndex != -1;
            bool telefonoValido = long.TryParse(textBoxTelefono.Text, out telefono);

            return nombreValido && apellidoValido && dniValido && generoValido && telefonoValido;
        }

        private void EliminarCitasAsociadas(int id)
        {
            foreach (DataSetPCHC.CitasRow drC in DsPCHC.Citas.Rows)
            {
                if (drC.IdPaciente == id)
                {
                    drC.Delete();
                }
            }

            TableAdapterC.Update(DsPCHC.Citas);
        }

        private void EliminarHistoriasAsociadas(int id) 
        {
            foreach (DataSetPCHC.HistoriasClinicasRow drHC in DsPCHC.HistoriasClinicas.Rows)
            {
                if (drHC.IdPaciente == id)
                {
                    drHC.Delete();
                }
            }

            TableAdapterHC.Update(DsPCHC.HistoriasClinicas);
        }

        private void LimpiarTextBoxs()
        {
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxDNI.Text = "";
            comboBoxGenero.SelectedIndex = -1;
            textBoxDireccion.Text = "";
            textBoxTelefono.Text = "";
        }

        private void FormularioAdministrarPacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            LimpiarTextBoxs();
            panelOperacion.Enabled = false;
            UsuarioCerro = true;
        }

        private void FormularioAdministrarPacientes_Load(object sender, EventArgs e)
        {
            DsPCHC = new DataSetPCHC();

            TableAdapterP = new PacientesTableAdapter();
            TableAdapterC = new CitasTableAdapter();
            tableAdapterHC = new HistoriasClinicasTableAdapter();

            TableAdapterP.Fill(DsPCHC.Pacientes);
            TableAdapterC.Fill(DsPCHC.Citas);
            TableAdapterHC.Fill(DsPCHC.HistoriasClinicas);

            dataGridViewPacientes.DataSource = DsPCHC.Pacientes;
        }

    }
}
