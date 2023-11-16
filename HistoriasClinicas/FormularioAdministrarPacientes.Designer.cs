namespace HistoriasClinicas
{
    partial class FormularioAdministrarPacientes
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
            labelNombre = new Label();
            labelApellido = new Label();
            labelDNI = new Label();
            labelGenero = new Label();
            labelDireccion = new Label();
            labelTelefono = new Label();
            textBoxApellido = new TextBox();
            textBoxNombre = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxTelefono = new TextBox();
            comboBoxGenero = new ComboBox();
            textBoxDNI = new TextBox();
            panelOperacion = new Panel();
            buttonOperacion = new Button();
            panelVisualizacion = new Panel();
            labelListado = new Label();
            buttonVolver = new Button();
            dataGridViewPacientes = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            pacientesBindingSource = new BindingSource(components);
            buttonModificar = new Button();
            buttonEliminar = new Button();
            buttonAgregar = new Button();
            panelOperacion.SuspendLayout();
            panelVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pacientesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(22, 14);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(82, 25);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(22, 88);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(82, 25);
            labelApellido.TabIndex = 1;
            labelApellido.Text = "Apellido:";
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Location = new Point(22, 161);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(145, 25);
            labelDNI.TabIndex = 2;
            labelDNI.Text = "DNI (sin puntos):";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(22, 243);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(73, 25);
            labelGenero.TabIndex = 3;
            labelGenero.Text = "Género:";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(22, 314);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(85, 25);
            labelDireccion.TabIndex = 4;
            labelDireccion.Text = "Direccion";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(22, 386);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(83, 25);
            labelTelefono.TabIndex = 5;
            labelTelefono.Text = "Teléfono:";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(22, 116);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(206, 31);
            textBoxApellido.TabIndex = 6;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(22, 42);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(206, 31);
            textBoxNombre.TabIndex = 7;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(22, 342);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(206, 31);
            textBoxDireccion.TabIndex = 10;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(22, 423);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(211, 31);
            textBoxTelefono.TabIndex = 11;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Location = new Point(22, 278);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(206, 33);
            comboBoxGenero.TabIndex = 13;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(22, 199);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(206, 31);
            textBoxDNI.TabIndex = 14;
            // 
            // panelOperacion
            // 
            panelOperacion.Controls.Add(buttonOperacion);
            panelOperacion.Controls.Add(textBoxNombre);
            panelOperacion.Controls.Add(textBoxDNI);
            panelOperacion.Controls.Add(labelNombre);
            panelOperacion.Controls.Add(comboBoxGenero);
            panelOperacion.Controls.Add(labelApellido);
            panelOperacion.Controls.Add(textBoxTelefono);
            panelOperacion.Controls.Add(labelDNI);
            panelOperacion.Controls.Add(textBoxDireccion);
            panelOperacion.Controls.Add(labelGenero);
            panelOperacion.Controls.Add(labelDireccion);
            panelOperacion.Controls.Add(textBoxApellido);
            panelOperacion.Controls.Add(labelTelefono);
            panelOperacion.Enabled = false;
            panelOperacion.Location = new Point(2, 1);
            panelOperacion.Name = "panelOperacion";
            panelOperacion.Size = new Size(300, 588);
            panelOperacion.TabIndex = 15;
            // 
            // buttonOperacion
            // 
            buttonOperacion.Location = new Point(51, 519);
            buttonOperacion.Name = "buttonOperacion";
            buttonOperacion.Size = new Size(161, 34);
            buttonOperacion.TabIndex = 15;
            buttonOperacion.UseVisualStyleBackColor = true;
            buttonOperacion.Click += buttonOperacion_Click;
            // 
            // panelVisualizacion
            // 
            panelVisualizacion.Controls.Add(labelListado);
            panelVisualizacion.Controls.Add(buttonVolver);
            panelVisualizacion.Controls.Add(dataGridViewPacientes);
            panelVisualizacion.Controls.Add(buttonModificar);
            panelVisualizacion.Controls.Add(buttonEliminar);
            panelVisualizacion.Controls.Add(buttonAgregar);
            panelVisualizacion.Location = new Point(308, 1);
            panelVisualizacion.Name = "panelVisualizacion";
            panelVisualizacion.Size = new Size(1150, 588);
            panelVisualizacion.TabIndex = 16;
            // 
            // labelListado
            // 
            labelListado.AutoSize = true;
            labelListado.Location = new Point(13, 14);
            labelListado.Name = "labelListado";
            labelListado.Size = new Size(177, 25);
            labelListado.TabIndex = 16;
            labelListado.Text = "Listado de pacientes:";
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(727, 519);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(154, 34);
            buttonVolver.TabIndex = 4;
            buttonVolver.Text = "Volver al menú";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // dataGridViewPacientes
            // 
            dataGridViewPacientes.AllowUserToAddRows = false;
            dataGridViewPacientes.AllowUserToDeleteRows = false;
            dataGridViewPacientes.AutoGenerateColumns = false;
            dataGridViewPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPacientes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dataGridViewPacientes.DataSource = pacientesBindingSource;
            dataGridViewPacientes.Location = new Point(13, 55);
            dataGridViewPacientes.Name = "dataGridViewPacientes";
            dataGridViewPacientes.ReadOnly = true;
            dataGridViewPacientes.RowHeadersWidth = 62;
            dataGridViewPacientes.RowTemplate.Height = 33;
            dataGridViewPacientes.Size = new Size(1115, 440);
            dataGridViewPacientes.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Paciente n°";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Apellido";
            dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "DNI";
            dataGridViewTextBoxColumn4.HeaderText = "DNI";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Genero";
            dataGridViewTextBoxColumn5.HeaderText = "Género";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Direccion";
            dataGridViewTextBoxColumn6.HeaderText = "Dirección";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Telefono";
            dataGridViewTextBoxColumn7.HeaderText = "Teléfono";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // pacientesBindingSource
            // 
            pacientesBindingSource.DataMember = "Pacientes";
            pacientesBindingSource.DataSource = typeof(DataSetPCHC);
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(597, 519);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(112, 34);
            buttonModificar.TabIndex = 2;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(466, 519);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(112, 34);
            buttonEliminar.TabIndex = 1;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(330, 519);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(112, 34);
            buttonAgregar.TabIndex = 0;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // FormularioAdministrarPacientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1461, 591);
            Controls.Add(panelVisualizacion);
            Controls.Add(panelOperacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormularioAdministrarPacientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administración de pacientes";
            FormClosing += FormularioAdministrarPacientes_FormClosing;
            Load += FormularioAdministrarPacientes_Load;
            panelOperacion.ResumeLayout(false);
            panelOperacion.PerformLayout();
            panelVisualizacion.ResumeLayout(false);
            panelVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pacientesBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelNombre;
        private Label labelApellido;
        private Label labelDNI;
        private Label labelGenero;
        private Label labelDireccion;
        private Label labelTelefono;
        private TextBox textBoxApellido;
        private TextBox textBoxNombre;
        private TextBox textBoxDireccion;
        private TextBox textBoxTelefono;
        private ComboBox comboBoxGenero;
        private TextBox textBoxDNI;
        private Panel panelOperacion;
        private Button buttonOperacion;
        private Panel panelVisualizacion;
        private DataGridView dataGridViewPacientes;
        private Button buttonModificar;
        private Button buttonEliminar;
        private Button buttonAgregar;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private BindingSource pacientesBindingSource;
        private Button buttonVolver;
        private Label labelListado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}