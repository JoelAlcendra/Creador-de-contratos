using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Final
{
    internal class Contratos
    {
        public Contratos() { }

        public int NumeroContrato { get; set; }
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string EstadoEmpleado { get; set; }
        public string TipoContrato { get; set; }
        public DateTime FecIngreso { get; set; }
        public DateTime FecRetiro { get; set; }
        public string FormaPago { get; set; }
        public double SueldoBasico { get; set; }
        public string EstadoContrato { get; set; }

        public Contratos (int numerocontrato, int identificacion, string nombre, string apellidos,
            string estadoempleado, string tipocontrato, DateTime fecingreso, DateTime fecretiro,
            string formapago, double sueldobasico, string estadocontrato)
        {
            NumeroContrato = numerocontrato;
            Identificacion = identificacion;
            Nombre = nombre;
            Apellidos = apellidos;
            EstadoEmpleado = estadoempleado;
            TipoContrato = tipocontrato;
            FecIngreso = fecingreso;
            FecRetiro = fecretiro;
            FormaPago = formapago;
            SueldoBasico = sueldobasico;
            EstadoContrato = estadocontrato;
        }

      
    }
}
