/* Programa que crea un array bidimensional del tamaño introducido y muestre la
 * posición del valor buscado por el usuario y la multiplicacion de la diagonal
 * del array
 * */
using System;

class Practica040102
{
    static void Main()
    {
        int n, valorBuscar, diagonal = 0;
        
        // Relleno de array
        Console.WriteLine("Introduce el número de filas y columnas:");
        n = Convert.ToInt32(Console.ReadLine());
        
        int[,] numeros = new int[n, n];
        
        Console.WriteLine("Rellena los valores de la tabla:");
        for(int i = 0; i < numeros.GetLength(0); i++)
        {
            for(int j = 0; j < numeros.GetLength(1); j++)
            {
                Console.WriteLine("Fila {0}, Columna {1}. ", i+1, j+1);
                numeros[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        // Búsqueda en array
        Console.WriteLine("¿Que valor deseas buscar?:");
        valorBuscar = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("El valor se encuentra en:");
        for(int i = 0; i < numeros.GetLength(0); i++)
        {
            for(int j = 0; j < numeros.GetLength(1); j++)
            {
                if (numeros[i, j] == valorBuscar)
                {
                    Console.WriteLine("Fila {0}, Columna {1}. ", i+1, j+1); 
                }
            }
        }
        
        // Multiplicación diagonal principal
        Console.WriteLine();
        diagonal = numeros[0, 0];
        for (int i = 1; i < numeros.GetLength(0); i++)
        {
            diagonal = diagonal * numeros[i, i];
        }
        
        Console.WriteLine("Multiplicación diagonal principal: " + diagonal);
    }
}
