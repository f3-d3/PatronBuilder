using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Alumno: Persona
    {
        private int NivelSocioEconomico { get; set; }
        public void SetNivelSocioEconomico(int nivel)
        {
            this.NivelSocioEconomico = nivel;
        }

        public int GetNivelSocioEconomico()
        {
            return this.NivelSocioEconomico;
        }
    }
}
