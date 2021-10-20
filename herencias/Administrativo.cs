using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencias
{
    class Administrativo : Persona
    {
        public string area { get; set; }
        private double pago = 500d;

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
            return base.consultar() + area;
        }
        public override string sueldo()
        {
            return base.sueldo() + pago;
        }

    }
}
