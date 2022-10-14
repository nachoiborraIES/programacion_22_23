/*
 * Programa que le pide al usuario la cantidad que quiere ahorrar
 * y le devuelve por pantalla el total ahorrado.
 */
 
using System;

class Practica_2_3_2
{
    static void Main()
    {
        int ahorros, ingreso, ingresoTotal = 0;

        Console.Write("Indica total a ahorrar: ");
        ahorros = Convert.ToInt32(Console.ReadLine());
        
        do
        {
            Console.Write("Indica la cantidad a ingresar: ");
            ingreso = Convert.ToInt32(Console.ReadLine());
            ingresoTotal = ingresoTotal + ingreso;
        }
        while(ingresoTotal < ahorros);
        ahorros = ingresoTotal;
        Console.WriteLine("ENHORABUENA! Has ahorrado {0}",
            +ahorros+" euros");
    }
}
