using System;
namespace Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorEvento
{
	public class Fecha
	{
		public string FechaEvento { get; init; }

		internal Fecha(string fechaEvento)
		{
			this.FechaEvento = fechaEvento;
		}
		public Fecha() { }
		public static Fecha Create(string fechaEvento)
		{
			validate(fechaEvento);
			return new Fecha(fechaEvento);
		}

		public static void validate(string fechaEvento)
		{
			if (fechaEvento == null)
			{
				throw new ArgumentNullException("El valor no puede ser nulo");
			}
		}
	}
}

