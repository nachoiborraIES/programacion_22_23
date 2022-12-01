/*
 * Programa que saca por pantalla los nombres propios introducidos sin contar
 * la primera palabra de la frase
 * */

using System;

class Practica040302
{
    static void Main()
    {
        Console.WriteLine("Introduce una frase:");
        string frase = Console.ReadLine();
        string[] palabra = frase.Split(' ');
        string[] nPropios = new string[palabra.Length];
        int posicion = 0;
        
        // Buscar y pasar nombres propios a Array
        for (int i = 1; i < palabra.Length; i++)
        {
            if (palabra[i][0] >= 'A' && palabra[i][0] <= 'Z')
            {
                nPropios[posicion] = palabra[i];
                posicion++;
            }
        }
        
        // Ordenar alfabéticamente
        for (int i = 0; i < posicion; i++)
        {
            for (int j = 0; j < posicion - i -1; j++)
            {
                if (nPropios[j].ToLower()
                    .CompareTo(nPropios[j+1].ToLower()) > 0)
                {
                    string auxiliar = nPropios[j];
                    nPropios[j] = nPropios[j+1];
                    nPropios[j+1] = auxiliar;
                }
            }
        }
        
        // Mostrar nombres propios
        if (posicion > 0)
        {
            for (int j = 0; j < posicion-1; j++)
            {
                Console.Write(nPropios[j] + ",");
            }
            Console.Write(nPropios[posicion-1]);
        }
        else
        {
            Console.WriteLine("No se encontraron nombres propios.");
        }
    }
}
