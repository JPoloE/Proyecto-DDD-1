using System;
using Catering.DDD.Dominio.Chef.Entidades;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetodeValorCocinero;

namespace Catering.DDD.Dominio.Chef.Repositorios
{
	public interface IChefRepository
	{
		Task CrearChef(Entidades.Chef chef);
		Task AgregarMenu(Chef.Entidades.Menu menu);
		Task AgregarCocinero(Cocinero cocinero);
		Task EliminarCocinero(CocineroID Id);
	}
}

