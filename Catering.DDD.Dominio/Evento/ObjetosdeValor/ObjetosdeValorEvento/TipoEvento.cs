using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;
using System;
namespace Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorEvento
{
	public record TipoEvento
	{
		public string Tipo { get; init; }

		internal TipoEvento(string tipoEvento)
		{
			this.Tipo = tipoEvento;
		}

		public TipoEvento() { }
        public static TipoEvento Create(string tipo)
        {
            validate(tipo);
            return new TipoEvento(tipo);
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

