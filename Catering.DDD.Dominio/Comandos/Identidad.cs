using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Comandos
{
    public class Identidad
    {
        public Guid Uuid { get; set; }
        public Identidad(Guid uuid) 
        {
            if (uuid == Guid.Empty) 
            {
                throw new ArgumentException("El Id no puede ser vacio");
                this.Uuid = uuid;
            }
        }
    }
}
