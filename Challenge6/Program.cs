using Challenge6;
using Challenge6.Pila;


  Persona p1 = new Persona("pablo","12-09-2001"); //Persona.cs
CuentaCorriente c1 = new CuentaCorriente("peso argentino",p1,250.33); //CuentaCorriente.cs

//Console.WriteLine(c1.Propietario + " " + c1.Sueldo + " " + c1.Moneda); //CuentaCorrienteMetodos.cs y PersonaPartial.cs
/*
int numero = 5;
int numero2 = 8;
int numero3 = 10;
Stack<Object> pila = new Stack<Object>();
Pila.apilar(pila, p1);
Pila.apilar(pila, numero);
Pila.apilar(pila, c1);
Console.WriteLine(Pila.desapilar(pila));
Console.WriteLine(Pila.desapilar(pila));
Console.WriteLine(Pila.desapilar(pila));
Console.WriteLine("////////////////");
Stack<int> pilaNumero = new Stack<int>();
Pila.apilar(pilaNumero,numero);
Pila.apilar(pilaNumero,numero2);
Pila.apilar(pilaNumero,numero3);
Console.WriteLine(Pila.desapilar(pilaNumero));
Console.WriteLine(Pila.desapilar(pilaNumero));
Console.WriteLine(Pila.desapilar(pilaNumero));
*/
//Console.WriteLine(p1.esMayor());
/*
string palabra = "abecedario";
Console.WriteLine(palabra.primeraMitadString());
Console.WriteLine(palabra.segundaMitadString());

double numero = 9.99;
Console.WriteLine(numero.centavos());
Console.WriteLine(numero.parteEntera());
*/
int numero = 5;
numero.deUnoEnUno(20);

