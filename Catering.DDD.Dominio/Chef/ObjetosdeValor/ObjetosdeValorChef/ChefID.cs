using System;
namespace Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef
{
	public record ChefID
	{
		public Guid value { get; init; }

		internal ChefID(Guid value_)
		{
			value = value_;
		}

		public static ChefID Create(Guid value) {
			return new ChefID(value);
		}

		public static implicit operator Guid(ChefID chefID){
			return chefID.value;
		}
	}
}

