using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorEvento
{
    public class AgregadosID
    {
        public string ChefID { get; init; }

        internal AgregadosID(string chefID)
        {
            ChefID = chefID;
        }

        public AgregadosID() { }

        public static AgregadosID Create(string chefID)
        {
            validate(chefID);
            return new AgregadosID(chefID);
        }

        public static void validate(string s)
        {
            if (s == null)
            {
                throw new ArgumentException("El valor no puede ser nulo");
            }
        }
    }

}
