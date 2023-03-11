using System;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorMenu;

namespace Catering.DDD.Dominio.Chef.Entidades
{
	public class Menu
	{
		public Guid Id { get; init; }
		public Platillo Platillo { get; private set; }
		public Tipo Tipo { get; private set; }

		public Menu(Guid id)
		{
			this.Id = id;
		}

		public void SetPlatillo(Platillo platillo)
		{
			this.Platillo = platillo;
		}

		public void SetTipo(Tipo tipo)
		{
			this.Tipo = tipo;
		}
	}
}

