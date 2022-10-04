/* Programa que a partir de tres temperaturas introducidas por el usuario dice
la estación del año en la que se encuentra */
using System;

class Estacion
{
    static void Main()
    {
        Console.WriteLine("Introduce tres temperaturas en ºC:");
        int temp1 = Convert.ToInt32(Console.ReadLine());
        int temp2 = Convert.ToInt32(Console.ReadLine());
        int temp3 = Convert.ToInt32(Console.ReadLine());
        
        if(temp1 >= 25 && temp2 >= 25 && temp3 >= 25)
        {
            Console.WriteLine("Es verano");
        }
        else if(temp1 < 15 && temp2 < 15 && temp3 < 15)
        {
            Console.WriteLine("Es invierno");
        }
        else
        {
            Console.WriteLine("Es otoño o primavera");
        }
    }
}
