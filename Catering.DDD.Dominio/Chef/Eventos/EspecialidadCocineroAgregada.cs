using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;
using Catering.DDD.Dominio.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Eventos
{
    internal class EspecialidadCocineroAgregada : EventodeDominio
    {
        public EspecialidadCocinero Especialidad { get; set; }

        public EspecialidadCocineroAgregada(EspecialidadCocinero especialidad) : base("especialidad.agregado")
        {
            Especialidad = especialidad;
        }
    }
}
