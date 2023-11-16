using HistoriasClinicas.DataSetPCHCTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoriasClinicas
{
    public partial class FormularioAdministrarCitas : Form
    {
        private bool usuarioCerro;
        private DataSetPCHC dsPCHC;
        private PacientesTableAdapter tableAdapterP;
        private CitasTableAdapter tableAdapterC;
        private int filaSeleccionada;
        private int idPaciente;

        public bool UsuarioCerro { get => usuarioCerro; set => usuarioCerro = value; }
        public DataSetPCHC DsPCHC { get => dsPCHC; set => dsPCHC = value; }
        public PacientesTableAdapter TableAdapterP { get => tableAdapterP; set => tableAdapterP = value; }
        public CitasTableAdapter TableAdapterC { get => tableAdapterC; set => tableAdapterC = value; }
        public int FilaSeleccionada { get => filaSeleccionada; set => filaSeleccionada = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }

        public FormularioAdministrarCitas()
        {
            InitializeComponent();
            InicializarComboBoxHoras();
            this.UsuarioCerro = false;
        }

        private void InicializarComboBoxHoras()
        {
            comboBoxHoras.Items.AddRange(new String[] { "7", "8", "9", "10", "11",
                                                        "17", "18", "19", "20"});
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (!panelOperacion.Enabled)
            {
                buttonOperacion.Text = "Agregar cita";
                panelOperacion.Enabled = true;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(panelOperacion.Enabled) 
            {
                panelOperacion.Enabled = false;
                LimpiarTextBoxs();
                buttonOperacion.Text = "";
            }

            if (dataGridViewCitas.SelectedRows.Count > 0)
            {
                int filaSelecc = dataGridViewCitas.CurrentRow.Index;

                DialogResult respuesta = MessageBox.Show($"¿Está seguro de eliminar la fila {(filaSelecc + 1)}?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    DataSetPCHC.CitasRow dr = (DataSetPCHC.CitasRow)DsPCHC.Citas.Rows[filaSelecc];
                    dr.Delete();
                    TableAdapterC.Update(DsPCHC.Citas);
                    dataGridViewCitas.Update();
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
                panelOperacion.Enabled = false;
                LimpiarTextBoxs();
                buttonOperacion.Text = "";
            }

            if (dataGridViewCitas.SelectedRows.Count > 0)
            {
                FilaSeleccionada = dataGridViewCitas.CurrentRow.Index;

                DialogResult respuesta = MessageBox.Show($"¿Está seguro de traer para una modificación la fila {(FilaSeleccionada + 1)}?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    DataSetPCHC.CitasRow dr = (DataSetPCHC.CitasRow)DsPCHC.Citas.Rows[FilaSeleccionada];

                    dateTimePickerCitas.Value = dr.Fecha.Date;
                    comboBoxHoras.Text = dr.Fecha.Hour.ToString();
                    textBoxMotivo.Text = dr.Motivo;
                    textBoxIDPaciente.Text = dr.IdPaciente.ToString();
                    IdPaciente = dr.IdPaciente;

                    panelOperacion.Enabled = true;
                    buttonOperacion.Text = "Modificar cita";
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
            DataSetPCHC.CitasRow dr;
            DateTime fechaYHora;

            if (buttonOperacion.Text == "Agregar cita" && int.TryParse(textBoxIDPaciente.Text, out idPaciente)) IdPaciente = int.Parse(textBoxIDPaciente.Text);
            else if (buttonOperacion.Text == "Modificar cita" && int.TryParse(textBoxIDPaciente.Text, out idPaciente)) IdPaciente = int.Parse(textBoxIDPaciente.Text);

            if (DatosValidos(IdPaciente) && buttonOperacion.Text == "Agregar cita")
            {
                dr = DsPCHC.Citas.NewCitasRow();

                fechaYHora = ConfigurarFechaYHora();

                dr.Fecha = fechaYHora;
                dr.Motivo = textBoxMotivo.Text;
                dr.IdPaciente = Int32.Parse(textBoxIDPaciente.Text);

                DsPCHC.Citas.AddCitasRow(dr);
                tableAdapterC.Update(DsPCHC.Citas);
                dataGridViewCitas.Update();
            }
            else if (DatosValidos(IdPaciente) && buttonOperacion.Text == "Modificar cita")
            {
                dr = (DataSetPCHC.CitasRow)DsPCHC.Citas.Rows[FilaSeleccionada];

                fechaYHora = ConfigurarFechaYHora();

                dr.Fecha = fechaYHora;
                dr.Motivo = textBoxMotivo.Text;
                dr.IdPaciente = Int32.Parse(textBoxIDPaciente.Text);

                tableAdapterC.Update(DsPCHC.Citas);
                dataGridViewCitas.Update();
            }
            else
            {
                MessageBox.Show("Algún dato es invalido, reviselos por favor.", "Datos ingresados invalidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (buttonOperacion.Text == "Agregar cita")
            {
                DialogResult respuesta = MessageBox.Show("¿Desea continuar agregando citas?", "Confirmación",
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

        private bool DatosValidos(int idP)
        {
            DataRow dr = DsPCHC.Pacientes.FindById(idP);

            bool fechaValida = dateTimePickerCitas.Value > DateTime.Now;
            bool horaValida = comboBoxHoras.SelectedIndex != -1;
            bool motivoValido = textBoxMotivo.Text != "";
            bool idValido = Int32.TryParse(textBoxIDPaciente.Text, out idP);
            bool idPacienteValido = dr != null;

            return fechaValida && horaValida && motivoValido && idValido && idPacienteValido;
        }

        private DateTime ConfigurarFechaYHora()
        {
            return new DateTime(dateTimePickerCitas.Value.Year, dateTimePickerCitas.Value.Month, dateTimePickerCitas.Value.Day,
                int.Parse(comboBoxHoras.SelectedItem.ToString()), 0, 0);
        }

        private void LimpiarTextBoxs()
        {
            textBoxIDPaciente.Text = "";
            textBoxNombreP.Text = "";
            textBoxApellidoP.Text = "";
            dateTimePickerCitas.Value = DateTime.Now;
            comboBoxHoras.SelectedIndex = -1;
            textBoxMotivo.Text = "";
        }

        private void FormularioAdministrarCitas_FormClosing(object sender, FormClosingEventArgs e)
        {
            LimpiarTextBoxs();
            buttonOperacion.Text = "";
            panelOperacion.Enabled = false;
            UsuarioCerro = true;
        }


        private void FormularioAdministrarCitas_Load(object sender, EventArgs e)
        {
            //tableadapter de pacientes y de citas para poder establecer relaciones entre estos
            TableAdapterP = new PacientesTableAdapter();
            TableAdapterC = new CitasTableAdapter();

            DsPCHC = new DataSetPCHC();

            TableAdapterP.Fill(DsPCHC.Pacientes);
            TableAdapterC.Fill(DsPCHC.Citas);

            dataGridViewCitas.DataSource = DsPCHC.Citas;

            MessageBox.Show("Cuando teclee el numero de ID del paciente, el sistema trae automaticamente " +
                            "los datos asociados. Si no los vé es porque el ID no coincide con ningún paciente " +
                            "registrado.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxIDPaciente_TextChanged(object sender, EventArgs e)
        {
            int idP;

            if (int.TryParse(textBoxIDPaciente.Text, out idP)) 
            {
                DataSetPCHC.PacientesRow dr = (DataSetPCHC.PacientesRow) DsPCHC.Pacientes.FindById(idP);

                if (dr != null) 
                {
                    textBoxNombreP.Text = dr.Nombre;
                    textBoxApellidoP.Text = dr.Apellido;
                    return;
                }
            }
        }
    }
}
