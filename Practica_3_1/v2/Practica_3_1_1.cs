/*Programa que calcula estadísitcas de venta en un período de tiempo.
 * El usuario introduce las ventas de los años que el diga y
 * se le responde con las ventas máximas, mínimas y medias.*/
 
using System;

class Ejercicio
{
    static void Main()
    {
        int periodo, venta, suma, max = 0, min = 0, i;
        float media;
        Console.WriteLine("Indica el período en años:");
        periodo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce las ventas de los "+periodo+" años:");
        
        suma = 0;
        for (i = periodo; i>0; i--)
        {
            venta = Convert.ToInt32(Console.ReadLine());
            if (i == periodo)
            {
                max = venta;
                min = venta;
            }
            suma = suma + venta;
            if (max<venta)
            {
                max = venta;
            }
            if (min>venta)
            {
                min = venta;
            }
        }
        
        media = suma/(float)periodo;
        Console.WriteLine("Las ventas mínimas han sido de "+min+" euros");
        Console.WriteLine("Las ventas máximas han sido de "+max+" euros");
        Console.WriteLine("Las ventas medias han sido de "+
                          media.ToString("N2")+" euros");
    }
}
