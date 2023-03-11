using System;
namespace Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorEvento
{
	public record Tipo
	{
		public string TipoEvento { get; init; }

		internal Tipo(string tipoEvento)
		{
			validate(tipoEvento);
			this.TipoEvento = tipoEvento;
		}

		public static void validate(string tipo)
		{
			if (tipo == null)
			{
				throw new ArgumentNullException("El valor no puede ser nulo");
			}
		}
	}
}

