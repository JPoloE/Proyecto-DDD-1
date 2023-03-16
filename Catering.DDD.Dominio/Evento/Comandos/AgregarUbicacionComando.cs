using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Evento.Comandos
{
    public class AgregarUbicacionComando
    {
        public string EventoId { get; init; }
        public int CapacidaddePersonas { get; init; }
        public string CapacidaddeMesas { get; init; }
        public string Electricidad { get; init; }
        public string AguaPotable { get; init; }

    }
}
