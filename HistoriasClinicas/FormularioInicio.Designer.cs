namespace HistoriasClinicas
{
    partial class FormularioInicio
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
            buttonAdministrarPacientes = new Button();
            buttonAdministrarCitas = new Button();
            buttonAdministrarHC = new Button();
            buttonGenerarInforme = new Button();
            labelSeleccion = new Label();
            SuspendLayout();
            // 
            // buttonAdministrarPacientes
            // 
            buttonAdministrarPacientes.Location = new Point(82, 84);
            buttonAdministrarPacientes.Name = "buttonAdministrarPacientes";
            buttonAdministrarPacientes.Size = new Size(208, 42);
            buttonAdministrarPacientes.TabIndex = 0;
            buttonAdministrarPacientes.Text = " Administrar pacientes";
            buttonAdministrarPacientes.UseVisualStyleBackColor = true;
            buttonAdministrarPacientes.Click += buttonAdministrarPacientes_Click;
            // 
            // buttonAdministrarCitas
            // 
            buttonAdministrarCitas.Location = new Point(82, 141);
            buttonAdministrarCitas.Name = "buttonAdministrarCitas";
            buttonAdministrarCitas.Size = new Size(208, 42);
            buttonAdministrarCitas.TabIndex = 1;
            buttonAdministrarCitas.Text = "Administrar citas";
            buttonAdministrarCitas.UseVisualStyleBackColor = true;
            buttonAdministrarCitas.Click += buttonAdministrarCitas_Click;
            // 
            // buttonAdministrarHC
            // 
            buttonAdministrarHC.Location = new Point(82, 199);
            buttonAdministrarHC.Name = "buttonAdministrarHC";
            buttonAdministrarHC.Size = new Size(208, 42);
            buttonAdministrarHC.TabIndex = 2;
            buttonAdministrarHC.Text = "Historias clínicas";
            buttonAdministrarHC.UseVisualStyleBackColor = true;
            buttonAdministrarHC.Click += buttonAdministrarHC_Click;
            // 
            // buttonGenerarInforme
            // 
            buttonGenerarInforme.Location = new Point(82, 257);
            buttonGenerarInforme.Name = "buttonGenerarInforme";
            buttonGenerarInforme.Size = new Size(208, 42);
            buttonGenerarInforme.TabIndex = 3;
            buttonGenerarInforme.Text = "Generar informe";
            buttonGenerarInforme.UseVisualStyleBackColor = true;
            buttonGenerarInforme.Click += buttonGenerarInforme_Click;
            // 
            // labelSeleccion
            // 
            labelSeleccion.AutoSize = true;
            labelSeleccion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeleccion.Location = new Point(44, 23);
            labelSeleccion.Name = "labelSeleccion";
            labelSeleccion.Size = new Size(301, 38);
            labelSeleccion.TabIndex = 4;
            labelSeleccion.Text = "Seleccione una opción:";
            // 
            // FormularioInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 327);
            Controls.Add(labelSeleccion);
            Controls.Add(buttonGenerarInforme);
            Controls.Add(buttonAdministrarHC);
            Controls.Add(buttonAdministrarCitas);
            Controls.Add(buttonAdministrarPacientes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormularioInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de historias clínicas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdministrarPacientes;
        private Button buttonAdministrarCitas;
        private Button buttonAdministrarHC;
        private Button buttonGenerarInforme;
        private Label labelSeleccion;
    }
}