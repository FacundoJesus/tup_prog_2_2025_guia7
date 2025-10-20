using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    public class DetalleServicio
    {
        public DateTime Inicio { get; set; }
        public DateTime Fin {  get; set; }
        public int Unidades { 
            get 
            {
                return Convert.ToInt32(Math.Floor((this.Fin - this.Inicio).TotalSeconds / 60));

            }
        }
        public double CostoUnitario { get; set; }
        public double CostoTotal { get
            {
                return this.Unidades * this.CostoUnitario;
            }
        }

        public DetalleServicio(DateTime inicio, DateTime fin, double costoUnitario)
        {
            this.Inicio = inicio;
            this.Fin = fin;
            this.CostoUnitario = costoUnitario;
        }

        public override string ToString()
        {
            return @$"Intervalo: {Inicio:ddd hh:mm}    ${CostoTotal:f2}
    Franja horaria:{Inicio:dd hh:mm}-{Fin:hh:mm}(Udx$:{Unidades}x${CostoUnitario:f2})";
        }
    }
}
