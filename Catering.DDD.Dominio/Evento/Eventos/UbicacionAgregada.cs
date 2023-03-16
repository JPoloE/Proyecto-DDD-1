using Catering.DDD.Dominio.Chef.Entidades;
using Catering.DDD.Dominio.Comandos;
using Catering.DDD.Dominio.Evento.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Evento.Eventos
{
    public class UbicacionAgregada : EventodeDominio
    {
        public Ubicacion Ubicacion { get; set; }
        public UbicacionAgregada(Ubicacion ubicacion) : base("Ubicacion.Agregado")
        {
            this.Ubicacion = ubicacion;
        }
    }
}
