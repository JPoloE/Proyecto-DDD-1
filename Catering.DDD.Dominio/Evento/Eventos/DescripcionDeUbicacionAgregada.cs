using Catering.DDD.Dominio.Chef.Entidades;
using Catering.DDD.Dominio.Comandos;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorUbicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Evento.Eventos
{
    public class DescripcionDeUbicacionAgregada : EventodeDominio
    {
        public Descripcion Descripcion { get; set; }
        public DescripcionDeUbicacionAgregada(Descripcion descripcion) : base("Descripcion.Agregado")
        {
            this.Descripcion = descripcion;
        }
    }
}
