/* Programa que solicita al usuario una altura y crea un triángulo 
 * con asteriscos */
using System;

class Practica1
{
    static void Main()
    {
        int altura, contadorEspacios, contadorAsteriscos;
        try
        {
            Console.WriteLine("Escribe la altura:");
            altura = Convert.ToInt32(Console.ReadLine());
            
            contadorAsteriscos = 1;
            contadorEspacios = altura - 1;
            if(altura < 0)
            {
                Console.WriteLine("Altura no válida");
            }
            else
            {
                for(int i = 0; i <= altura - 1; i++)
                {
                    for(int j = 1; j <= contadorEspacios; j++)
                    {
                        Console.Write(" ");
                    }
                    
                    for(int j = 1; j <= contadorAsteriscos + i; j++)
                    {
                        Console.Write("*");
                    }
                   
                    Console.WriteLine();
                    contadorAsteriscos++;
                    contadorEspacios--;
                }        
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Tiene que ser un número entero");
        }
    }
}
