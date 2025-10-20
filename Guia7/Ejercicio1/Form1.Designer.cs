namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAgregarFecha = new Button();
            dtpFechayHoraNac = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            lbEdad = new Label();
            lsbResultado = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha y Hora de Nacimiento:";
            // 
            // btnAgregarFecha
            // 
            btnAgregarFecha.Location = new Point(254, 12);
            btnAgregarFecha.Name = "btnAgregarFecha";
            btnAgregarFecha.Size = new Size(75, 44);
            btnAgregarFecha.TabIndex = 1;
            btnAgregarFecha.Text = "Agregar Fecha";
            btnAgregarFecha.UseVisualStyleBackColor = true;
            btnAgregarFecha.Click += btnAgregarFecha_Click;
            // 
            // dtpFechayHoraNac
            // 
            dtpFechayHoraNac.CustomFormat = "dd/MM/yyyy HH:MM";
            dtpFechayHoraNac.Format = DateTimePickerFormat.Custom;
            dtpFechayHoraNac.Location = new Point(12, 33);
            dtpFechayHoraNac.Name = "dtpFechayHoraNac";
            dtpFechayHoraNac.Size = new Size(129, 23);
            dtpFechayHoraNac.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Salida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 157);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Edad:";
            // 
            // lbEdad
            // 
            lbEdad.BackColor = SystemColors.ActiveCaption;
            lbEdad.ForeColor = Color.Black;
            lbEdad.Location = new Point(273, 157);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(56, 15);
            lbEdad.TabIndex = 5;
            // 
            // lsbResultado
            // 
            lsbResultado.FormattingEnabled = true;
            lsbResultado.ItemHeight = 15;
            lsbResultado.Location = new Point(12, 95);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.Size = new Size(200, 124);
            lsbResultado.TabIndex = 6;
            lsbResultado.SelectedValueChanged += lsbResultado_SelectedValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 232);
            Controls.Add(lsbResultado);
            Controls.Add(lbEdad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpFechayHoraNac);
            Controls.Add(btnAgregarFecha);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregarFecha;
        private DateTimePicker dtpFechayHoraNac;
        private Label label2;
        private Label label3;
        private Label lbEdad;
        private ListBox lsbResultado;
    }
}
