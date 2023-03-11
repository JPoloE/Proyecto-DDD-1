using System;
namespace Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorUbicacion
{
	public record Descripcion
	{
		public int CapacidaddePersonas { get; init; }
		public string CapacidaddeMesas { get; init; }
		public string Electricidad { get; init; }
		public string AguaPotable { get; init; }

		internal Descripcion(int capacidaddePersonas, string capacidaddeMesas, string electricidad, string aguaPotable)
		{
			this.CapacidaddePersonas = capacidaddePersonas;
			this.CapacidaddeMesas = capacidaddeMesas;
			this.Electricidad = electricidad;
			this.AguaPotable = aguaPotable;
		}

		public static Descripcion Create(int capacidaddePersonas, string capacidaddeMesas, string electricidad, string aguaPotable)
		{
			validateInt(capacidaddePersonas);
			validateString(capacidaddeMesas);
			validateString(electricidad);
			return new Descripcion(capacidaddePersonas, capacidaddeMesas, electricidad, aguaPotable);
		}

        //Validación de los objetos de valor de evento
        public static void validateString(string s)
        {
            if (s == null)
            {
                throw new ArgumentException("El valor no puede ser nulo");
            }
        }

		public static void validateInt(int i)
		{
			if (i < 100)
			{
				throw new ArgumentException("El lugar no es lo suficiente mente grande para el tipo de eventos"); 
			}
		}
    }
}

