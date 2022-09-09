using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Administrativo: Persona
    {
        private string Cargo { get; set; }
        public void SetCargo(string cargo)
        {
            this.Cargo = cargo;
        }

        public string GetCargo()
        {
            return this.Cargo;
        }
    }
}
