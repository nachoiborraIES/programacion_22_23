/*
 * Programa que le pide un valor h al usuario y le devuelve
 * una piramide o un mensaje un mensaje de error si el formato de h 
 * no es valido.
 */
 
using System;

class Practica_2_3_1
{
    static void Main()
    {
        int h, espacios, asteriscos;
        try
        {
            Console.Write("Introduce la altura: ");
            h = Convert.ToInt32(Console.ReadLine());
            if(h < 0)
            {
                throw new FormatException("Altura no válida");
            }
            for (int i = 1; i <= h; i++)
            {
                int altura = i * 2;
                for (espacios = 1; espacios <=h-i; espacios++)
                {
                    Console.Write(" ");
                }
                for (asteriscos = 0; asteriscos <altura-1; asteriscos++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

