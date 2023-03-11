using System;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorEvento;

namespace Catering.DDD.Dominio.Encargado.ObjetosdeValor.ObjetosdeValorEncargado
{
	public record EncargadoID
	{
        public Guid value { get; init; }

        internal EncargadoID(Guid value_)
        {
            value = value_;
        }

        public static EncargadoID Create(Guid value)
        {
            return new EncargadoID(value);
        }

        public static implicit operator Guid(EncargadoID encargadoID)
        {
            return encargadoID.value;
        }
    }
}

