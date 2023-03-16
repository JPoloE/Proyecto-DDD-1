using System;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef;
using Catering.DDD.Dominio.Comandos;

namespace Catering.DDD.Dominio.Chef.Entidades
{
	public class Cocinero : Entidad<CocineroID>
	{
        public DatosPersonalesCocinero DatosPersonales { get; private set; }
        public EspecialidadCocinero Especialidad { get; private set; }
        public ContratoCocinero Contrato { get; private set; }


        public Cocinero(CocineroID id) : base(id)
        {
  
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

    }
}

