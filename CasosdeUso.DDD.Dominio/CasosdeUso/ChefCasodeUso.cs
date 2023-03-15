using CasosdeUso.DDD.Dominio.Gateways;
using Catering.DDD.Dominio.Chef.Comandos;
using Catering.DDD.Dominio.Chef.Entidades;
using Catering.DDD.Dominio.Chef.Eventos;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef;
using Catering.DDD.Dominio.Comandos;
using Catering.DDD.Dominio.Generics;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasosdeUso.DDD.Dominio.CasosdeUso
{
    public class ChefCasodeUso : IChefCasodeUso
    {
        private readonly IStoredEventRepository<StoredEvent> _storedEventRepository;

        public ChefCasodeUso(IStoredEventRepository<StoredEvent> chefRepository)
        {
            _storedEventRepository = chefRepository;
        }
        public async Task<Chef> BuscarChefPorID(string chefID)
        {
            var chefChangeApply = new ChefChangeApply();
            var listaEventosdeDominio = await GetEventsByAggregateID(chefID);
            var chefId = ChefID.Of(Guid.Parse(chefID));
            var chefApply = chefChangeApply.CreateAggregate(listaEventosdeDominio, chefId);

            return chefApply;
        }

        public async Task<Chef> CrearChef(CrearChefComando comando)
        {
            var chef = new Chef(ChefID.Of(Guid.NewGuid()));
            chef.SetChefID(chef.Id);
            var datosPersonales = DatosPersonalesChef.Create(
                comando.Nombre,
                comando.Cedula,
                comando.Correo,
                comando.Experiencia,
                comando.Idiomas,
                comando.Especialidad
                );
            chef.SetDatosPersonales( datosPersonales );
            List<EventodeDominio> eventodeDominios = chef.getUncommittedChanges();
            await SaveEvents(eventodeDominios);

            var chefApply = new ChefChangeApply();
            chef = chefApply.CreateAggregate(eventodeDominios, chef.Id);
            return chef;
        }

        public Task<Chef> AgregarCocinero(AgregarCocineroComando comando)
        {
            throw new NotImplementedException();
        }

        public Task<Chef> AgregarMenu(AgregarMenuComando comando)
        {
            throw new NotImplementedException();
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
                    //Chef
                    case ChefCreado chefCreado:
                        stored.EventBody = JsonConvert.SerializeObject(chefCreado);
                        break;
                    case DatosPersonalesdeChefAgregados datosPersonales:
                        stored.EventBody = JsonConvert.SerializeObject(datosPersonales);
                        break;
                    case ContratodeChefAgregado contratoChef:
                        stored.EventBody = JsonConvert.SerializeObject(contratoChef);
                        break;
                    case EspecialidaddeChefAgregada especialidadChef:
                        stored.EventBody = JsonConvert.SerializeObject(especialidadChef);
                        break;
                    //Cocinero
                    case CocineroAgregado cocineroAgregado:
                        stored.EventBody = JsonConvert.SerializeObject(cocineroAgregado);
                        break;
                    case DatosPersonalesCocineroAgregados datosPersonalesCocinero:
                        stored.EventBody = JsonConvert.SerializeObject(datosPersonalesCocinero);
                        break;
                    case ContratoCocineroAgregado contratoCocinero:
                        stored.EventBody = JsonConvert.SerializeObject(contratoCocinero);
                        break;
                    case EspecialidadCocineroAgregada especialidadCocinero:
                        stored.EventBody = JsonConvert.SerializeObject(especialidadCocinero);
                        break;
                    //Menu
                    case MenuAgregado menuAgregado:
                        stored.EventBody = JsonConvert.SerializeObject(menuAgregado);
                        break;
                    case PlatilloMenuAgregado platilloMenu:
                        stored.EventBody = JsonConvert.SerializeObject(platilloMenu);
                        break;
                    case TipoMenuAgregado tipoMenu:
                        stored.EventBody = JsonConvert.SerializeObject(tipoMenu);
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
                string nombre = $"VirtualEducation.DDD.Domain.Student.Events.{ev.StoredName}, VirtualEducation.DDD.Domain";
                Type tipo = Type.GetType(nombre);
                EventodeDominio eventoParseado = (EventodeDominio)JsonConvert.DeserializeObject(ev.EventBody, tipo);
                return eventoParseado;

            }).ToList();
        }
    }
}
