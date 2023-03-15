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
                        chef.SetContrato(contratoChef.ContratoChef);
                        break;
                    case EspecialidaddeChefAgregada especialidadChef:
                        chef.SetEspecialidad(especialidadChef.Especialidad);
                        break;
                    //Cocinero
                    case DatosPersonalesCocineroAgregados datosPersonalesCocinero:
                        chef.AgregarDatosPersonalesCocinero(datosPersonalesCocinero.DatosPersonales);
                        break;
                    case ContratoCocineroAgregado contratoCocinero:
                        chef.AgregarContratoCocinero(contratoCocinero.Contrato);
                        break;
                    case EspecialidadCocineroAgregada especialidadCocinero:
                        chef.AgregarEspecialidadCocinero(especialidadCocinero.Especialidad);
                        break;
                    //Menu
                    case PlatilloMenuAgregado platilloMenu:
                        chef.AgregarPlatilloMenu(platilloMenu.Platillo);
                        break;
                    case TipoMenuAgregado tipoMenu:
                        chef.AgregarTipoMenu(tipoMenu.Tipo);
                        break;
                }

            });
            return chef;
        }
    }
}
