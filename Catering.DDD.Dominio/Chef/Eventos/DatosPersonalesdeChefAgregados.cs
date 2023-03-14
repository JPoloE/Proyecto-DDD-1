using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef;
using Catering.DDD.Dominio.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Eventos
{
    public class DatosPersonalesdeChefAgregados : EventodeDominio
    {
        public DatosPersonalesChef PersonalData { get; set; }

        public DatosPersonalesdeChefAgregados(DatosPersonalesChef personalData) : base("datosPersonales.agregados")
        {
            PersonalData = personalData;
        }
    }
}
