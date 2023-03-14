using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;
using Catering.DDD.Dominio.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Eventos
{
    internal class DatosPersonalesCocineroAgregados : EventodeDominio
    {
        public DatosPersonalesCocinero DatosPersonales { get; set; }

        public DatosPersonalesCocineroAgregados(DatosPersonalesCocinero datosPersonales) : base("datospersonales.agregado")
        {
            DatosPersonales = datosPersonales;
        }
    }
}
