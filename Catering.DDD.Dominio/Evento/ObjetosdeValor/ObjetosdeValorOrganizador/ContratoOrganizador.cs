using System;

namespace Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorOrganizador
{
	public class ContratoOrganizador
	{
       public string TipoContrato { get; init; }
       public string FormaPago { get; init; }

        internal ContratoOrganizador(string tipoContrato, string formaPago)
        {
            this.TipoContrato = tipoContrato;
            this.FormaPago = formaPago;
        }
        public ContratoOrganizador() { }

        public static ContratoOrganizador Create(string tipoContrato, string formaPago)
        {
            validate(tipoContrato);
            validate(formaPago);
            return new ContratoOrganizador(tipoContrato, formaPago);
        }

        //Validación de los objetos de valor de organizador
        public static void validate(string s)
        {
            if (s == null)
            {
                throw new ArgumentException("El valor no puede ser nulo");
            }
        }
    }
}

