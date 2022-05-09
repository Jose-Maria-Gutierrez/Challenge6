using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6
{
    public partial class Persona
    {
        private String _nombre;
        private DateTime _fecha;
        private static String patron = "dd-MM-yyyy";
        
        public Persona(String nombre,String fechaNacimiento)
        {
            this._nombre = nombre;
            DateTime.TryParseExact(fechaNacimiento,patron,null,System.Globalization.DateTimeStyles.None,out this._fecha);
        }

    }
}
