using Catering.DDD.Dominio.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Eventos
{
    internal class CocineroEliminado : EventodeDominio
    {
        public Guid CocineroID { get; init; }

        public CocineroEliminado(Guid cocineroID) : base("Cocinero.eliminado")
        {
            CocineroID = cocineroID;
        }
    }
}
