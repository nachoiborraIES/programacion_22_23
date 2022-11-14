/* Almacenamos en un array los valores dados por el usuario y mostramos el
 * resultado de una serie de operaciones por pantalla. 
 * */
using System; 

class Practica040101
{
    static void Main()
    {
        float maximo = 0, minimo = 0, rango, beneficio, contMinLocal = 0;
        int der, iz;
        
        Console.WriteLine("Introduce la cantidad de valores:");
        int val = Convert.ToInt32(Console.ReadLine());
        
        float[] numeros = new float[val];
        
        Console.WriteLine();
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Valor {0}: ", i+1);
            numeros[i] = Convert.ToSingle(Console.ReadLine());
        }
        
        maximo = numeros[0];
        minimo = numeros[0];
        
        for (int j = 0; j < numeros.Length; j++)
        {
            if (numeros[j] > maximo)
                maximo = numeros[j];
            if (numeros[j] < minimo)
                minimo = numeros[j];
                
            if (j != 0 && j != numeros.Length-1)
            {
                der = j+1;
                iz = j-1;
                
                if (numeros[j] < numeros[iz] && numeros[j] < numeros[der])
                    contMinLocal++;
            }
        }
        
        beneficio = ((maximo*100f)/numeros[0]-100f);
        rango = maximo-minimo;
        
        Console.WriteLine();
        Console.WriteLine("Rango: " + rango);
        Console.WriteLine("Beneficio: " + beneficio.ToString("0.00") + "%");
        Console.WriteLine("Mínimos locales: " + contMinLocal);
    }
}
