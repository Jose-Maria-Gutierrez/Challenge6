using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6
{
    public static class extensiones
    {
        public static String primeraMitadString(this string palabra)
        {
            double mitadPri = (double)palabra.Length / 2;
            int mitad = (int) Math.Ceiling(mitadPri);

            return palabra.Substring(0, mitad);
        }
        public static String segundaMitadString(this string palabra)
        {
            double mitadPri = (double)palabra.Length / 2;
            int mitad = (int) Math.Ceiling(mitadPri);
            int cant = (int)Math.Floor(mitadPri);

            return palabra.Substring(mitad, cant);
        }

        public static bool esMayor(this Persona p)
        {
            return ( DateTime.Now.Year - int.Parse(p.devolverAnioString()) ) > 18;
        }

        public static void deUnoEnUno(this int num,int cant)
        {
            int i;
            for (i=num;i<=cant;i++)
            {
                Console.WriteLine(i);
            }
        }
        public static int centavos(this double num)
        {
            int numEntero = (int)num;
            double resta = Math.Round(num - numEntero,2);
            return (int)(resta * 100);
        }

        public static int parteEntera(this double num)
        {
            int numEntero = (int)num;
            return numEntero;
        }

        public static void mostrarLista<T>(this List<T> lista)
        {
            foreach (T item in lista)
            {
                Console.WriteLine(item);
            }
        }

    }
}
