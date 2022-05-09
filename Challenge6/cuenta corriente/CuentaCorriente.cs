using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6
{
    public partial class CuentaCorriente
    {
        private String _moneda;
        private Persona _propietario;
        private double _sueldo;

        public CuentaCorriente(string moneda, Persona propietario,double sueldo)
        {
            this._moneda = moneda;
            this._propietario = propietario;
            this._sueldo = sueldo;
        }

    }
}
