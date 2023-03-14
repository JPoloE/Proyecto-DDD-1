using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorMenu;
using Catering.DDD.Dominio.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Eventos
{
    public class PlatilloMenuAgregado : EventodeDominio
    {
        public Platillo Platillo { get; set; }

        public PlatilloMenuAgregado(Platillo platillo) : base("platillo.agregado")
        {
            Platillo = platillo;
        }
    }
}
