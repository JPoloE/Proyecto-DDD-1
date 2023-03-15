using Ardalis.Specification.EntityFrameworkCore;
using CasosdeUso.DDD.Dominio.Gateways;
using Catering.DDD.Dominio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Catering.DDD.Infraestructura
{
    public class StoredEventRepository<T> : RepositoryBase<T>, IStoredEventRepository<T> where T : class
    {

        private readonly DataBaseContext dataBaseContext;
        public StoredEventRepository(DataBaseContext dbContext) : base(dbContext)
        {
            dataBaseContext = dbContext;
        }

        public async Task<List<StoredEvent>> GetEventsByAggregateId(string aggregateId)
        {
            return dataBaseContext.StoredEvents.Where(evento => evento.AggregateId == aggregateId).ToList();

        }
    }
}
