using Catering.DDD.Dominio.Comandos;
using System;
namespace Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorOrganizador
{
	public class OrganizadorID : Identidad
	{

        internal OrganizadorID(Guid value_) : base(value_)
        {

        }

        public static OrganizadorID Of(Guid value)
        {
            return new OrganizadorID(value);
        }

    }
}

