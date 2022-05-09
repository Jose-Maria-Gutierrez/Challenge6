using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6
{
    public partial class CuentaCorriente
    {
        public String Moneda { get { return _moneda; } }
        public Persona Propietario { get { return _propietario; } }
        public double Sueldo { get { return _sueldo; } }

        public override string ToString()
        {
            return this.Propietario + " " + this.Sueldo + " " + this.Moneda;
        }
    }
}
