using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaEnUnSoloForm
{
    class Contacto
    {
        private string nombre;
        private string apellido;
        private string telefono;

        public Contacto(string nombre, string apellido, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
