using System;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef;

namespace Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero
{
	public record CocineroID
	{
        public Guid value { get; init; }

        internal CocineroID(Guid value_)
        {
            value = value_;
        }

        public static CocineroID Create(Guid value)
        {
            return new CocineroID(value);
        }

        public static implicit operator Guid(CocineroID cocineroID)
        {
            return cocineroID.value;
        }
    }
}

