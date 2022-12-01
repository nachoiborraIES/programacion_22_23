/* Programa que recoge un frase dada por el usuario y devuelve los nombres
 * propios separados por comas y ordenados alfabéticamente */

using System;
using System.Text;

class Practica
{
    static void Main()
    {
        Console.WriteLine("Escribe una frase");
        string texto = Console.ReadLine();
        string[] partes = texto.Split();
        int cantidad = 0, tam = 0;
        
        for (int i = 1; i < partes.Length; i++)
        {
            if (partes[i][0] >= 'A' && partes[i][0] <= 'Z')
            {
                tam++;
            }
        }
        
        if (tam > 0)
        {
            string[] propios = new string[tam];
            
            for (int i = 1; i < partes.Length; i++)
            {
                if (partes[i][0] >= 'A' && partes[i][0] <= 'Z')
                {
                    propios[cantidad] = partes[i];
                    cantidad++;
                }
            }
            
            Array.Sort(propios);
            
            Console.WriteLine(String.Join(",", propios));
        }
        
        else
        {
            Console.WriteLine("No hay nombres propios");
        }
    }
}
