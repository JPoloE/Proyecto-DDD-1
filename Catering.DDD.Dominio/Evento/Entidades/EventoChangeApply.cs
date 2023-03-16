using Catering.DDD.Dominio.Chef.Entidades;
using Catering.DDD.Dominio.Chef.Eventos;
using Catering.DDD.Dominio.Comandos;
using Catering.DDD.Dominio.Evento.Eventos;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorEvento;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorOrganizador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Evento.Entidades
{
    public class EventoChangeApply
    {
        public Evento CreateAgregate(List<EventodeDominio> ev, EventoID id)
        {
            Evento evento = new Evento(id);

            if (ev.Find(e => e.GetType() == typeof(OrganizadorAgregado)) is OrganizadorAgregado organizadorAgregadoEvent)
            {
                evento.SetOrganizador(organizadorAgregadoEvent.Organizador);
            }

            if (ev.Find(e => e.GetType() == typeof(UbicacionAgregada)) is UbicacionAgregada ubicacionAgregadoEvent)
            {
                evento.SetUbicacion(ubicacionAgregadoEvent.Ubicacion);
            }

            ev.ForEach(eventoo =>
            {
                switch (eventoo)
                {
                    //Evento
                    case FechaEventoAgregada fechaEvento:
                        evento.SetFechaEvento(fechaEvento.Fecha);
                        break;
                    case UbicacionAgregada ubicacion:
                        evento.SetUbicacion(ubicacion.Ubicacion);
                        break;
                    //Organizador
                    case DatosPersonalesOrganizadorAgregado datosPersonalesOrganizador:
                        evento.Organizador.SetDatosPersonales(datosPersonalesOrganizador.DatosPersonales);
                        break;
                    case ContratoOrganizadorAgregado contratoOrganizador:
                        evento.Organizador.SetDatosContrato(contratoOrganizador.Contrato);
                        break;
                    //Ubicacion
                    case DescripcionDeUbicacionAgregada descripcion:
                        evento.Ubicacion.SetDescripcion(descripcion.Descripcion);
                        break;
                }

            });
            return evento;
        }
    }
}
