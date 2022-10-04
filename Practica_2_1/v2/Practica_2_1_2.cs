/* Programa que pide un número al usuario y muestra mensaje por pantalla según
el número introducido */
using System;

class Password
{
    static void Main()
    {
        Console.WriteLine("Introduce el código numérico:");
        int password = Convert.ToInt32(Console.ReadLine());
        
        if(password == 5678 || password == 8765)
        {
            Console.WriteLine("Hola, señor.");
        }
        else if(password == 1234 || password == 4321)
        {
            Console.WriteLine("Hola, señora.");
        }
        else
        {
            Console.WriteLine("Código no identificado");
        }
    }
}
