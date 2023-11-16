using HistoriasClinicas.DataSetPCHCTableAdapters;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.util;
using System.Windows.Forms;

namespace HistoriasClinicas
{
    public partial class FormularioGenerarInforme : Form
    {
        private bool usuarioCerro;
        private DataSetPCHC dsPCHC;
        private PacientesTableAdapter tableAdapterP;
        private CitasTableAdapter tableAdapterC;
        private HistoriasClinicasTableAdapter tableAdapterHC;
        private int idP;
        private int dniP;

        public bool UsuarioCerro { get => usuarioCerro; set => usuarioCerro = value; }
        public DataSetPCHC DsPCHC { get => dsPCHC; set => dsPCHC = value; }
        public PacientesTableAdapter TableAdapterP { get => tableAdapterP; set => tableAdapterP = value; }
        public CitasTableAdapter TableAdapterC { get => tableAdapterC; set => tableAdapterC = value; }
        public HistoriasClinicasTableAdapter TableAdapterHC { get => tableAdapterHC; set => tableAdapterHC = value; }
        public int IdP { get => idP; set => idP = value; }
        public int DniP { get => dniP; set => dniP = value; }

        public FormularioGenerarInforme()
        {
            InitializeComponent();
            UsuarioCerro = false;
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            IdP = 0;
            DniP = 0;

            if (int.TryParse(textBoxID.Text, out idP) && int.TryParse(textBoxDNI.Text, out dniP))
            {
                if (ExistePaciente(idP, dniP)) 
                {
                    GenerarPDFHistoriaClinica();
                    MessageBox.Show("PDF generado con exito.", "PDF de historia clínica generado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                MessageBox.Show("No hubo coincidencias con su búsqueda. Revise los datos por favor, e intente nuevamente.", "Datos ingresados invalidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimpiarTextBoxs();
        }


        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            LimpiarTextBoxs();
            UsuarioCerro = true;
        }

        private bool ExistePaciente(int id, int dni)
        {
           DataSetPCHC.PacientesRow dr = (DataSetPCHC.PacientesRow) DsPCHC.Pacientes.FindById(id);

            return dr != null && dr.DNI == dni;
        }

        private void GenerarPDFHistoriaClinica()
        {
            SaveFileDialog guardar = new SaveFileDialog();
            DataSetPCHC.PacientesRow dr = (DataSetPCHC.PacientesRow)DsPCHC.Pacientes.FindById(IdP);
            string textoHtml = Properties.Resources.plantillaPDF3.ToString();
            string fila = "";
            
            guardar.FileName = $"PacienteID_{IdP}.pdf";

            textoHtml = textoHtml.Replace("@idpaciente", IdP.ToString());
            textoHtml = textoHtml.Replace("@nombre",dr.Nombre);
            textoHtml = textoHtml.Replace("@apellido", dr.Apellido);
            textoHtml = textoHtml.Replace("@dni", dr.DNI.ToString());
            textoHtml = textoHtml.Replace("@fecha", DateTime.Now.ToString());

            foreach (DataSetPCHC.HistoriasClinicasRow filas in DsPCHC.HistoriasClinicas.Rows) 
            {
                if(filas.IdPaciente == dr.Id) 
                {
                    fila += "<tr>";
                    fila += $"<td> {filas.FechaConsulta} </td>";
                    fila += $"<td> {filas.MotivoConsulta} </td>";
                    fila += $"<td> {filas.DetallesVisita} </td>";
                    fila += $"<td> {filas.EstudiosRealizados} </td>";
                    fila += $"<td> {filas.Medicacion} </td>";
                    fila += "</tr>";
                }
            }

            textoHtml = textoHtml.Replace("@Fila", fila);

            if(guardar.ShowDialog() == DialogResult.OK) 
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create)) 
                {
                    Document pdfDoc = new Document(PageSize.A4,10,10,10,10);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    pdfDoc.Add(new Phrase(""));

                    using(StringReader sr = new StringReader(textoHtml)) 
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }

        private void FormularioGenerarInforme_FormClosing(object sender, FormClosingEventArgs e)
        {
            LimpiarTextBoxs();
            UsuarioCerro = true;
        }


        private void LimpiarTextBoxs()
        {
            textBoxID.Text = "";
            textBoxDNI.Text = "";
        }

        private void FormularioGenerarInforme_Load(object sender, EventArgs e)
        {
            DsPCHC = new DataSetPCHC();

            TableAdapterP = new PacientesTableAdapter();
            TableAdapterC = new CitasTableAdapter();
            TableAdapterHC = new HistoriasClinicasTableAdapter();

            tableAdapterP.Fill(DsPCHC.Pacientes);
            tableAdapterC.Fill(DsPCHC.Citas);
            tableAdapterHC.Fill(DsPCHC.HistoriasClinicas);
        }
    }
}
