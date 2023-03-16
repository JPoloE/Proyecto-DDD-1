using Catering.DDD.Dominio.Comandos;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorOrganizador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Evento.Eventos
{
    public class ContratoOrganizadorAgregado : EventodeDominio
    {
        public ContratoOrganizador Contrato { get; set; }
        public ContratoOrganizadorAgregado(ContratoOrganizador contrato) : base("Contrato.Agregado")
        {
            Contrato = contrato;
        }
    }
}
