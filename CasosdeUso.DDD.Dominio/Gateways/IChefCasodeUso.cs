using Catering.DDD.Dominio.Chef.Comandos;
using Catering.DDD.Dominio.Chef.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasosdeUso.DDD.Dominio.Gateways
{
    public interface IChefCasodeUso
    {
        Task<Chef> CrearChef(CrearChefComando comando);
        Task<Chef> AgregarMenu(AgregarMenuComando comando);
        Task<Chef> AgregarCocinero(AgregarCocineroComando comando);
        Task<Chef> BuscarChefPorID(string chefID);
    }
}
