using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Comandos
{
    public class AgregarMenuComando
    {
        public string ChefId { get; set; }
        public string TipoMenu { get; set; }
        public string Detalles { get; set; }
        public string NombrePlatillo { get; set; }
        public double Cantidad { get; set; }
        public string Restriccion { get; set; }
        public string TipoPlatillo { get; set; }
        
    }
}
