using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencias
{
    class Docente : Persona
    {
        public string cargo { get; set; }
        public string horastrabajadas { get; set; }

        private double pago = 375.99d;

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
            return base.consultar() + cargo + " y ha trabajado: "+horastrabajadas+ " horas";
        }
        public override string sueldo()
        {
            return base.sueldo() + pago;
        }
    }
}
