namespace Ejercicio3
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
            groupBox1 = new GroupBox();
            btnRegistrarServicio = new Button();
            dtpHoraFin = new DateTimePicker();
            dtpHoraInicio = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tbTicket = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrarServicio);
            groupBox1.Controls.Add(dtpHoraFin);
            groupBox1.Controls.Add(dtpHoraInicio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 170);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del servicio de comunicaciones prestado";
            // 
            // btnRegistrarServicio
            // 
            btnRegistrarServicio.Location = new Point(276, 49);
            btnRegistrarServicio.Name = "btnRegistrarServicio";
            btnRegistrarServicio.Size = new Size(75, 62);
            btnRegistrarServicio.TabIndex = 4;
            btnRegistrarServicio.Text = "Registrar Servicio";
            btnRegistrarServicio.UseVisualStyleBackColor = true;
            btnRegistrarServicio.Click += btnRegistrarServicio_Click;
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpHoraFin.Format = DateTimePickerFormat.Custom;
            dtpHoraFin.Location = new Point(20, 114);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.Size = new Size(132, 23);
            dtpHoraFin.TabIndex = 3;
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.Location = new Point(20, 47);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.Size = new Size(132, 23);
            dtpHoraInicio.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 96);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 1;
            label2.Text = "Hora de Finalización:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 29);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Hora de Inicio:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbTicket);
            groupBox2.Location = new Point(12, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 357);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle del Ticket";
            // 
            // tbTicket
            // 
            tbTicket.Location = new Point(6, 22);
            tbTicket.Multiline = true;
            tbTicket.Name = "tbTicket";
            tbTicket.ScrollBars = ScrollBars.Vertical;
            tbTicket.Size = new Size(360, 329);
            tbTicket.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 557);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRegistrarServicio;
        private DateTimePicker dtpHoraFin;
        private DateTimePicker dtpHoraInicio;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox tbTicket;
    }
}
