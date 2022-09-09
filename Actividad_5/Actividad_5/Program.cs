using Manejadores51;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad51
{
    class Program
    {
        static void Main(string[] args)
        {
            /*IGeneric<Docente> _msd = new ManejadorPersona<Docente>();
            IGeneric<Administrativo> _msa = new ManejadorPersona<Administrativo>();
            IGeneric<Alumno> _mse = new ManejadorPersona<Alumno>();

            var docente = _msd.Create<Docente>(new { Nombre = "Docenre Pablo" });
            var admins = _msa.Create<Administrativo>(new { Nombre = "Adminis Pablo" });
            var estu = _mse.Create<Alumno>(new { Nombre = "Estudia Pablo" });

            Console.WriteLine(docente.Nombres);
            Console.WriteLine(admins.Nombres);
            Console.WriteLine(estu.Nombres);
            ;*/

            AlumnoBuilder builderE = new AlumnoBuilder();
            Director directorE = new Director(builderE);            
            directorE.Crear(DateTime.Now, "Alumno", "Valdivieso", "1102236859", "2" );
            Alumno estudiante = builderE.GetElemento();
            ;

            DocenteBuilder builderD = new DocenteBuilder();
            Director directorD = new Director(builderD);
            directorD.Crear(DateTime.Now, "Docente", "Valdivieso", "1102236859", "2");
            Docente docente = builderD.GetElemento();
            ;

            AdministrativoBuilder builderA = new AdministrativoBuilder();
            Director director = new Director(builderA);
            director.Crear(DateTime.Now, "Administrativo", "Valdivieso", "1102236859", "2");
            Administrativo administrativo = builderA.GetElemento();
        }
    }
}
