using System;
namespace Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorMenu
{
    public record Platillo
    {
        public string NombrePlatillo { get; init; }
        public double Cantidad { get; init; }
        public string Restriccion { get; init; }
        public string Tipo { get; init; }

        internal Platillo(string nombrePlatillo, double cantidad, string restriccion, string tipo)
        {
            this.NombrePlatillo = nombrePlatillo;
            this.Cantidad = cantidad;
            this.Restriccion = restriccion;
            this.Tipo = tipo;
        }

        public Platillo() { }

        public static Platillo Create(string nombrePlatillo, double cantidad, string restriccion, string tipo)
        {
            validate(nombrePlatillo);
            validate(restriccion);
            validate(tipo);
            return new Platillo(nombrePlatillo, cantidad, restriccion, tipo);
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

