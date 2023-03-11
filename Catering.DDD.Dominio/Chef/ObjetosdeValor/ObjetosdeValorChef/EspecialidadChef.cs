using System;
namespace Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef
{
	public record EspecialidadChef
	{
		string Value { get; init; }

		internal EspecialidadChef(string value)
		{
			this.Value = value;
		}

        public static EspecialidadChef Create(string value)
        {
            validate(value);
            return new EspecialidadChef(value);
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

