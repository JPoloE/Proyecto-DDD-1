using System;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef;
using Catering.DDD.Dominio.Comandos;

namespace Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero
{
	public class CocineroID : Identidad
	{

        internal CocineroID(Guid id) : base(id) { }

        public static CocineroID Of(Guid id)
        {
            return new CocineroID(id);
        }

    }
}

