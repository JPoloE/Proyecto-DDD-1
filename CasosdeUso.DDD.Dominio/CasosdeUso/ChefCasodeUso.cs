using CasosdeUso.DDD.Dominio.Gateways;
using Catering.DDD.Dominio.Chef.Comandos;
using Catering.DDD.Dominio.Chef.Entidades;
using Catering.DDD.Dominio.Chef.Eventos;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorMenu;
using Catering.DDD.Dominio.Comandos;
using Catering.DDD.Dominio.Generics;
using Catering.DDD.Dominio.Menu.ObjetosdeValor.ObjetosdeValorMenu;
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
            var contratoChef = ContratoChef.Create(
                comando.TipoContrato,
                comando.FormaPago
                );
            var especialidadChef = EspecialidadChef.Create(
                comando.Especialidad
                );
            chef.SetDatosPersonales( datosPersonales );
            chef.SetContrato(contratoChef);
            chef.SetEspecialidad(especialidadChef);
            List<EventodeDominio> eventodeDominios = chef.getUncommittedChanges();
            await SaveEvents(eventodeDominios);

            var chefApply = new ChefChangeApply();
            chef = chefApply.CreateAggregate(eventodeDominios, chef.Id);
            return chef;
        }

        public async Task<Chef> AgregarCocinero(AgregarCocineroComando comando)
        {
            var chefChangeApply = new ChefChangeApply();
            var listDomainEvents = await GetEventsByAggregateID(comando.ChefId);
            var chefID = ChefID.Of(Guid.Parse(comando.ChefId));
            var chefRebuild = chefChangeApply.CreateAggregate(listDomainEvents, chefID);

            var cocinero = new Cocinero(CocineroID.Of(Guid.NewGuid()));
            var datosPersonales = DatosPersonalesCocinero.Create(
                comando.Nombre,
                comando.Cedula,
                comando.Celular,
                comando.Experiencia,
                comando.Idiomas
                );
            var contratoCocinero = ContratoCocinero.Create(
                comando.TipoContrato,
                comando.FormaPago
                );
            var especialidadCocinero = EspecialidadCocinero.Create(
                comando.Especialidad
                );
            chefRebuild.SetCocinero(cocinero);
            chefRebuild.AgregarDatosPersonalesCocinero(datosPersonales);
            chefRebuild.AgregarContratoCocinero(contratoCocinero);
            chefRebuild.AgregarEspecialidadCocinero(especialidadCocinero);
            List<EventodeDominio> eventosDeDominio = chefRebuild.getUncommittedChanges();
            await SaveEvents(eventosDeDominio);

            chefChangeApply = new ChefChangeApply();
            listDomainEvents = await GetEventsByAggregateID(comando.ChefId);
            chefRebuild = chefChangeApply.CreateAggregate(listDomainEvents, chefID);

            return chefRebuild;
        }

        public async Task<Chef> AgregarMenu(AgregarMenuComando comando)
        {
            var chefChangeApply = new ChefChangeApply();
            var listDomainEvents = await GetEventsByAggregateID(comando.ChefId);
            var chefID = ChefID.Of(Guid.Parse(comando.ChefId));
            var chefRebuild = chefChangeApply.CreateAggregate(listDomainEvents, chefID);

            var menu = new Menu(MenuID.Of(Guid.NewGuid()));
            var tipoMenu = Tipo.Create(
                comando.TipoMenu,
                comando.Detalles
                );
            var platillo = Platillo.Create(
                comando.NombrePlatillo,
                comando.Cantidad,
                comando.Restriccion,
                comando.TipoPlatillo
                );
            chefRebuild.SetMenu(menu);
            chefRebuild.AgregarTipoMenu(tipoMenu);
            chefRebuild.AgregarPlatilloMenu(platillo);
            List<EventodeDominio> eventosDeDominio = chefRebuild.getUncommittedChanges();
            await SaveEvents(eventosDeDominio);

            chefChangeApply = new ChefChangeApply();
            listDomainEvents = await GetEventsByAggregateID(comando.ChefId);
            chefRebuild = chefChangeApply.CreateAggregate(listDomainEvents, chefID);

            return chefRebuild;
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
                string nombre = $"Catering.DDD.Dominio.Chef.Eventos.{ev.StoredName}, Catering.DDD.Dominio";
                Type tipo = Type.GetType(nombre);
                EventodeDominio eventoParseado = (EventodeDominio)JsonConvert.DeserializeObject(ev.EventBody, tipo);
                return eventoParseado;

            }).ToList();
        }
    }
}
