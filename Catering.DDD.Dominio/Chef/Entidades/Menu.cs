using System;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorMenu;
using Catering.DDD.Dominio.Comandos;
using Catering.DDD.Dominio.Menu.ObjetosdeValor.ObjetosdeValorMenu;

namespace Catering.DDD.Dominio.Chef.Entidades
{
	public class Menu : Entidad<MenuID>
	{
		public Platillo Platillo { get; private set; }
		public Tipo Tipo { get; private set; }

		public Menu(MenuID id): base(id)
		{

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

