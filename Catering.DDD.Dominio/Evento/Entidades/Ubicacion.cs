using System;
using Catering.DDD.Dominio.Comandos;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorUbicacion;

namespace Catering.DDD.Dominio.Evento.Entidades
{
	public class Ubicacion : Entidad<UbicacionID>
	{
		public Descripcion Descripcion { get; private set; }

		public Ubicacion(UbicacionID id) : base(id)
		{

		}

		public void SetDescripcion(Descripcion descripcion)
		{
			Descripcion = descripcion;
		}
	}
}

