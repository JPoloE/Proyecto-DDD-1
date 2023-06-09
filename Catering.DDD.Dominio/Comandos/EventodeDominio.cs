﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Comandos
{
    public class EventodeDominio
    {
        public string Type;
        public string AggregateId;
        public string Aggregate;
        private decimal VersionType;

        public EventodeDominio(string type) 
        {
            this.Type = type;
        }

        public string GetAggregateId() => AggregateId;

        public string GetAggregate() => Aggregate;

        public decimal GetVersionType() => VersionType;

        public void SetAggregateId(string aggregateId) => AggregateId = aggregateId;

        public void SetAggregate(string aggregate) => Aggregate = aggregate;

        public void SetVersionType(decimal versionType) => VersionType = versionType;


    }
}
