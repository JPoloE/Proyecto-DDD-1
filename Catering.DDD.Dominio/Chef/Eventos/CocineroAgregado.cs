using Catering.DDD.Dominio.Chef.Entidades;
using Catering.DDD.Dominio.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Eventos
{
    public class CocineroAgregado : EventodeDominio
    {
        public Cocinero Cocinero { get; set; }
        public CocineroAgregado(Cocinero cocinero) : base("Cocinero.Agregado")
        {
            this.Cocinero = cocinero;
        }
    }
}
