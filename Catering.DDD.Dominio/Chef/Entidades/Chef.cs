using System;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef;
using Catering.DDD.Dominio.Menu.ObjetosdeValor.ObjetosdeValorMenu;

namespace Catering.DDD.Dominio.Chef.Entidades
{
	public class Chef
	{
		public Guid Id { get; init; }
		public DatosPersonalesChef DatosPersonales { get; private set; }
		public EspecialidadChef Especialidad { get; private set; }
		public ContratoChef Contrato{ get; private set; }
		public MenuID menuID { get; private set; }
		public virtual List<Cocinero>? Cocineros { get; private set; }
		public virtual Menu menu { get; private set; }

        public Chef(Guid id)
		{
			this.Id = id;
		}

		public void SetDatosPersonales(DatosPersonalesChef datosPersonales)
		{
			this.DatosPersonales = datosPersonales;
		
		}

		public void SetEspecialidad(EspecialidadChef especialidad)
		{
			this.Especialidad = especialidad;
		}

		public void SetContrato(ContratoChef contrato)
		{
			this.Contrato = contrato;
		}

		public void AgregarCocinero(Cocinero cocinero)
		{
			this.Cocineros.Add(cocinero);
			
		}

		public void SetCocineros(List<Cocinero> cocineros)
		{
			this.Cocineros = cocineros;
		}

		public void SetMenuID(MenuID menuID)
		{
			this.menuID = menuID;
		}

		public void SetMenu(Menu menu)
		{
			this.menu = menu;
		}
		
	}
}

