using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef;
using Catering.DDD.Dominio.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Eventos
{
    public class EspecialidaddeChefAgregada : EventodeDominio
    {
        public EspecialidadChef Especialidad { get; set; }

        public EspecialidaddeChefAgregada(EspecialidadChef especialiad) : base("especialidad.agregados")
        {
            Especialidad = especialiad;
        }
    }
}
