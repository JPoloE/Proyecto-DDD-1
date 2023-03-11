using Catering.DDD.Dominio.Encargado.ObjetosdeValor.ObjetosdeValorBarman;
using Catering.DDD.Dominio.Encargado.ObjetosdeValor.ObjetosdeValorMesero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Encargado.Repositorios
{
    internal interface IEncargadoRepository
    {
        Task CrearEncargado(Entidades.Encargado encargado);
        Task AgregarMesero(Entidades.Mesero mesero);
        Task AgregarBarman(Entidades.Barman barman);
        Task EliminarMesero(MeseroID meseroID);
        Task EliminarBarman(BarmanID barmanID);
    }
}
