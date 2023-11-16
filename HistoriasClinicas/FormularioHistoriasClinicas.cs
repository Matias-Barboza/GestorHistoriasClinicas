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
    public partial class FormularioHistoriasClinicas : Form
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
        public CitasTableAdapter TableAdapterC { get => tableAdapterC; set => tableAdapterC = value; }
        public HistoriasClinicasTableAdapter TableAdapterHC { get => tableAdapterHC; set => tableAdapterHC = value; }
        public int FilaSeleccionada { get => filaSeleccionada; set => filaSeleccionada = value; }

        public FormularioHistoriasClinicas()
        {
            InitializeComponent();
            this.UsuarioCerro = false;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewHC.SelectedRows.Count > 0)
            {
                int filaSelecc = dataGridViewHC.CurrentRow.Index;


                DialogResult respuesta = MessageBox.Show($"¿Está seguro de eliminar la fila {(filaSelecc + 1)}?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    DataSetPCHC.HistoriasClinicasRow dr = (DataSetPCHC.HistoriasClinicasRow)DsPCHC.HistoriasClinicas.Rows[filaSelecc];

                    dr.Delete();
                    tableAdapterHC.Update(DsPCHC.HistoriasClinicas);
                    dataGridViewHC.Update();
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
            if (dataGridViewHC.SelectedRows.Count > 0)
            {
                FilaSeleccionada = dataGridViewHC.CurrentRow.Index;


                DialogResult respuesta = MessageBox.Show($"¿Está seguro de traer para una modificación la fila {(FilaSeleccionada + 1)}?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    DataSetPCHC.HistoriasClinicasRow dr = (DataSetPCHC.HistoriasClinicasRow)DsPCHC.HistoriasClinicas.Rows[FilaSeleccionada];
                    DataSetPCHC.PacientesRow drP;

                    textBoxIDpaciente.Text = dr.IdPaciente.ToString();
                    dateTimePickerF.Value = dr.FechaConsulta;
                    textBoxHora.Text = dr.FechaConsulta.Hour.ToString();
                    textBoxMotivo.Text = dr.MotivoConsulta;
                    textBoxDetalles.Text = dr.DetallesVisita;
                    textBoxEstudios.Text = dr.EstudiosRealizados;
                    textBoxMedicacion.Text = dr.Medicacion;

                    drP = DsPCHC.Pacientes.FindById(int.Parse(textBoxIDpaciente.Text));

                    textBoxNombreP.Text = drP.Nombre;
                    textBoxApellidoP.Text = drP.Apellido;
                    textBoxDNIP.Text = drP.DNI.ToString();

                    PrepararPanelOperacion("Modificar el historial");
                }
            }
            else 
            {
                MessageBox.Show("No seleccionó ninguna fila", "Selección invalida",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (ExisteCita())
            {
                DataSetPCHC.CitasRow dr = DsPCHC.Citas.FindById(int.Parse(textBoxIDCita.Text));
                DataSetPCHC.PacientesRow drP;

                textBoxIDpaciente.Text = dr.IdPaciente.ToString();
                dateTimePickerF.Value = dr.Fecha.Date;
                textBoxHora.Text = dr.Fecha.Hour.ToString();
                textBoxMotivo.Text = dr.Motivo;

                drP = DsPCHC.Pacientes.FindById(int.Parse(textBoxIDpaciente.Text));

                textBoxNombreP.Text = drP.Nombre;
                textBoxApellidoP.Text = drP.Apellido;
                textBoxDNIP.Text = drP.DNI.ToString();

                PrepararPanelOperacion("Agregar al historial");
            }
            else
            {
                LimpiarControles();

                MessageBox.Show("Ingresó un ID de cita invalido, reviselo por favor e intente nuevamente.", "Ingreso invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                panelOperacion.Enabled = false;
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            LimpiarControles();
            panelOperacion.Enabled = false;
        }
        private void buttonOperacion_Click(object sender, EventArgs e)
        {
            DataSetPCHC.HistoriasClinicasRow dr;

            if (DatosValidos() && buttonOperacion.Text == "Agregar al historial")
            {
                dr = DsPCHC.HistoriasClinicas.NewHistoriasClinicasRow();

                dr.FechaConsulta = ConfigurarFechaYHora();
                dr.MotivoConsulta = textBoxMotivo.Text;
                dr.DetallesVisita = textBoxDetalles.Text;
                dr.EstudiosRealizados = textBoxEstudios.Text;
                dr.Medicacion = textBoxMedicacion.Text;
                dr.IdPaciente = int.Parse(textBoxIDpaciente.Text);

                DialogResult respuesta = PreguntarConfirmacion();

                if (respuesta == DialogResult.Yes)
                {
                    DsPCHC.HistoriasClinicas.AddHistoriasClinicasRow(dr);
                    tableAdapterHC.Update(DsPCHC.HistoriasClinicas);
                    dataGridViewHC.Update();
                }

            }
            else if (DatosValidos() && buttonOperacion.Text == "Modificar el historial")
            {
                dr = (DataSetPCHC.HistoriasClinicasRow)DsPCHC.HistoriasClinicas.Rows[FilaSeleccionada];

                dr.FechaConsulta = ConfigurarFechaYHora();
                dr.MotivoConsulta = textBoxMotivo.Text;
                dr.DetallesVisita = textBoxDetalles.Text;
                dr.EstudiosRealizados = textBoxEstudios.Text;
                dr.Medicacion = textBoxMedicacion.Text;
                dr.IdPaciente = int.Parse(textBoxIDpaciente.Text);

                DialogResult respuesta = PreguntarConfirmacion();

                if (respuesta == DialogResult.Yes)
                {
                    tableAdapterHC.Update(DsPCHC.HistoriasClinicas);
                    dataGridViewHC.Update();
                }
            }
            else 
            {
                MessageBox.Show("Algún dato es invalido, Reviselos por favor.", "Datos ingresados invalidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            LimpiarControles();
            panelOperacion.Enabled = false;
        }

        private bool ExisteCita()
        {
            return int.TryParse(textBoxIDCita.Text, out int idCita) && DsPCHC.Citas.FindById(idCita) != null;
        }

        private bool DatosValidos()
        {
            return textBoxDetalles.Text != "" && textBoxEstudios.Text != "" && textBoxMedicacion.Text != "";
        }

        private DateTime ConfigurarFechaYHora()
        {
            return new DateTime(dateTimePickerF.Value.Year, dateTimePickerF.Value.Month, dateTimePickerF.Value.Day,
                int.Parse(textBoxHora.Text.ToString()), 0, 0);
        }

        private DialogResult PreguntarConfirmacion()
        {
            return MessageBox.Show("¿Está seguro de seguir adelante con la operación?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void PrepararPanelOperacion(string operacion)
        {
            if (operacion == "Agregar al historial") buttonOperacion.Text = operacion;
            else buttonOperacion.Text = operacion;
            
            panelOperacion.Enabled = true;
        }

        private void LimpiarControles()
        {
            textBoxIDCita.Text = "";
            textBoxIDpaciente.Text = "";
            dateTimePickerF.Value = DateTime.Now;
            textBoxHora.Text = "";
            textBoxMotivo.Text = "";
            textBoxDetalles.Text = "";
            textBoxEstudios.Text = "";
            textBoxMedicacion.Text = "";
            buttonOperacion.Text = "";

            textBoxNombreP.Text = "";
            textBoxApellidoP.Text = "";
            textBoxDNIP.Text = "";
        }
        private void FormularioHistoriasClinicas_FormClosing(object sender, FormClosingEventArgs e)
        {
            panelOperacion.Enabled = false;
            UsuarioCerro = true;
        }

        private void FormularioHistoriasClinicas_Load(object sender, EventArgs e)
        {
            TableAdapterP = new PacientesTableAdapter();
            TableAdapterC = new CitasTableAdapter();
            TableAdapterHC = new HistoriasClinicasTableAdapter();

            DsPCHC = new DataSetPCHC();

            TableAdapterP.Fill(DsPCHC.Pacientes);
            TableAdapterC.Fill(DsPCHC.Citas);
            TableAdapterHC.Fill(DsPCHC.HistoriasClinicas);

            dataGridViewHC.DataSource = DsPCHC.HistoriasClinicas;
        }

    }
}
