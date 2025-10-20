namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarFecha_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFechayHoraNac.Value;

            lsbResultado.Items.Add(fecha);
        }

        private void lsbResultado_SelectedValueChanged(object sender, EventArgs e)
        {
            DateTime selectedFecha = dtpFechayHoraNac.Value;

            TimeSpan ts = DateTime.Now - selectedFecha;

            int anos = ts.Days / 365;

            lbEdad.Text = $"{anos}";
        }
    }
}
