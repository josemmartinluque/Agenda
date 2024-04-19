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
        public DateTime FechaNacimiento { get; }
        public string Telefono { get; }
        public string? Observaciones { get; }
        public string? Imagen { get; }

        public Contacto(int id, string nombre, DateTime fechaNacimiento, string telefono, string observaciones, string? imagen)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.FechaNacimiento = fechaNacimiento;
            this.Telefono = telefono;
            this.Observaciones = observaciones;
            this.Imagen = imagen;
        }
    }
}
