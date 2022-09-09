using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejadores51
{
    public class AlumnoBuilder: IBuilder
    {
        private Alumno Estudiante { get; set; }

        public void Crear(Persona persona, string[] datos)
        {
            var nivel = 1;
            Int32.TryParse(datos[3], out nivel);

            Estudiante = new Alumno();
            Estudiante.SetPersona(persona);
            Estudiante.SetNivelSocioEconomico(nivel);
        }

        public Alumno GetElemento()
        {
            return Estudiante;
        }
    }
}
