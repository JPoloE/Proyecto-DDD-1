﻿using System;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;

namespace Catering.DDD.Dominio.Encargado.ObjetosdeValor.ObjetosdeValorMesero
{
	public class DatosPersonalesMesero
	{
        public string Nombre { get; init; }
        public double Cedula { get; init; }
        public string Celular { get; init; }
        public string Experiencia { get; init; }
        public string Idiomas { get; init; }

        internal DatosPersonalesMesero(string nombre, double cedula, string celular, string experiencia, string idiomas)
        {
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.Celular = celular;
            this.Experiencia = experiencia;
            this.Idiomas = idiomas;
        }

        public static DatosPersonalesMesero Create(string nombre, double cedula, string celular, string experiencia, string idiomas)
        {
            validate(nombre);
            validate(celular);
            validate(experiencia);
            validate(idiomas);

            return new DatosPersonalesMesero(nombre, cedula, celular, experiencia, idiomas);
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
}

