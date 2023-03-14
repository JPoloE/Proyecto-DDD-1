using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;
using Catering.DDD.Dominio.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Eventos
{
    public class ContratoCocineroAgregado : EventodeDominio
    {
        public ContratoCocinero Contrato { get; set; }

        public ContratoCocineroAgregado(ContratoCocinero contrato) : base("contratococinero.agregado")
        {
            Contrato = contrato;
        }
    }
}
