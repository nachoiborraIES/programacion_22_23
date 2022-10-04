/*
 * Este programa dice si qué estación es en función de tres temperaturas dadas
 * por el usuario.
 */
using System;
class Practica
{
    static void Main()
    {
        int temp1, temp2, temp3;
        Console.WriteLine("Escribe tres temperaturas (en ºC)");
        temp1 = Convert.ToInt32(Console.ReadLine());
        temp2 = Convert.ToInt32(Console.ReadLine());
        temp3 = Convert.ToInt32(Console.ReadLine());
        if (temp1 >= 25 && temp2 >= 25 && temp3 >= 25)      
        {
            Console.WriteLine("Es verano.");
        }
        else if (temp1 < 15 && temp2 < 15 &&temp3 < 15)
        {
            Console.WriteLine("Es invierno");
        }
        else
        {
            Console.WriteLine("Es otoño o primavera");
        }
    }
}
