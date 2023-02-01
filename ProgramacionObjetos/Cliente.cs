using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionObjetos
{
    internal class Cliente
    {
        private string nombre;
        private string apellido;
        private string telefono;
        private string tarjetadecredito;

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Tarjetadecredito { get; set; }

        public string NombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }


        public override string ToString()
        {
            return NombreCompleto;
        }

    }
}
