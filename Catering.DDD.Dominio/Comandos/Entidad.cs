using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Comandos
{
    public class Entidad<T> where T : Identidad
    {
        protected T EntitadId;

        public Entidad(T entidadId)
        {
            this.EntitadId = entidadId;
        }

        public T Identidad() => EntitadId;

    }
}
