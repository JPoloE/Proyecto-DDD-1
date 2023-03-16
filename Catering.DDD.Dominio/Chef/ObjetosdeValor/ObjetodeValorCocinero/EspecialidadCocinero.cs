using System;
namespace Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero
{
    public record EspecialidadCocinero
    {
        string Value { get; init; }

        internal EspecialidadCocinero(string value)
        {
            this.Value = value;
        }
        public EspecialidadCocinero() { }

        public static EspecialidadCocinero Create(string value)
        {
            validate(value);
            return new EspecialidadCocinero(value);
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

