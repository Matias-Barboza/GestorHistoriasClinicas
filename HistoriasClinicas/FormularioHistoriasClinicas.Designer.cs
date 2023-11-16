namespace HistoriasClinicas
{
    partial class FormularioHistoriasClinicas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelOperacion = new Panel();
            labelIDpaciente = new Label();
            textBoxIDpaciente = new TextBox();
            labelHs = new Label();
            textBoxHora = new TextBox();
            labelHoras = new Label();
            dateTimePickerF = new DateTimePicker();
            buttonOperacion = new Button();
            textBoxDetalles = new TextBox();
            labelDetallesVisita = new Label();
            textBoxMedicacion = new TextBox();
            textBoxEstudios = new TextBox();
            labelMedicacion = new Label();
            labelEstudios = new Label();
            labelFechaYHora = new Label();
            textBoxMotivo = new TextBox();
            labelMotivoConsulta = new Label();
            buttonBuscar = new Button();
            textBoxIDCita = new TextBox();
            labelIDCita = new Label();
            panelVisualizacion = new Panel();
            textBoxNombreP = new TextBox();
            labelNombreP = new Label();
            labelListado = new Label();
            buttonVolver = new Button();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            dataGridViewHC = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            historiasClinicasBindingSource1 = new BindingSource(components);
            panelBuscar = new Panel();
            textBoxApellidoP = new TextBox();
            labelApellidoP = new Label();
            textBoxDNIP = new TextBox();
            labelDNIP = new Label();
            panelOperacion.SuspendLayout();
            panelVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)historiasClinicasBindingSource1).BeginInit();
            panelBuscar.SuspendLayout();
            SuspendLayout();
            // 
            // panelOperacion
            // 
            panelOperacion.Controls.Add(labelIDpaciente);
            panelOperacion.Controls.Add(textBoxIDpaciente);
            panelOperacion.Controls.Add(labelHs);
            panelOperacion.Controls.Add(textBoxHora);
            panelOperacion.Controls.Add(labelHoras);
            panelOperacion.Controls.Add(dateTimePickerF);
            panelOperacion.Controls.Add(buttonOperacion);
            panelOperacion.Controls.Add(textBoxDetalles);
            panelOperacion.Controls.Add(labelDetallesVisita);
            panelOperacion.Controls.Add(textBoxMedicacion);
            panelOperacion.Controls.Add(textBoxEstudios);
            panelOperacion.Controls.Add(labelMedicacion);
            panelOperacion.Controls.Add(labelEstudios);
            panelOperacion.Controls.Add(labelFechaYHora);
            panelOperacion.Controls.Add(textBoxMotivo);
            panelOperacion.Controls.Add(labelMotivoConsulta);
            panelOperacion.Enabled = false;
            panelOperacion.Location = new Point(0, 108);
            panelOperacion.Name = "panelOperacion";
            panelOperacion.Size = new Size(403, 581);
            panelOperacion.TabIndex = 0;
            // 
            // labelIDpaciente
            // 
            labelIDpaciente.AutoSize = true;
            labelIDpaciente.Location = new Point(12, 13);
            labelIDpaciente.Name = "labelIDpaciente";
            labelIDpaciente.Size = new Size(210, 25);
            labelIDpaciente.TabIndex = 9;
            labelIDpaciente.Text = "Número de paciente (ID):";
            // 
            // textBoxIDpaciente
            // 
            textBoxIDpaciente.Enabled = false;
            textBoxIDpaciente.Location = new Point(12, 54);
            textBoxIDpaciente.Name = "textBoxIDpaciente";
            textBoxIDpaciente.Size = new Size(171, 31);
            textBoxIDpaciente.TabIndex = 10;
            // 
            // labelHs
            // 
            labelHs.AutoSize = true;
            labelHs.Location = new Point(252, 145);
            labelHs.Name = "labelHs";
            labelHs.Size = new Size(33, 25);
            labelHs.TabIndex = 8;
            labelHs.Text = "Hs";
            // 
            // textBoxHora
            // 
            textBoxHora.Enabled = false;
            textBoxHora.Location = new Point(171, 140);
            textBoxHora.Name = "textBoxHora";
            textBoxHora.Size = new Size(75, 31);
            textBoxHora.TabIndex = 7;
            // 
            // labelHoras
            // 
            labelHoras.AutoSize = true;
            labelHoras.Location = new Point(171, 97);
            labelHoras.Name = "labelHoras";
            labelHoras.Size = new Size(55, 25);
            labelHoras.TabIndex = 4;
            labelHoras.Text = "Hora:";
            // 
            // dateTimePickerF
            // 
            dateTimePickerF.Enabled = false;
            dateTimePickerF.Format = DateTimePickerFormat.Short;
            dateTimePickerF.Location = new Point(12, 140);
            dateTimePickerF.Name = "dateTimePickerF";
            dateTimePickerF.Size = new Size(152, 31);
            dateTimePickerF.TabIndex = 3;
            // 
            // buttonOperacion
            // 
            buttonOperacion.Location = new Point(73, 539);
            buttonOperacion.Name = "buttonOperacion";
            buttonOperacion.Size = new Size(212, 34);
            buttonOperacion.TabIndex = 2;
            buttonOperacion.UseVisualStyleBackColor = true;
            buttonOperacion.Click += buttonOperacion_Click;
            // 
            // textBoxDetalles
            // 
            textBoxDetalles.Location = new Point(12, 312);
            textBoxDetalles.Name = "textBoxDetalles";
            textBoxDetalles.Size = new Size(349, 31);
            textBoxDetalles.TabIndex = 1;
            // 
            // labelDetallesVisita
            // 
            labelDetallesVisita.AutoSize = true;
            labelDetallesVisita.Location = new Point(12, 271);
            labelDetallesVisita.Name = "labelDetallesVisita";
            labelDetallesVisita.Size = new Size(148, 25);
            labelDetallesVisita.TabIndex = 0;
            labelDetallesVisita.Text = "Detalles de visita:";
            // 
            // textBoxMedicacion
            // 
            textBoxMedicacion.Location = new Point(12, 492);
            textBoxMedicacion.Name = "textBoxMedicacion";
            textBoxMedicacion.Size = new Size(349, 31);
            textBoxMedicacion.TabIndex = 1;
            // 
            // textBoxEstudios
            // 
            textBoxEstudios.Location = new Point(12, 404);
            textBoxEstudios.Name = "textBoxEstudios";
            textBoxEstudios.Size = new Size(349, 31);
            textBoxEstudios.TabIndex = 1;
            // 
            // labelMedicacion
            // 
            labelMedicacion.AutoSize = true;
            labelMedicacion.Location = new Point(12, 451);
            labelMedicacion.Name = "labelMedicacion";
            labelMedicacion.Size = new Size(106, 25);
            labelMedicacion.TabIndex = 0;
            labelMedicacion.Text = "Medicación:";
            // 
            // labelEstudios
            // 
            labelEstudios.AutoSize = true;
            labelEstudios.Location = new Point(12, 363);
            labelEstudios.Name = "labelEstudios";
            labelEstudios.Size = new Size(167, 25);
            labelEstudios.TabIndex = 0;
            labelEstudios.Text = "Estudios realizados:";
            // 
            // labelFechaYHora
            // 
            labelFechaYHora.AutoSize = true;
            labelFechaYHora.Location = new Point(12, 97);
            labelFechaYHora.Name = "labelFechaYHora";
            labelFechaYHora.Size = new Size(116, 25);
            labelFechaYHora.TabIndex = 0;
            labelFechaYHora.Text = "Fecha y hora:";
            // 
            // textBoxMotivo
            // 
            textBoxMotivo.Enabled = false;
            textBoxMotivo.Location = new Point(12, 224);
            textBoxMotivo.Name = "textBoxMotivo";
            textBoxMotivo.Size = new Size(349, 31);
            textBoxMotivo.TabIndex = 1;
            // 
            // labelMotivoConsulta
            // 
            labelMotivoConsulta.AutoSize = true;
            labelMotivoConsulta.Location = new Point(12, 185);
            labelMotivoConsulta.Name = "labelMotivoConsulta";
            labelMotivoConsulta.Size = new Size(169, 25);
            labelMotivoConsulta.TabIndex = 0;
            labelMotivoConsulta.Text = "Motivo de consulta:";
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(233, 53);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(128, 34);
            buttonBuscar.TabIndex = 6;
            buttonBuscar.Text = "Buscar cita";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxIDCita
            // 
            textBoxIDCita.Location = new Point(12, 55);
            textBoxIDCita.Name = "textBoxIDCita";
            textBoxIDCita.Size = new Size(171, 31);
            textBoxIDCita.TabIndex = 1;
            // 
            // labelIDCita
            // 
            labelIDCita.AutoSize = true;
            labelIDCita.Location = new Point(12, 14);
            labelIDCita.Name = "labelIDCita";
            labelIDCita.Size = new Size(171, 25);
            labelIDCita.TabIndex = 0;
            labelIDCita.Text = "Número de cita (ID):";
            // 
            // panelVisualizacion
            // 
            panelVisualizacion.Controls.Add(textBoxDNIP);
            panelVisualizacion.Controls.Add(labelDNIP);
            panelVisualizacion.Controls.Add(textBoxApellidoP);
            panelVisualizacion.Controls.Add(labelApellidoP);
            panelVisualizacion.Controls.Add(textBoxNombreP);
            panelVisualizacion.Controls.Add(labelNombreP);
            panelVisualizacion.Controls.Add(labelListado);
            panelVisualizacion.Controls.Add(buttonVolver);
            panelVisualizacion.Controls.Add(buttonModificar);
            panelVisualizacion.Controls.Add(buttonEliminar);
            panelVisualizacion.Controls.Add(dataGridViewHC);
            panelVisualizacion.Location = new Point(409, 0);
            panelVisualizacion.Name = "panelVisualizacion";
            panelVisualizacion.Size = new Size(1323, 689);
            panelVisualizacion.TabIndex = 1;
            // 
            // textBoxNombreP
            // 
            textBoxNombreP.Enabled = false;
            textBoxNombreP.Location = new Point(24, 56);
            textBoxNombreP.Name = "textBoxNombreP";
            textBoxNombreP.Size = new Size(178, 31);
            textBoxNombreP.TabIndex = 7;
            // 
            // labelNombreP
            // 
            labelNombreP.AutoSize = true;
            labelNombreP.Location = new Point(24, 14);
            labelNombreP.Name = "labelNombreP";
            labelNombreP.Size = new Size(182, 25);
            labelNombreP.TabIndex = 7;
            labelNombreP.Text = "Nombre del paciente:";
            // 
            // labelListado
            // 
            labelListado.AutoSize = true;
            labelListado.Location = new Point(24, 121);
            labelListado.Name = "labelListado";
            labelListado.Size = new Size(229, 25);
            labelListado.TabIndex = 6;
            labelListado.Text = "Listado de historias clínicas:";
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(763, 647);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(142, 34);
            buttonVolver.TabIndex = 6;
            buttonVolver.Text = "Volver al menú";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(624, 647);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(112, 34);
            buttonModificar.TabIndex = 5;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(477, 647);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(112, 34);
            buttonEliminar.TabIndex = 4;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // dataGridViewHC
            // 
            dataGridViewHC.AllowUserToAddRows = false;
            dataGridViewHC.AllowUserToDeleteRows = false;
            dataGridViewHC.AutoGenerateColumns = false;
            dataGridViewHC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHC.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dataGridViewHC.DataSource = historiasClinicasBindingSource1;
            dataGridViewHC.Location = new Point(24, 162);
            dataGridViewHC.Name = "dataGridViewHC";
            dataGridViewHC.ReadOnly = true;
            dataGridViewHC.RowHeadersWidth = 62;
            dataGridViewHC.RowTemplate.Height = 33;
            dataGridViewHC.Size = new Size(1274, 469);
            dataGridViewHC.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "N° historia clínica";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "FechaConsulta";
            dataGridViewTextBoxColumn2.HeaderText = "Fecha de consulta";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "MotivoConsulta";
            dataGridViewTextBoxColumn3.HeaderText = "Motivo de consulta";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 350;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "DetallesVisita";
            dataGridViewTextBoxColumn4.HeaderText = "Detalles de visita";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 350;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "EstudiosRealizados";
            dataGridViewTextBoxColumn5.HeaderText = "Estudios realizados";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 350;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Medicacion";
            dataGridViewTextBoxColumn6.HeaderText = "Medicación";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 350;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "IdPaciente";
            dataGridViewTextBoxColumn7.HeaderText = "N° paciente";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // historiasClinicasBindingSource1
            // 
            historiasClinicasBindingSource1.DataMember = "HistoriasClinicas";
            historiasClinicasBindingSource1.DataSource = typeof(DataSetPCHC);
            // 
            // panelBuscar
            // 
            panelBuscar.Controls.Add(labelIDCita);
            panelBuscar.Controls.Add(textBoxIDCita);
            panelBuscar.Controls.Add(buttonBuscar);
            panelBuscar.Location = new Point(0, 0);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(403, 102);
            panelBuscar.TabIndex = 2;
            // 
            // textBoxApellidoP
            // 
            textBoxApellidoP.Enabled = false;
            textBoxApellidoP.Location = new Point(234, 56);
            textBoxApellidoP.Name = "textBoxApellidoP";
            textBoxApellidoP.Size = new Size(178, 31);
            textBoxApellidoP.TabIndex = 8;
            // 
            // labelApellidoP
            // 
            labelApellidoP.AutoSize = true;
            labelApellidoP.Location = new Point(234, 14);
            labelApellidoP.Name = "labelApellidoP";
            labelApellidoP.Size = new Size(182, 25);
            labelApellidoP.TabIndex = 9;
            labelApellidoP.Text = "Apellido del paciente:";
            // 
            // textBoxDNIP
            // 
            textBoxDNIP.Enabled = false;
            textBoxDNIP.Location = new Point(454, 56);
            textBoxDNIP.Name = "textBoxDNIP";
            textBoxDNIP.Size = new Size(178, 31);
            textBoxDNIP.TabIndex = 10;
            // 
            // labelDNIP
            // 
            labelDNIP.AutoSize = true;
            labelDNIP.Location = new Point(454, 14);
            labelDNIP.Name = "labelDNIP";
            labelDNIP.Size = new Size(147, 25);
            labelDNIP.TabIndex = 11;
            labelDNIP.Text = "DNI del paciente:";
            // 
            // FormularioHistoriasClinicas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1732, 688);
            Controls.Add(panelBuscar);
            Controls.Add(panelVisualizacion);
            Controls.Add(panelOperacion);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormularioHistoriasClinicas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administración de historias clínicas";
            FormClosing += FormularioHistoriasClinicas_FormClosing;
            Load += FormularioHistoriasClinicas_Load;
            panelOperacion.ResumeLayout(false);
            panelOperacion.PerformLayout();
            panelVisualizacion.ResumeLayout(false);
            panelVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHC).EndInit();
            ((System.ComponentModel.ISupportInitialize)historiasClinicasBindingSource1).EndInit();
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOperacion;
        private Panel panelVisualizacion;
        private DataGridView dataGridViewHC;
        private TextBox textBoxEstudios;
        private Label labelEstudios;
        private Label labelFechaYHora;
        private TextBox textBoxMotivo;
        private Label labelMotivoConsulta;
        private TextBox textBoxDetalles;
        private Label labelDetallesVisita;
        private TextBox textBoxIDCita;
        private TextBox textBoxMedicacion;
        private Label labelIDCita;
        private Label labelMedicacion;
        private Button buttonOperacion;
        private Button buttonModificar;
        private Button buttonEliminar;
        private DateTimePicker dateTimePickerF;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaConsultaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motivoConsultaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn detallesVisitaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estudiosRealizadosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn medicacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private BindingSource historiasClinicasBindingSource1;
        private Button buttonVolver;
        private Label labelHoras;
        private Label labelListado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Button buttonBuscar;
        private Label labelHs;
        private TextBox textBoxHora;
        private Panel panelBuscar;
        private Label labelIDpaciente;
        private TextBox textBoxIDpaciente;
        private TextBox textBoxNombreP;
        private Label labelNombreP;
        private TextBox textBoxDNIP;
        private Label labelDNIP;
        private TextBox textBoxApellidoP;
        private Label labelApellidoP;
    }
}