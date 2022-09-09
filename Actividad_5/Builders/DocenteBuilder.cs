using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejadores51
{
    public class DocenteBuilder: IBuilder
    {
        private Docente Docente { get; set; }

        public void Crear(Persona persona, string[] datos)
        {
            Docente = new Docente();
            Docente.SetPersona(persona);
            Docente.SetTituloAcademico(datos[0]);
        }

        public Docente GetElemento()
        {
            return Docente;
        }
    }
}
