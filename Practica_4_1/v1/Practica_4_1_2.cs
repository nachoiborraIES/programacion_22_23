/* Programa que crea una tabla de enteros introducidos por el usuario, calcula
 * la multiplicación de la diagonal principal y localiza en la tabla un numero 
 * dado por el usuario */

using System;

class Practica
{
    static void Main()
    {
        int tam, mult = 1, localizar;
        Console.WriteLine("Introduce el numero de filas y columnas:");
        tam = Convert.ToInt32(Console.ReadLine());
        
        int[,] tabla = new int[tam,tam];
        
        for (int i = 0; i < tabla.GetLength(0); i++)
        {
            for(int j = 0; j < tabla.GetLength(1); j++)
            {
                Console.Write("Casilla [{0}],[{1}]= ", i+1, j+1);
                tabla[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        for (int i = 0; i < tabla.GetLength(0); i++)
        {            
            mult = mult * tabla[i,i];
        }
        
        Console.WriteLine("La multiplicación de la diagonal da " + mult);
        
        Console.WriteLine("Introduce un numero de la tabla");
        localizar = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < tabla.GetLength(0); i++)
        {
            for(int j = 0; j < tabla.GetLength(1); j++)
            {
                if (tabla[i,j] == localizar)
                {
                    Console.WriteLine("Casilla [{0}],[{1}] ", i+1, j+1);
                }
            }
        }
        
    }
}
