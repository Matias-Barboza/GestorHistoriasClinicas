namespace HistoriasClinicas
{
    partial class FormularioGenerarInforme
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
            buttonPDF = new Button();
            labelIDPaciente = new Label();
            textBoxID = new TextBox();
            labelDNI = new Label();
            textBoxDNI = new TextBox();
            buttonVolver = new Button();
            SuspendLayout();
            // 
            // buttonPDF
            // 
            buttonPDF.Location = new Point(141, 137);
            buttonPDF.Name = "buttonPDF";
            buttonPDF.Size = new Size(193, 36);
            buttonPDF.TabIndex = 0;
            buttonPDF.Text = "Generar informe PDF";
            buttonPDF.UseVisualStyleBackColor = true;
            buttonPDF.Click += buttonPDF_Click;
            // 
            // labelIDPaciente
            // 
            labelIDPaciente.AutoSize = true;
            labelIDPaciente.Location = new Point(39, 27);
            labelIDPaciente.Name = "labelIDPaciente";
            labelIDPaciente.Size = new Size(210, 25);
            labelIDPaciente.TabIndex = 2;
            labelIDPaciente.Text = "Número de paciente (ID):";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(248, 24);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(150, 31);
            textBoxID.TabIndex = 3;
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Location = new Point(39, 76);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(143, 25);
            labelDNI.TabIndex = 4;
            labelDNI.Text = "DNI de paciente:";
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(188, 73);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(184, 31);
            textBoxDNI.TabIndex = 5;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(168, 193);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(141, 36);
            buttonVolver.TabIndex = 6;
            buttonVolver.Text = "Volver al menú";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // FormularioGenerarInforme
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 243);
            Controls.Add(buttonVolver);
            Controls.Add(textBoxDNI);
            Controls.Add(labelDNI);
            Controls.Add(textBoxID);
            Controls.Add(labelIDPaciente);
            Controls.Add(buttonPDF);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormularioGenerarInforme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generar informe de paciente";
            FormClosing += FormularioGenerarInforme_FormClosing;
            Load += FormularioGenerarInforme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPDF;
        private Label labelIDPaciente;
        private TextBox textBoxID;
        private Label labelDNI;
        private TextBox textBoxDNI;
        private Button buttonVolver;
    }
}