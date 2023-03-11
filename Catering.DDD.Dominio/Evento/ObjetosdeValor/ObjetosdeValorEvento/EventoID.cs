using System;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;

namespace Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorEvento
{
	public record EventoID
	{
        public Guid value { get; init; }

        internal EventoID(Guid value_)
        {
            value = value_;
        }

        public static EventoID Create(Guid value)
        {
            return new EventoID(value);
        }

        public static implicit operator Guid(EventoID cocineroID)
        {
            return cocineroID.value;
        }
    }
}

