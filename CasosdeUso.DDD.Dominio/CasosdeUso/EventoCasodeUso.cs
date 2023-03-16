using CasosdeUso.DDD.Dominio.Gateways;
using Catering.DDD.Dominio.Comandos;
using Catering.DDD.Dominio.Evento.Comandos;
using Catering.DDD.Dominio.Evento.Entidades;
using Catering.DDD.Dominio.Evento.Eventos;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorEvento;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorOrganizador;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorUbicacion;
using Catering.DDD.Dominio.Generics;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasosdeUso.DDD.Dominio.CasosdeUso
{
    public class EventoCasodeUso : IEventoCasodeUso
    {
        private readonly IStoredEventRepository<StoredEvent> _storedEventRepository;

        public EventoCasodeUso(IStoredEventRepository<StoredEvent> eventoRepository)
        {
            _storedEventRepository = eventoRepository;
        }

        public async Task<Evento> BuscarEventoPorID(string eventoID)
        {
            var eventoChangeApply = new EventoChangeApply();
            var listaEventosdeDominio = await GetEventsByAggregateID(eventoID);
            var eventoId = EventoID.Of(Guid.Parse(eventoID));
            var eventoApply = eventoChangeApply.CreateAgregate(listaEventosdeDominio, eventoId);

            return eventoApply;
        }

        public async Task<Evento> CrearEvento(CrearEventoComando comando)
        {
            var evento = new Evento(EventoID.Of(Guid.NewGuid()));
            evento.AgregarEventoID(evento.Id);
            var fechaEvento = Fecha.Create(
                comando.FechaEvento
                );
            var tipo = TipoEvento.Create(
                comando.TipoEvento
                );
            var agregados = AgregadosID.Create(
                comando.ChefID
                );
            evento.AgregarFechaEvento(fechaEvento);
            evento.AgregarTipoEvento(tipo);
            evento.AgregarAgregadosEvento(agregados);
            List<EventodeDominio> eventodeDominios = evento.getUncommittedChanges();
            await SaveEvents(eventodeDominios);

            var eventoApply = new EventoChangeApply();
            evento = eventoApply.CreateAgregate(eventodeDominios, evento.Id);
            return evento;
        }

        public async Task<Evento> AgregarOrganizador(AgregarOrganizadorComando comando)
        {
            var eventoChangeApply = new EventoChangeApply();
            var listDomainEvents = await GetEventsByAggregateID(comando.EventoId);
            var eventoID = EventoID.Of(Guid.Parse(comando.EventoId));
            var eventoRebuild = eventoChangeApply.CreateAgregate(listDomainEvents, eventoID);

            var organizador = new Organizador(OrganizadorID.Of(Guid.NewGuid()));
            var datosPersonales = DatosPersonalesOrganizador.Create(
                comando.Nombre,
                comando.Cedula,
                comando.Celular,
                comando.Experiencia,
                comando.Idiomas
                );
            var contratoOrganizador = ContratoOrganizador.Create(
                comando.TipoContrato,
                comando.FormaPago
                );
            eventoRebuild.AgregarOrganizador(organizador);
            eventoRebuild.AgregarDatosPersonalesOrganizador(datosPersonales);
            eventoRebuild.AgregarContratoOrganizador(contratoOrganizador);
            List<EventodeDominio> eventosDeDominio = eventoRebuild.getUncommittedChanges();
            await SaveEvents(eventosDeDominio);

            eventoChangeApply = new EventoChangeApply();
            listDomainEvents = await GetEventsByAggregateID(comando.EventoId);
            eventoRebuild = eventoChangeApply.CreateAgregate(listDomainEvents, eventoID);

            return eventoRebuild;
        }

        public async Task<Evento> AgregarUbicacion(AgregarUbicacionComando comando)
        {
            var eventoChangeApply = new EventoChangeApply();
            var listDomainEvents = await GetEventsByAggregateID(comando.EventoId);
            var eventoID = EventoID.Of(Guid.Parse(comando.EventoId));
            var eventoRebuild = eventoChangeApply.CreateAgregate(listDomainEvents, eventoID);

            var ubicacion = new Ubicacion(UbicacionID.Of(Guid.NewGuid()));
            var descripcion = Descripcion.Create(
                comando.CapacidaddePersonas,
                comando.CapacidaddeMesas,
                comando.Electricidad,
                comando.AguaPotable
                );
            eventoRebuild.AgregarUbicacionEvento(ubicacion);
            eventoRebuild.AgregarDescripcionaUbicacion(descripcion);
            List<EventodeDominio> eventosDeDominio = eventoRebuild.getUncommittedChanges();
            await SaveEvents(eventosDeDominio);

            eventoChangeApply = new EventoChangeApply();
            listDomainEvents = await GetEventsByAggregateID(comando.EventoId);
            eventoRebuild = eventoChangeApply.CreateAgregate(listDomainEvents, eventoID);

            return eventoRebuild;
        }





        private async Task SaveEvents(List<EventodeDominio> list)
        {
            var array = list.ToArray();
            for (var index = 0; index < array.Length; index++)
            {
                var stored = new StoredEvent();
                stored.AggregateId = array[index].GetAggregateId();
                stored.StoredName = array[index].GetAggregate();
                switch (array[index])
                {
                    //Evento
                    case EventoCreado eventoCreado:
                        stored.EventBody = JsonConvert.SerializeObject(eventoCreado);
                        break;
                    case FechaEventoAgregada fechaEvento:
                        stored.EventBody = JsonConvert.SerializeObject(fechaEvento);
                        break;
                    case TipoEventoAgreagdo tipoEvento:
                        stored.EventBody = JsonConvert.SerializeObject(tipoEvento);
                        break;
                    case AgregadosdeEventosAgregados agregado:
                        stored.EventBody = JsonConvert.SerializeObject(agregado);
                        break;
                    //Organizador
                    case OrganizadorAgregado organizadorAgregado:
                        stored.EventBody = JsonConvert.SerializeObject(organizadorAgregado);
                        break;
                    case DatosPersonalesOrganizadorAgregado datosPersonalesOrganizador:
                        stored.EventBody = JsonConvert.SerializeObject(datosPersonalesOrganizador);
                        break;
                    case ContratoOrganizadorAgregado contratoOrganizador:
                        stored.EventBody = JsonConvert.SerializeObject(contratoOrganizador);
                        break;
                    //Ubucacion
                    case UbicacionAgregada ubicacionAgregada:
                        stored.EventBody = JsonConvert.SerializeObject(ubicacionAgregada);
                        break;
                    case DescripcionDeUbicacionAgregada descripcion:
                        stored.EventBody = JsonConvert.SerializeObject(descripcion);
                        break;
                }
                await _storedEventRepository.AddAsync(stored);
            }
            await _storedEventRepository.SaveChangesAsync();
        }

        public async Task<List<EventodeDominio>> GetEventsByAggregateID(string agregadoId)
        {
            var listadoStoredEvents = await _storedEventRepository.GetEventsByAggregateId(agregadoId);

            if (listadoStoredEvents == null)
                throw new ArgumentException("There isn't an aggregate with this id");

            return listadoStoredEvents.Select(ev =>
            {
                string nombre = $"Catering.DDD.Dominio.Evento.Eventos.{ev.StoredName}, Catering.DDD.Dominio";
                Type tipo = Type.GetType(nombre);
                EventodeDominio eventoParseado = (EventodeDominio)JsonConvert.DeserializeObject(ev.EventBody, tipo);
                return eventoParseado;

            }).ToList();
        }
    }
}
