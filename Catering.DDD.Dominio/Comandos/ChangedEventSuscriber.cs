using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Comandos
{
    public class ChangedEventSuscriber
    {
        private List<EventodeDominio> Changes = new List<EventodeDominio>();

        public List<EventodeDominio> GetChanges() => Changes;

        public void AppendChange(EventodeDominio eventodeDominio)
        {
            this.Changes.Add(eventodeDominio);
        }
    }
}
