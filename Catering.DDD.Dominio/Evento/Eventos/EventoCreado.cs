using Catering.DDD.Dominio.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Evento.Eventos
{
    public class EventoCreado : EventodeDominio
    {
        public string EventoID { get; init; }

        public EventoCreado(string eventoID) : base("Evento.creado")
        {
            EventoID = eventoID;
        }
    }
}
