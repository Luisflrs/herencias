using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencias
{
    class PersonalLimpieza : Persona
    {
         public string turno { get; set; }
        private double pago = 249.99d;

        public double obtenerpago()
        {
            return pago;
        }
        public override string registrar()
        {
            return base.registrar();
        }
        public override string consultar()
        {
            return base.consultar() + " empleado de la limpieza, el turno que eligio es: " + turno;
        }
        public override string sueldo()
        {
            return base.sueldo() + pago;
        }


    }
}
