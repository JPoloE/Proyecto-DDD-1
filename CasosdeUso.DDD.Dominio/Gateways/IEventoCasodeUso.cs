using Catering.DDD.Dominio.Evento.Comandos;
using Catering.DDD.Dominio.Evento.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasosdeUso.DDD.Dominio.Gateways
{
    public interface IEventoCasodeUso
    {
        Task<Evento> CrearEvento(CrearEventoComando comando);
        Task<Evento> AgregarOrganizador(AgregarOrganizadorComando comando);
        Task<Evento> AgregarUbicacion(AgregarUbicacionComando comando);
        Task<Evento> BuscarEventoPorID(string eventoID);
    }
}
