using System;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorEvento;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorOrganizador;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorUbicacion;

namespace Catering.DDD.Dominio.Evento.Entidades
{
	public class Evento
	{
		public Guid Id { get; init; }
		public Fecha FechaEvento { get; private set; }
		public Tipo TipoEvento { get; private set; }
		public OrganizadorID OrganizadorID { get; private set; }
		public virtual Organizador Organizador { get; private set; }
		public UbicacionID UbicacionID { get; private set; }
		public virtual Ubicacion Ubicacion { get; private set; }

		public Evento(Guid id)
		{
			this.Id = id;
		}

		public void SetFechaEvento(Fecha fechaEvento)
		{
			FechaEvento = fechaEvento;
		}

		public void SetTipoEvento(Tipo tipoEvento)
		{
			TipoEvento = tipoEvento;
		}

		public void SetOrganizadorID(OrganizadorID organizadorID)
		{
			OrganizadorID = organizadorID;
		}

		public void SetOrganizador(Organizador organizador)
		{
			Organizador = organizador;
		}

        public void SetUbicacionID(UbicacionID ubicacionID)
        {
            UbicacionID = ubicacionID;
        }

        public void SetUbicacion(Ubicacion ubicacion)
        {
            Ubicacion = ubicacion;
        }
    }
}

