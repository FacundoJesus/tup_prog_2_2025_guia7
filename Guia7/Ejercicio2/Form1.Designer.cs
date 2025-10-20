namespace Ejercicio2
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
            nudAño = new NumericUpDown();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnGenerarListado = new Button();
            lsbFechas = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAño).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudAño);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleccionar el año para generar fechas";
            // 
            // nudAño
            // 
            nudAño.Location = new Point(153, 44);
            nudAño.Name = "nudAño";
            nudAño.Size = new Size(83, 23);
            nudAño.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 46);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Año:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsbFechas);
            groupBox2.Controls.Add(btnGenerarListado);
            groupBox2.Location = new Point(12, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(408, 320);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Días relevantes de cada mes";
            // 
            // btnGenerarListado
            // 
            btnGenerarListado.Location = new Point(310, 142);
            btnGenerarListado.Name = "btnGenerarListado";
            btnGenerarListado.Size = new Size(75, 54);
            btnGenerarListado.TabIndex = 1;
            btnGenerarListado.Text = "Generar Listado";
            btnGenerarListado.UseVisualStyleBackColor = true;
            btnGenerarListado.Click += btnGenerarListado_Click;
            // 
            // lsbFechas
            // 
            lsbFechas.FormattingEnabled = true;
            lsbFechas.ItemHeight = 15;
            lsbFechas.Location = new Point(6, 22);
            lsbFechas.Name = "lsbFechas";
            lsbFechas.ScrollAlwaysVisible = true;
            lsbFechas.Size = new Size(277, 289);
            lsbFechas.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAño).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown nudAño;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnGenerarListado;
        private ListBox lsbFechas;
    }
}
