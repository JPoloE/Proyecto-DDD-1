using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Comandos
{
    public class AgregarCocineroComando
    {
        public string ChefId { get; set; }
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public int Cedula { get; set; }
        public string Experiencia { get; set; }
        public string Idiomas { get; set; }
        public string Especialidad { get; set; }
        public string TipoContrato { get; init; }
        public string FormaPago { get; init; }
        public string EspecialidadCocinero { get; init; }
    }
}
