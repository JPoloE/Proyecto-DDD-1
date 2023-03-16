using Catering.DDD.Dominio.Chef.Eventos;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef;
using Catering.DDD.Dominio.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Entidades
{
    public class ChefChangeApply
    {
        public Chef CreateAggregate(List<EventodeDominio> ev, ChefID id)
        {
            Chef chef = new Chef(id);

            if (ev.Find(e => e.GetType() == typeof(MenuAgregado)) is MenuAgregado menuAgregadoEvent)
            {
                chef.SetMenuAgregate(menuAgregadoEvent.Menu);
            }

            if (ev.Find(e => e.GetType() == typeof(CocineroAgregado)) is CocineroAgregado cocineroAgregadoEvent)
            {
                chef.AgregarCocineroAgregate(cocineroAgregadoEvent.Cocinero);
            }

            ev.ForEach(evento =>
            {
                switch (evento)
                {
                    //Chef
                    case DatosPersonalesdeChefAgregados datosPersonales:
                        chef.SetDatosPersonalesAgregate(datosPersonales.PersonalData);
                        break;
                    case ContratodeChefAgregado contratoChef:
                        chef.SetContratoAgregate(contratoChef.ContratoChef);
                        break;
                    case EspecialidaddeChefAgregada especialidadChef:
                        chef.SetEspecialidadAgregate(especialidadChef.Especialidad);
                        break;
                    //Cocinero
                    case DatosPersonalesCocineroAgregados datosPersonalesCocinero:
                        chef.Cocinero.SetDatosPersonales(datosPersonalesCocinero.DatosPersonales);
                        break;
                    case ContratoCocineroAgregado contratoCocinero:
                        chef.Cocinero.SetContrato(contratoCocinero.Contrato);
                        break;
                    case EspecialidadCocineroAgregada especialidadCocinero:
                        chef.Cocinero.SetEspecialidad(especialidadCocinero.Especialidad);
                        break;
                    //Menu
                    case PlatilloMenuAgregado platilloMenu:
                        chef.menu.SetPlatillo(platilloMenu.Platillo);
                        break;
                    case TipoMenuAgregado tipoMenu:
                        chef.menu.SetTipo(tipoMenu.Tipo);
                        break;
                }

            });
            return chef;
        }
    }
}
