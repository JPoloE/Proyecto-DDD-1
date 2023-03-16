using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Evento.Comandos
{
    public class CrearEventoComando
    {
        public string TipoEvento { get; set; }
        public string FechaEvento { get; set; }

        public CrearEventoComando(string tipoEvento, string fechaEvento) 
        {
            TipoEvento = tipoEvento;
            FechaEvento = fechaEvento;
        }
    }
}
