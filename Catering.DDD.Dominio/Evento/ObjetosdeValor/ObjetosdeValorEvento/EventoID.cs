using System;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;
using Catering.DDD.Dominio.Comandos;

namespace Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorEvento
{
	public class EventoID : Identidad
	{

        internal EventoID(Guid value_) : base(value_) 
        {

        }

        public static EventoID Of(Guid value)
        {
            return new EventoID(value);
        }

    }
}

