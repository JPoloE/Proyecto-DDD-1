using Catering.DDD.Dominio.Chef.Comandos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Builders.Chef
{
    public class CrearChefBuilder
    {
        private string Nombre { get; set; }
        private int Cedula { get; set; }
        private string Correo { get; set; }
        private string Experiencia { get; set; }
        private string Idiomas { get; set; }
        private string TipoContrato { get; set; }
        private string FormaPago { get; set; }
        private string Especialidad { get; set; }

        public CrearChefBuilder WithName(string nombre) 
        {
            Nombre = nombre;
            return this;
        }
        public CrearChefBuilder WithCedula(int cedula)
        {
            Cedula  = cedula;
            return this;
        }
        public CrearChefBuilder WithCorreo(string correo)
        {
            Correo = correo;
            return this;
        }
        public CrearChefBuilder WithExperiencia(string experiencia)
        {
            Experiencia = experiencia;
            return this;
        }
        public CrearChefBuilder WithIdiomas(string idiomas)
        {
            Idiomas = idiomas;
            return this;
        }
        public CrearChefBuilder WithContrato(string contrato)
        {
            TipoContrato = contrato;
            return this;
        }
        public CrearChefBuilder WithFormaPago(string formaPago)
        {
            FormaPago = formaPago;
            return this;
        }
        public CrearChefBuilder WithEspecialidad(string especialidad)
        {
            Especialidad = especialidad;
            return this;
        }

        public CrearChefComando Build()
        {
            return new CrearChefComando(Nombre,Cedula,Correo,Experiencia,Idiomas,TipoContrato,FormaPago,Especialidad);
        }
    }
}
