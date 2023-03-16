using Catering.DDD.Dominio.Chef.Entidades;
using Catering.DDD.Dominio.Comandos;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorOrganizador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Evento.Eventos
{
    public class DatosPersonalesOrganizadorAgregado : EventodeDominio
    {
        public DatosPersonalesOrganizador DatosPersonales{ get; set; }
        public DatosPersonalesOrganizadorAgregado(DatosPersonalesOrganizador datosPersonales) : base("DatosPersonales.Agregado")
        {
            this.DatosPersonales = datosPersonales;
        }
    }
}
