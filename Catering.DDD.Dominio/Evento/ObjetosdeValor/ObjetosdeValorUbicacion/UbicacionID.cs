using System;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;
using Catering.DDD.Dominio.Comandos;

namespace Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorUbicacion
{
	public class UbicacionID : Identidad
	{

        internal UbicacionID(Guid value_) : base(value_)
        {
        }

        public static UbicacionID Of(Guid value)
        {
            return new UbicacionID(value);
        }
    }
}

