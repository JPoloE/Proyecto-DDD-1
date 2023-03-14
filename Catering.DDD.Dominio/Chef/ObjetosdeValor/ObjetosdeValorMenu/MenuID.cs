using Catering.DDD.Dominio.Comandos;
using System;
namespace Catering.DDD.Dominio.Menu.ObjetosdeValor.ObjetosdeValorMenu
{
	public class MenuID : Identidad
	{
		public Guid value { get; init; }

		internal MenuID(Guid value_) : base(value_)
		{
	
		}

		public static MenuID Of(Guid menuID)
		{
			return new MenuID(menuID);
		}

	}
}

