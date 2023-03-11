using System;
using Catering.DDD.Dominio.Evento.Entidades;

namespace Catering.DDD.Dominio.Evento.Respositorios
{
	public interface IEventoRepository
	{
		Task CrearEvento(Evento.Entidades.Evento evento);
        Task AgregarOrganizador(Organizador organizador);
        Task AgregarUbicacion(Ubicacion ubicacion);
        Task ActualizarOrganizador(Organizador organizador);
    }

}

