/* Programa que pide unos valores al usuario, calcula la diferencia entre
 * el máximo y el mínimo, el beneficio máximo y el número de mínimos locales
 * que hay en el array */

using System;

class Practica
{
    static void Main()
    {
        int tam, minLocal = 0;
        Console.WriteLine("Introduce el número de acciones");
        tam = Convert.ToInt32(Console.ReadLine());
        
        float[] acciones = new float[tam];
        
        float max, min, beneficioMax;
        
        for (int i = 0; i < acciones.Length; i++)
        {
            Console.Write("Acción {0}: ", i+1);
            acciones[i] = Convert.ToSingle(Console.ReadLine());
        }
        
        max = acciones[0];
        min = acciones[0];
        
        for (int i = 1; i < acciones.Length; i++)
        {
            if (acciones[i] > max)
            {
                max = acciones[i];
            }
            
            else if (acciones[i] < min)
            {
                min = acciones[i];
            }
        }
        
        for (int i = 1; i < acciones.Length - 1; i++)
        {
            if (acciones[i] < acciones[i-1] && acciones[i] < acciones[i+1])
            {
                minLocal++;
            }
        }
        
        beneficioMax = max * 100 / acciones[0] - 100;
        
        Console.WriteLine("Diferencia: " + (max - min));
        Console.WriteLine("Beneficio máximo: {0}%",beneficioMax.ToString("N2"));
        Console.WriteLine("Mínimos locales: " + minLocal);
        
    }
}
