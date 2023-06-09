﻿using Ardalis.Specification;
using Catering.DDD.Dominio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasosdeUso.DDD.Dominio.Gateways
{
    public interface IStoredEventRepository<T> : IRepositoryBase<T> where T : class
    {
        Task<List<StoredEvent>> GetEventsByAggregateId(string aggregateId);
    }
}
