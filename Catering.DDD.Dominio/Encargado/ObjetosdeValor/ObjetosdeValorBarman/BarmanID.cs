using System;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorEvento;

namespace Catering.DDD.Dominio.Encargado.ObjetosdeValor.ObjetosdeValorBarman
{
	public record BarmanID
	{
        public Guid value { get; init; }

        internal BarmanID(Guid value_)
        {
            value = value_;
        }

        public static BarmanID Create(Guid value)
        {
            return new BarmanID(value);
        }

        public static implicit operator Guid(BarmanID barmanID)
        {
            return barmanID.value;
        }
    }
}

