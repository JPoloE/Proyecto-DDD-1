using System;
namespace Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero
{
    public record DatosPersonalesCocinero
    {
        public string Nombre { get; init; }
        public double Cedula { get; init; }
        public string Celular { get; init; }
        public string Experiencia { get; init; }
        public string Idiomas { get; init; }

        internal DatosPersonalesCocinero(string nombre, double cedula, string celular, string experiencia, string idiomas)
        {
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.Celular = celular;
            this.Experiencia = experiencia;
            this.Idiomas = idiomas;
        }

        public DatosPersonalesCocinero() { }

        public static DatosPersonalesCocinero Create(string nombre, double cedula, string celular, string experiencia, string idiomas)
        {
            validate(nombre);
            validate(celular);
            validate(experiencia);
            validate(idiomas);

            return new DatosPersonalesCocinero(nombre, cedula, celular, experiencia, idiomas);
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

