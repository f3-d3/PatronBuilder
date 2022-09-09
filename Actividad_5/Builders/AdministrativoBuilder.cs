using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejadores51
{
    public class AdministrativoBuilder : IBuilder
    {
        private Administrativo Administrativo { get; set; }

        public void Crear(Persona persona, string[] datos)
        {
            Administrativo = new Administrativo();
            Administrativo.SetPersona(persona);
            Administrativo.SetCargo(datos[0]);
        }

        public Administrativo GetElemento()
        {
            return Administrativo;
        }
    }
}
