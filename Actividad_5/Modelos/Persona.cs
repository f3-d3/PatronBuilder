
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Persona
    {
        private string Nombres { get; set; }
        public void SetNombres(string nombre)
        {
            this.Nombres = nombre;
        }

        public string GetNombres()
        {
            return this.Nombres;
        }

        private string Apellidos { get; set; }
        public void SetApellidos(string apellido)
        {
            this.Apellidos = apellido;
        }
        public string GetApellidos()
        {
            return this.Apellidos;
        }

        private string DUI { get; set; }
        public void SetDUI(string dui)
        {
            this.DUI = dui;
        }
        public string GetDUI()
        {
            return this.DUI;
        }

        private DateTime FechaNacimiento { get; set; }
        public void SetFechaNacimiento(DateTime fecha)
        {
            this.FechaNacimiento = fecha;
        }

        public DateTime GetFechaNacimiento()
        {
            return this.FechaNacimiento;
        }

        public void SetPersona(Persona persona)
        {
            this.Nombres = persona.Nombres;
            this.Apellidos = persona.Apellidos;
            this.DUI = persona.DUI;
            this.FechaNacimiento = persona.FechaNacimiento;
        }

    }
}
