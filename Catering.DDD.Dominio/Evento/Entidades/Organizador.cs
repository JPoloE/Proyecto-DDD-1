using System;
using Catering.DDD.Dominio.Comandos;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorOrganizador;

namespace Catering.DDD.Dominio.Evento.Entidades
{
	public class Organizador : Entidad<OrganizadorID>
	{
		public DatosPersonalesOrganizador DatosPersonales { get; private set; }
		public ContratoOrganizador Contrato { get; private set; }

		public Organizador(OrganizadorID id) : base(id)
		{

		}

		public void SetDatosPersonales(DatosPersonalesOrganizador datosPersonales)
		{
			DatosPersonales = datosPersonales;
		}
        public void SetDatosContrato(ContratoOrganizador contrato)
        {
            Contrato = contrato;
        }
    }
}

