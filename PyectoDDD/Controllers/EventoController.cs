using CasosdeUso.DDD.Dominio.Gateways;
using Catering.DDD.Dominio.Evento.Comandos;
using Catering.DDD.Dominio.Evento.Entidades;
using Microsoft.AspNetCore.Mvc;


namespace PyectoDDD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly IEventoCasodeUso _casoDeUso;

        public EventoController(IEventoCasodeUso eventoCasodeUso)
        {
            _casoDeUso = eventoCasodeUso;
        }

        [HttpGet("{id}")]
        public async Task<Evento> Get(string id)
        {
            var evento = await _casoDeUso.BuscarEventoPorID(id);
            return evento;
        }

        [HttpPost]
        public async Task<Evento> Post(CrearEventoComando command)
        {
            var eventoCreado = await _casoDeUso.CrearEvento(command);
            return eventoCreado;
        }

        [HttpPost("addOrganizador")]
        public async Task<Evento> AgregarOrganizador(AgregarOrganizadorComando command)
        {
            var organizadorAgregado = await _casoDeUso.AgregarOrganizador(command);
            return organizadorAgregado;
        }

        [HttpPost("addUbicacion")]
        public async Task<Evento> AgregarUbicacion(AgregarUbicacionComando command)
        {
            var ubicacionAgregada = await _casoDeUso.AgregarUbicacion(command);
            return ubicacionAgregada;
        }
    }
}
