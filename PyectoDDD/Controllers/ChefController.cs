using CasosdeUso.DDD.Dominio.Gateways;
using Catering.DDD.Dominio.Chef.Comandos;
using Catering.DDD.Dominio.Chef.Entidades;
using Catering.DDD.Dominio.Evento.Comandos;
using Catering.DDD.Dominio.Evento.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace PyectoDDD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChefController : Controller
    {
        private readonly IChefCasodeUso _casoDeUso;


        public ChefController(IChefCasodeUso chefCasodeUso)
        {
            _casoDeUso = chefCasodeUso;
        }

        [HttpGet("{id}")]
        public async Task<Chef> Get(string id)
        {
            var chef = await _casoDeUso.BuscarChefPorID(id);
            return chef;
        }

        [HttpPost]
        public async Task<Chef> Post(CrearChefComando command)
        {
            var chefCreado = await _casoDeUso.CrearChef(command);
            return chefCreado;
        }

        [HttpPost("addMenu")]
        public async Task<Chef> AgregarMenu(AgregarMenuComando command)
        {
            var menuAgregado = await _casoDeUso.AgregarMenu(command);
            return menuAgregado;
        }

        [HttpPost("addCocinero")]
        public async Task<Chef> AgregarCocinero(AgregarCocineroComando command)
        {
            var cocineroAgregado = await _casoDeUso.AgregarCocinero(command);
            return cocineroAgregado;
        }

    }
}
