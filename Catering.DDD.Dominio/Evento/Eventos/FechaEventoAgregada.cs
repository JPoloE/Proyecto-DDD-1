using Catering.DDD.Dominio.Chef.Entidades;
using Catering.DDD.Dominio.Comandos;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorEvento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Evento.Eventos
{
    public class FechaEventoAgregada : EventodeDominio
    {
        public Fecha Fecha { get; set; }

        public FechaEventoAgregada(Fecha fecha) : base("Fecha.Agregado")
        {
            Fecha = fecha;
        }
    }
}
