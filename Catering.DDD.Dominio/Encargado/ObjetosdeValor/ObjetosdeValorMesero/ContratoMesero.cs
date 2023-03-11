using System;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;

namespace Catering.DDD.Dominio.Encargado.ObjetosdeValor.ObjetosdeValorMesero
{
	public record ContratoMesero
	{
        string TipoContrato { get; init; }
        string FormaPago { get; init; }

        internal ContratoMesero(string tipoContrato, string formaPago)
        {
            this.TipoContrato = tipoContrato;
            this.FormaPago = formaPago;
        }

        public static ContratoMesero Create(string tipoContrato, string formaPago)
        {
            validate(tipoContrato);
            validate(formaPago);
            return new ContratoMesero(tipoContrato, formaPago);
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

