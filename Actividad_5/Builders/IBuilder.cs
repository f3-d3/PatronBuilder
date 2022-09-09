using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejadores51
{
    public interface IBuilder
    {
        void Crear(Persona persona, params string[] datos);

    }
}
