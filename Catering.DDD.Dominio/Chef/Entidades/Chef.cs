using System;
using Catering.DDD.Dominio.Chef.Eventos;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorMenu;
using Catering.DDD.Dominio.Comandos;
using Catering.DDD.Dominio.Menu.ObjetosdeValor.ObjetosdeValorMenu;

namespace Catering.DDD.Dominio.Chef.Entidades
{
	public class Chef : AgregarEvento<ChefID>
	{
		public ChefID Id { get; init; }
		public DatosPersonalesChef DatosPersonales { get; private set; }
		public EspecialidadChef Especialidad { get; private set; }
		public ContratoChef Contrato{ get; private set; }
		public virtual Cocinero Cocinero { get; private set; }
		public virtual Menu menu { get; private set; }

        public Chef(ChefID id) : base(id)
		{
			this.Id = id;
		}

		//Chef
		public void SetChefID(ChefID chefID)
		{
			AppendChange(new ChefCreado(Id.ToString()));
		}
        public void SetDatosPersonales(DatosPersonalesChef datosPersonales) 
		{
			AppendChange(new DatosPersonalesdeChefAgregados(datosPersonales));
		}

		public void SetContrato(ContratoChef contratoChef) 
		{
			AppendChange(new ContratodeChefAgregado(contratoChef));
		}

        public void SetEspecialidad(EspecialidadChef especialidadChef)
        {
			AppendChange(new EspecialidaddeChefAgregada(especialidadChef));
        }

		//Menu

        public void SetMenu(Menu menu)
		{
			AppendChange(new MenuAgregado(menu));
		}

		public void AgregarPlatilloMenu(Platillo platillo)
		{
			AppendChange(new PlatilloMenuAgregado(platillo));
		}

		public void AgregarTipoMenu(Tipo tipo)
		{
			AppendChange(new TipoMenuAgregado(tipo));
		}
        //Cocinero
        public void SetCocinero(Cocinero cocinero)
        {
            AppendChange(new CocineroAgregado(cocinero));
        }
        public void AgregarDatosPersonalesCocinero(DatosPersonalesCocinero datosPersonales)
		{
			AppendChange(new DatosPersonalesCocineroAgregados(datosPersonales));
		}

		public void AgregarEspecialidadCocinero(EspecialidadCocinero especialidad)
		{
			AppendChange(new EspecialidadCocineroAgregada(especialidad));
		}

		public void AgregarContratoCocinero(ContratoCocinero contrato)
		{
			AppendChange(new ContratoCocineroAgregado(contrato));
		}


		//chef
        public void SetDatosPersonalesAgregate(DatosPersonalesChef datosPersonales)
		{
			this.DatosPersonales = datosPersonales;
		}

		public void SetEspecialidadAgregate(EspecialidadChef especialidad)
		{
			this.Especialidad = especialidad;
		}

		public void SetContratoAgregate(ContratoChef contrato)
		{
			this.Contrato = contrato;
		}
		//Cocinero
		public void AgregarCocineroAgregate(Cocinero cocinero)
		{
			this.Cocinero = cocinero;
		}

		public void SetMenuAgregate(Menu menu)
		{
			this.menu = menu;
		}
		
	}
}