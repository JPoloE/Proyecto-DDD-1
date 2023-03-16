using Catering.DDD.Dominio.Comandos;
using System;
namespace Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef
{
	public class ChefID : Identidad
	{
	
		public ChefID(Guid id) : base(id){}

		public static ChefID Of(Guid id) 
		{
			return new ChefID(id);
		}

	}
}

