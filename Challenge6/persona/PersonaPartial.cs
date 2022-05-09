using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6
{
    public partial class Persona
    {
        public String Nombre { get { return _nombre; } }
        public String Fecha { get { return _fecha.ToString("dd MMMM yyyy"); } }

        public String devolverAnioString()
        {
            return _fecha.ToString("yyyy");
        }

        public override string ToString()
        {
            return "nombre: " + Nombre + " fecha: " + Fecha;
        } 

    }
}
