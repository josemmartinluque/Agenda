using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contacto
    {
        public int Id { get; }
        public string Nombre { get; }
        public string FechaNacimiento { get; }
        public string Telefono { get; }
        public string Observaciones { get; }

        public Contacto(int id, string nombre, string fechaNacimiento, string telefono, string observaciones)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.FechaNacimiento = fechaNacimiento;
            this.Telefono = telefono;
            this.Observaciones = observaciones;
        }
    }
}
