﻿using Catering.DDD.Dominio.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Eventos
{
    public class ChefCreado : EventodeDominio
    {
        public String ChefID { get; init; }

        public ChefCreado(String chefID) : base("Chef.creado")
        {
            ChefID = chefID;
        }
    }
}
