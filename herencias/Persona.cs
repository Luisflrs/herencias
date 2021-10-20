using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencias
{
    class Persona
    {
        public string nombre { get; set; }

        public virtual string registrar()
        {
            return "Bienvenido: " + nombre;
        }
        public virtual string consultar()
        {
            return "Su cargo es: ";
        }

        public virtual string sueldo()
        {
            return "Su sueldo es de: ";
        }

    }
}
