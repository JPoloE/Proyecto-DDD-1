using Catering.DDD.Dominio.Chef.Entidades;
using Catering.DDD.Dominio.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Eventos
{
    public class MenuAgregado : EventodeDominio
    {
        public Entidades.Menu Menu { get; set; }
        public MenuAgregado(Entidades.Menu menu) : base("Menu.Agregado")
        {
            Menu = menu;
        }
    }
}
