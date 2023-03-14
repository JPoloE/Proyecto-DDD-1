using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering.DDD.Dominio.Chef.Comandos
{
    public class CrearChefComando
    {
        public string Nombre { get; set; }
        public int Cedula { get; set; }
        public string Correo { get; set; }
        public string Experiencia { get; set; }
        public string Idiomas { get; set; }
        public string Especialidad { get; set; }

        public CrearChefComando(string nombre, int cedula, string correo, string experiencia, string idiomas, string especialidad) 
        {
            Nombre = nombre;
            Cedula = cedula;
            Correo = correo;
            Experiencia = experiencia;
            Idiomas = idiomas;
            Especialidad = especialidad;
        }

    }
}
