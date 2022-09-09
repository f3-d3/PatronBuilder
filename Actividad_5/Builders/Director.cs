using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejadores51
{
    public class Director
    {
        private IBuilder _builder { get; set; }

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void Crear( DateTime fecha, params string[] datos)
        {
            Persona persona = new Persona();
            persona.SetNombres(datos[0]);
            persona.SetApellidos(datos[1]);
            persona.SetDUI(datos[2]);
            persona.SetFechaNacimiento(fecha);
            _builder.Crear(persona, datos);
        }

    }
}
