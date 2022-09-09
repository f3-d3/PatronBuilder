using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Docente: Persona
    {
        private string TituloAcademico { get; set; }
        public void SetTituloAcademico(string titulo)
        {
            this.TituloAcademico = titulo;
        }

        public string GetTituloAcademico()
        {
            return this.TituloAcademico;
        }
    }
}
