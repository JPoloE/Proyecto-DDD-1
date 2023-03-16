using Catering.DDD.Dominio.Comandos;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorEvento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Evento.Eventos
{
    public class AgregadosdeEventosAgregados : EventodeDominio
    {
        public AgregadosID Agregados { get; set; }
        public AgregadosdeEventosAgregados(AgregadosID agregados) : base("agregados.agregados")
        {
            Agregados = agregados;
        }
    }
}
