using System;
namespace Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorOrganizador
{
	public class OrganizadorID
	{
        public Guid value { get; init; }

        internal OrganizadorID(Guid value_)
        {
            value = value_;
        }

        public static OrganizadorID Create(Guid value)
        {
            return new OrganizadorID(value);
        }

        public static implicit operator Guid(OrganizadorID cocineroID)
        {
            return cocineroID.value;
        }
    }
}

