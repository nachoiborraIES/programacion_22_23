/*Programa que le pide al usuario dos números enteros 
  y muestra por pantalla la media de esas dos notas*/

using System;

class Practica_1_1_1
{
    static void Main()
	{
        
        int n1, n2, n3, suma, division;
        Console.WriteLine("Escribe un numero entero:");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe un numero entero:");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe un numero entero:");
        n3 = Convert.ToInt32(Console.ReadLine());
        suma = n1 + n2 + n3;
        division = suma / 3;
        
        Console.WriteLine("La media de estas notas es {0} ", division);
        
    }
}
