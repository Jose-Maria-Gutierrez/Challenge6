using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6.Pila
{
    public static class Pila
    {
        public static void encolar<T>(Stack<T> pila,T elementoPila)
        {
            pila.Push(elementoPila);
        }

        public static Object desencolar<T>(Stack<T> pila)
        {
            Object elementoPila = pila.Pop();
            return elementoPila;
        }

    }
}
