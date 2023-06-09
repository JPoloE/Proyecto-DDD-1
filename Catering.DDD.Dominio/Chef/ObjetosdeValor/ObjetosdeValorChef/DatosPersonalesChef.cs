﻿using System;
namespace Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef
{
	public record DatosPersonalesChef
	{
		public string Nombre { get; init; }
		public double Cedula { get; init; }
		public string Celular { get; init; }
		public string Experiencia { get; init; }
		public string Idiomas { get; init; }
		public string Especialidad { get; init; }

		internal DatosPersonalesChef(string nombre, double cedula, string celular, string experiencia, string idiomas, string especialidad)
		{
			this.Nombre = nombre;
			this.Cedula = cedula;
			this.Celular = celular;
			this.Experiencia = experiencia;
			this.Idiomas = idiomas;
			this.Especialidad = especialidad;
		}
        public DatosPersonalesChef() { }

        public static DatosPersonalesChef Create(string nombre, double cedula, string celular, string experiencia, string idiomas,string especialidad)
		{
			validate(nombre);
			validate(celular);
			validate(experiencia);
			validate(idiomas);

			return new DatosPersonalesChef(nombre, cedula, celular, experiencia, idiomas, especialidad);
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

