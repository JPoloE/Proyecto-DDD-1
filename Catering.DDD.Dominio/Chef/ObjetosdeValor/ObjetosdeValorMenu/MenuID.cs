using System;
namespace Catering.DDD.Dominio.Menu.ObjetosdeValor.ObjetosdeValorMenu
{
	public class MenuID
	{
		public Guid value { get; init; }

		internal MenuID(Guid value_)
		{
			value = value_;
		}

		public static MenuID Create(Guid menuID)
		{
			return new MenuID(menuID);
		}

		public static implicit operator Guid(MenuID menuID)
		{
			return menuID.value; 
		}
	}
}

