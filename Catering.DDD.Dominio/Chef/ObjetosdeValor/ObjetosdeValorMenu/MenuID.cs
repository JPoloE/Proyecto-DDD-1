using Catering.DDD.Dominio.Comandos;
using System;
namespace Catering.DDD.Dominio.Menu.ObjetosdeValor.ObjetosdeValorMenu
{
	public class MenuID : Identidad
	{


		internal MenuID(Guid Id) : base(Id)
		{
	
		}

		public static MenuID Of(Guid menuID)
		{
			return new MenuID(menuID);
		}

	}
}

