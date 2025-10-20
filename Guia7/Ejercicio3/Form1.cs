using Ejercicio3.Models;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarServicio_Click(object sender, EventArgs e)
        {
            DateTime inicio = dtpHoraInicio.Value;
            DateTime fin = dtpHoraFin.Value;

            ServicioDeComunicaciones servicio = new ServicioDeComunicaciones(inicio, fin);

            tbTicket.Clear();
            foreach (string linea in servicio.VerImpresionTicket())
            {
                tbTicket.Text += linea + "\r\n";
            }
        }
    }
}

