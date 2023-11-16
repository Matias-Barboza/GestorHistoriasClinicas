namespace HistoriasClinicas
{
    partial class FormularioAdministrarCitas
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
            dataGridViewCitas = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            citasBindingSource1 = new BindingSource(components);
            panelOperacion = new Panel();
            textBoxApellidoP = new TextBox();
            label2 = new Label();
            textBoxNombreP = new TextBox();
            labelNombreP = new Label();
            labelHs = new Label();
            labelHora = new Label();
            comboBoxHoras = new ComboBox();
            buttonOperacion = new Button();
            textBoxIDPaciente = new TextBox();
            labelIDPaciente = new Label();
            textBoxMotivo = new TextBox();
            labelMotivo = new Label();
            labelFecha = new Label();
            dateTimePickerCitas = new DateTimePicker();
            panelVisalizacion = new Panel();
            buttonVolver = new Button();
            labelListado = new Label();
            buttonModificar = new Button();
            buttonEliminar = new Button();
            buttonAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCitas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)citasBindingSource1).BeginInit();
            panelOperacion.SuspendLayout();
            panelVisalizacion.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewCitas
            // 
            dataGridViewCitas.AllowUserToAddRows = false;
            dataGridViewCitas.AllowUserToDeleteRows = false;
            dataGridViewCitas.AutoGenerateColumns = false;
            dataGridViewCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCitas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCitas.DataSource = citasBindingSource1;
            dataGridViewCitas.Location = new Point(26, 71);
            dataGridViewCitas.Name = "dataGridViewCitas";
            dataGridViewCitas.ReadOnly = true;
            dataGridViewCitas.RowHeadersWidth = 62;
            dataGridViewCitas.RowTemplate.Height = 33;
            dataGridViewCitas.Size = new Size(865, 392);
            dataGridViewCitas.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "N° cita";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
            dataGridViewTextBoxColumn2.HeaderText = "Fecha y hora";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Motivo";
            dataGridViewTextBoxColumn3.HeaderText = "Motivo";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 350;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "IdPaciente";
            dataGridViewTextBoxColumn4.HeaderText = "N° paciente";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // citasBindingSource1
            // 
            citasBindingSource1.DataMember = "Citas";
            citasBindingSource1.DataSource = typeof(DataSetPCHC);
            // 
            // panelOperacion
            // 
            panelOperacion.Controls.Add(textBoxApellidoP);
            panelOperacion.Controls.Add(label2);
            panelOperacion.Controls.Add(textBoxNombreP);
            panelOperacion.Controls.Add(labelNombreP);
            panelOperacion.Controls.Add(labelHs);
            panelOperacion.Controls.Add(labelHora);
            panelOperacion.Controls.Add(comboBoxHoras);
            panelOperacion.Controls.Add(buttonOperacion);
            panelOperacion.Controls.Add(textBoxIDPaciente);
            panelOperacion.Controls.Add(labelIDPaciente);
            panelOperacion.Controls.Add(textBoxMotivo);
            panelOperacion.Controls.Add(labelMotivo);
            panelOperacion.Controls.Add(labelFecha);
            panelOperacion.Controls.Add(dateTimePickerCitas);
            panelOperacion.Enabled = false;
            panelOperacion.Location = new Point(-2, 1);
            panelOperacion.Name = "panelOperacion";
            panelOperacion.Size = new Size(380, 539);
            panelOperacion.TabIndex = 1;
            // 
            // textBoxApellidoP
            // 
            textBoxApellidoP.Enabled = false;
            textBoxApellidoP.Location = new Point(26, 246);
            textBoxApellidoP.Name = "textBoxApellidoP";
            textBoxApellidoP.Size = new Size(174, 31);
            textBoxApellidoP.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 207);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 12;
            label2.Text = "Apellido de paciente:";
            // 
            // textBoxNombreP
            // 
            textBoxNombreP.Enabled = false;
            textBoxNombreP.Location = new Point(26, 159);
            textBoxNombreP.Name = "textBoxNombreP";
            textBoxNombreP.Size = new Size(174, 31);
            textBoxNombreP.TabIndex = 11;
            // 
            // labelNombreP
            // 
            labelNombreP.AutoSize = true;
            labelNombreP.Location = new Point(23, 120);
            labelNombreP.Name = "labelNombreP";
            labelNombreP.Size = new Size(178, 25);
            labelNombreP.TabIndex = 10;
            labelNombreP.Text = "Nombre de paciente:";
            // 
            // labelHs
            // 
            labelHs.AutoSize = true;
            labelHs.Location = new Point(287, 340);
            labelHs.Name = "labelHs";
            labelHs.Size = new Size(33, 25);
            labelHs.TabIndex = 9;
            labelHs.Text = "Hs";
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Location = new Point(200, 299);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(55, 25);
            labelHora.TabIndex = 8;
            labelHora.Text = "Hora:";
            // 
            // comboBoxHoras
            // 
            comboBoxHoras.FormattingEnabled = true;
            comboBoxHoras.Location = new Point(200, 337);
            comboBoxHoras.Name = "comboBoxHoras";
            comboBoxHoras.Size = new Size(81, 33);
            comboBoxHoras.TabIndex = 7;
            // 
            // buttonOperacion
            // 
            buttonOperacion.Location = new Point(102, 493);
            buttonOperacion.Name = "buttonOperacion";
            buttonOperacion.Size = new Size(148, 34);
            buttonOperacion.TabIndex = 6;
            buttonOperacion.UseVisualStyleBackColor = true;
            buttonOperacion.Click += buttonOperacion_Click;
            // 
            // textBoxIDPaciente
            // 
            textBoxIDPaciente.Location = new Point(26, 70);
            textBoxIDPaciente.Name = "textBoxIDPaciente";
            textBoxIDPaciente.Size = new Size(174, 31);
            textBoxIDPaciente.TabIndex = 5;
            textBoxIDPaciente.TextChanged += textBoxIDPaciente_TextChanged;
            // 
            // labelIDPaciente
            // 
            labelIDPaciente.AutoSize = true;
            labelIDPaciente.Location = new Point(23, 31);
            labelIDPaciente.Name = "labelIDPaciente";
            labelIDPaciente.Size = new Size(210, 25);
            labelIDPaciente.TabIndex = 4;
            labelIDPaciente.Text = "Número de paciente (ID):";
            // 
            // textBoxMotivo
            // 
            textBoxMotivo.Location = new Point(28, 432);
            textBoxMotivo.Name = "textBoxMotivo";
            textBoxMotivo.Size = new Size(346, 31);
            textBoxMotivo.TabIndex = 3;
            // 
            // labelMotivo
            // 
            labelMotivo.AutoSize = true;
            labelMotivo.Location = new Point(23, 394);
            labelMotivo.Name = "labelMotivo";
            labelMotivo.Size = new Size(227, 25);
            labelMotivo.TabIndex = 2;
            labelMotivo.Text = "Motivo (breve descripción):";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(23, 299);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(61, 25);
            labelFecha.TabIndex = 1;
            labelFecha.Text = "Fecha:";
            // 
            // dateTimePickerCitas
            // 
            dateTimePickerCitas.Checked = false;
            dateTimePickerCitas.Format = DateTimePickerFormat.Short;
            dateTimePickerCitas.Location = new Point(28, 334);
            dateTimePickerCitas.Name = "dateTimePickerCitas";
            dateTimePickerCitas.Size = new Size(151, 31);
            dateTimePickerCitas.TabIndex = 0;
            dateTimePickerCitas.Value = new DateTime(2023, 7, 3, 12, 5, 48, 0);
            // 
            // panelVisalizacion
            // 
            panelVisalizacion.Controls.Add(buttonVolver);
            panelVisalizacion.Controls.Add(labelListado);
            panelVisalizacion.Controls.Add(buttonModificar);
            panelVisalizacion.Controls.Add(buttonEliminar);
            panelVisalizacion.Controls.Add(buttonAgregar);
            panelVisalizacion.Controls.Add(dataGridViewCitas);
            panelVisalizacion.Location = new Point(384, 1);
            panelVisalizacion.Name = "panelVisalizacion";
            panelVisalizacion.Size = new Size(915, 539);
            panelVisalizacion.TabIndex = 2;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(588, 493);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(149, 34);
            buttonVolver.TabIndex = 10;
            buttonVolver.Text = "Volver al menú";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // labelListado
            // 
            labelListado.AutoSize = true;
            labelListado.Location = new Point(26, 31);
            labelListado.Name = "labelListado";
            labelListado.Size = new Size(138, 25);
            labelListado.TabIndex = 7;
            labelListado.Text = "Listado de citas:";
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(459, 493);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(112, 34);
            buttonModificar.TabIndex = 9;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(330, 493);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(112, 34);
            buttonEliminar.TabIndex = 8;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(201, 493);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(112, 34);
            buttonAgregar.TabIndex = 7;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // FormularioAdministrarCitas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 540);
            Controls.Add(panelVisalizacion);
            Controls.Add(panelOperacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormularioAdministrarCitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administración de citas";
            FormClosing += FormularioAdministrarCitas_FormClosing;
            Load += FormularioAdministrarCitas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCitas).EndInit();
            ((System.ComponentModel.ISupportInitialize)citasBindingSource1).EndInit();
            panelOperacion.ResumeLayout(false);
            panelOperacion.PerformLayout();
            panelVisalizacion.ResumeLayout(false);
            panelVisalizacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCitas;
        private Panel panelOperacion;
        private Label labelMotivo;
        private Label labelFecha;
        private DateTimePicker dateTimePickerCitas;
        private Panel panelVisalizacion;
        private TextBox textBoxMotivo;
        private TextBox textBoxIDPaciente;
        private Label labelIDPaciente;
        private Button buttonOperacion;
        private Button buttonModificar;
        private Button buttonEliminar;
        private Button buttonAgregar;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn motivoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private BindingSource citasBindingSource1;
        private Label labelListado;
        private Button buttonVolver;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private ComboBox comboBoxHoras;
        private Label labelHora;
        private Label labelHs;
        private TextBox textBoxApellidoP;
        private Label label2;
        private TextBox textBoxNombreP;
        private Label labelNombreP;
    }
}