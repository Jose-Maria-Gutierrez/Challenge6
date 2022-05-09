using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6.Pila
{
    public static class Pila
    {
        public static void apilar<T>(Stack<T> pila,T elementoPila)
        {
            pila.Push(elementoPila);
        }

        public static T desapilar<T>(Stack<T> pila)
        {
            return pila.Pop();
        }

    }
}
