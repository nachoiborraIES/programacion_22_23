/*Programa que escribe los 10 números posteriores y 5 anteriores
 * de un número introducido por el usuario.*/

using System;

class Ejercicio
{
    static void Main()
    {
        int num;
        Console.WriteLine("Escribe un número: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("10 números siguientes: ");
        for (int i = 1;i<=10;i++)
        {
            Console.Write(num + i); 
            if (i <10)
                Console.Write(",");
        }
        Console.WriteLine();
        Console.Write("5 números anteriores: ");
        for (int i = -1;i>=-5;i--)
        {
            Console.Write(num + i);
            if (i>-5)
                Console.Write(",");
        }
    }
}
