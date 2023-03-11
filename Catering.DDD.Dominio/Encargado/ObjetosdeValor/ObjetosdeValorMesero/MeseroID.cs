using System;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorEvento;

namespace Catering.DDD.Dominio.Encargado.ObjetosdeValor.ObjetosdeValorMesero
{
	public record MeseroID
	{
        public Guid value { get; init; }

        internal MeseroID(Guid value_)
        {
            value = value_;
        }

        public static MeseroID Create(Guid value)
        {
            return new MeseroID(value);
        }

        public static implicit operator Guid(MeseroID meseroID)
        {
            return meseroID.value;
        }
    }
}

