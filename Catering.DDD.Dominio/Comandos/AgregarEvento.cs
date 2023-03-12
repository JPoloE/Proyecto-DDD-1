using Catering.DDD.Dominio.Evento.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Comandos
{
    public abstract class AgregarEvento <T>: Entidad<T> where T : Identidad
    {
        private ChangedEventSuscriber ChangedEventSuscriber = new();

        protected AgregarEvento(T entidadID) : base(entidadID) { }

        public List<EventodeDominio> getUncommittedChanges() => ChangedEventSuscriber.GetChanges().ToList();

        public void AppendChange(EventodeDominio eventoD)
        {
            string nameClass = eventoD.GetType().Name;
            eventoD.SetAggregate(nameClass);
            eventoD.SetAggregateId(Identidad().Uuid.ToString());
            ChangedEventSuscriber.AppendChange(eventoD);
        }
    }
}
