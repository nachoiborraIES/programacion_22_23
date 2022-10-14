/* Programa que simula una hucha, le pide al usuario introducir el dinero
 * a ahorrar y va añadiendo el dinero que ingresa hasta llegar al objetivo */
using System;

class Practica2
{
    static void Main()
    {
        int ahorro, ingreso, sumaIngreso = 0;
        
        Console.WriteLine("Indica total a ahorrar:");
        ahorro = Convert.ToInt32(Console.ReadLine());
        
        do
        {
            Console.WriteLine("Indica la cantidad que ingresas:");
            ingreso = Convert.ToInt32(Console.ReadLine());
            sumaIngreso = ingreso + sumaIngreso;
        }
        while(sumaIngreso < ahorro);
        
        Console.WriteLine("ENHORABUENA! Has ahorrado {0} euros", sumaIngreso);
    }
}
