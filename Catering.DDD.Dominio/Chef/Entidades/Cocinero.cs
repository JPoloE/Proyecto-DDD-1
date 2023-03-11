using System;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef;

namespace Catering.DDD.Dominio.Chef.Entidades
{
	public class Cocinero
	{
        public Guid Id { get; init; }
        public DatosPersonalesCocinero DatosPersonales { get; private set; }
        public EspecialidadCocinero Especialidad { get; private set; }
        public ContratoCocinero Contrato { get; private set; }
        public ChefID chefID { get; private set; }
        public virtual Chef? chef { get; private set; }

        public Cocinero(Guid id)
        {
            this.Id = id;
        }

        public void SetDatosPersonales(DatosPersonalesCocinero datosPersonales)
        {
            this.DatosPersonales = datosPersonales;

        }

        public void SetEspecialidad(EspecialidadCocinero especialidad)
        {
            this.Especialidad = especialidad;
        }

        public void SetContrato(ContratoCocinero contrato)
        {
            this.Contrato = contrato;
        }

        public void SetChefID(ChefID chefID)
        {
            this.chefID = chefID;
        }

        public void SetChef(Chef chef)
        {
            this.chef = chef;
        }
    }
}

