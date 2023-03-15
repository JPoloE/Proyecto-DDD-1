using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorMenu;
using Catering.DDD.Dominio.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Eventos
{
    public class TipoMenuAgregado : EventodeDominio
    {
        public Tipo Tipo { get; set; }

        public TipoMenuAgregado(Tipo tipo) : base("tipomenu.agregado")
        {
            Tipo = tipo;
        }
    }
}
