using System;
namespace Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorMenu
{
    public record Tipo
    {
        public string TipoMenu { get; init; }
        public string Detalles { get; init; }

        internal Tipo(string tipoMenu, string detalles)
        {
            this.TipoMenu = tipoMenu;
            this.Detalles = detalles;
        }

        public static Tipo Create(string tipoMenu, string detalles)
        {
            validate(tipoMenu);
            validate(detalles);
            return new Tipo(tipoMenu, detalles);
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

