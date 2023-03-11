using System;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorOrganizador;

namespace Catering.DDD.Dominio.Evento.Entidades
{
	public class Organizador
	{
		public Guid Id { get; init; }
		public DatosPersonalesOrganizador DatosPersonales { get; private set; }
		public ContratoOrganizador contrato { get; private set; }

		public Organizador(Guid id)
		{
			this.Id = id;
		}

		public void SetDatosPersonales(DatosPersonalesOrganizador datosPersonales)
		{
			DatosPersonales = datosPersonales;
		}
	}
}

