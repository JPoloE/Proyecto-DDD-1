using System;
namespace Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef
{
	public record ContratoChef
	{
		string TipoContrato { get; init; }
		string FormaPago { get; init; }

		internal ContratoChef(string tipoContrato, string formaPago)
		{
			this.TipoContrato = tipoContrato;
			this.FormaPago = formaPago;
		}

		public static ContratoChef Create(string tipoContrato, string formaPago)
		{
			validate(tipoContrato);
			validate(formaPago);
			return new ContratoChef(tipoContrato, formaPago);
		}

        //Validación de los objetos de valor de chef
        public static void validate(string s)
        {
            if (s == null)
            {
                throw new ArgumentException("El valor no puede ser nulo");
            }
        }
    }
}

