using System;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorUbicacion;

namespace Catering.DDD.Dominio.Evento.Entidades
{
	public class Ubicacion
	{
		public Guid Id { get; init; }
		public Descripcion Descripcion { get; private set; }

		public Ubicacion(Guid id)
		{
			this.Id = id;
		}

		public void SetDescripcion(Descripcion descripcion)
		{
			Descripcion = descripcion;
		}
	}
}

