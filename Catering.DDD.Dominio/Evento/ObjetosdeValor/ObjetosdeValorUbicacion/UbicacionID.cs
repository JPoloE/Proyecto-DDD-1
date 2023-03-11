using System;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;

namespace Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorUbicacion
{
	public record UbicacionID
	{
        public Guid value { get; init; }

        internal UbicacionID(Guid value_)
        {
            value = value_;
        }

        public static UbicacionID Create(Guid value)
        {
            return new UbicacionID(value);
        }

        public static implicit operator Guid(UbicacionID cocineroID)
        {
            return cocineroID.value;
        }
    }
}

