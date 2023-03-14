using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef;
using Catering.DDD.Dominio.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Eventos
{
    public class ContratodeChefAgregado : EventodeDominio
    {
        public ContratoChef ContratoChef { get; set; }

        public ContratodeChefAgregado(ContratoChef ContratoChef) : base("contrato.agregados")
        {
            ContratoChef = ContratoChef;
        }
    }
}
