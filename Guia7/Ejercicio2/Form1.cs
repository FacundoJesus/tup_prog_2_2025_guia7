namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerarListado_Click(object sender, EventArgs e)
        {
            int ano = Convert.ToInt32(nudA�o.Text);

            lsbFechas.Items.Clear();

            for (int n = 1; n <= 12; n++)
            {
                #region calcula el quinto d�a habil
                DateOnly fecha = new DateOnly(ano, n, 1);

                int dia = 1;
                while (dia < 5)
                {
                    if (fecha.DayOfWeek > DayOfWeek.Monday && fecha.DayOfWeek < DayOfWeek.Saturday)
                    {
                        dia++;
                    }
                    fecha = fecha.AddDays(1);
                }

                lsbFechas.Items.Add($"{fecha:MMMM}");
                lsbFechas.Items.Add($"   Primera fecha: {fecha:dddd, d}");

                #endregion

                #region 5 dias antes de finalizar el mes
                fecha = new DateOnly(ano, n, 1);
                fecha = fecha.AddMonths(1).AddDays(-6);

                lsbFechas.Items.Add($"   Segunda fecha: {fecha:dddd, d}");
                #endregion


                nudA�o.Value = 0;
            }
        }
    }
}
