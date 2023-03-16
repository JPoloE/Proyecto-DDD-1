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
    public class TipoEventoAgreagdo : EventodeDominio
    {
        public TipoEvento Tipo { get; set; }
        public TipoEventoAgreagdo(TipoEvento tipo) : base("Tipo.Agregado")
        {
            this.Tipo = tipo;
        }
    }
}
