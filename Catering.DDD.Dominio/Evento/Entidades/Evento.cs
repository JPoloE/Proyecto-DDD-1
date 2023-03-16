using System;
using Catering.DDD.Dominio.Chef.Eventos;
using Catering.DDD.Dominio.Chef.ObjetosdeValor.ObjetosdeValorChef;
using Catering.DDD.Dominio.Comandos;
using Catering.DDD.Dominio.Evento.Eventos;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorEvento;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorOrganizador;
using Catering.DDD.Dominio.Evento.ObjetosdeValor.ObjetosdeValorUbicacion;

namespace Catering.DDD.Dominio.Evento.Entidades
{
	public class Evento : AgregarEvento<EventoID>
	{
		public EventoID Id { get; init; }
		public Fecha FechaEvento { get; private set; }
		public TipoEvento TipoEvento { get; private set; }
        public AgregadosID AgregadosID { get; private set; }
		public virtual Organizador Organizador { get; private set; }
		public virtual Ubicacion Ubicacion { get; private set; }

		public Evento(EventoID id) : base(id)
		{
			Id = id;
		}

		//Evento
        public void AgregarEventoID(EventoID eventoID)
        {
            AppendChange(new EventoCreado(Id.ToString()));
        }
        public void AgregarFechaEvento(Fecha fecha)
        {
            AppendChange(new FechaEventoAgregada(fecha));
        }
        public void AgregarTipoEvento(TipoEvento tipo)
        {
            AppendChange(new TipoEventoAgreagdo(tipo));
        }
        public void AgregarAgregadosEvento(AgregadosID agregados)
        {
            AppendChange(new AgregadosdeEventosAgregados(agregados));
        }
		//Ubicacion
        public void AgregarUbicacionEvento(Ubicacion ubicacion)
        {
            AppendChange(new UbicacionAgregada(ubicacion));
        }
        public void AgregarDescripcionaUbicacion(Descripcion descripcion)
        {
            AppendChange(new DescripcionDeUbicacionAgregada(descripcion));
        }
        //Organizador
        public void AgregarOrganizador(Organizador organizador)
        {
            AppendChange(new OrganizadorAgregado(organizador));
        }
        public void AgregarDatosPersonalesOrganizador(DatosPersonalesOrganizador datosPersonales)
        {
            AppendChange(new DatosPersonalesOrganizadorAgregado(datosPersonales));
        }
        public void AgregarContratoOrganizador(ContratoOrganizador contrato)
        {
            AppendChange(new ContratoOrganizadorAgregado(contrato));
        }



        public void SetFechaEvento(Fecha fechaEvento)
		{
			FechaEvento = fechaEvento;
		}

		public void SetTipoEvento(TipoEvento tipoEvento)
		{
			TipoEvento = tipoEvento;
		}

		public void SetOrganizador(Organizador organizador)
		{
			Organizador = organizador;
		}

        public void SetUbicacion(Ubicacion ubicacion)
        {
            Ubicacion = ubicacion;
        }

        public void SetAgregados(AgregadosID agregados)
        {
            AgregadosID = agregados;
        }
    }
}

