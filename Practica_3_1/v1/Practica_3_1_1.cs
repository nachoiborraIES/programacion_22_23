/* Programa que calcula estadísticas de venta para un período de tiempo. Primero
 * le pide al usuario el período a estudiar. Después le pide el total vendido
 * de cada año. Finalmente muestra por pantalla las ventas mínimas, máximas y
 * medias. La media se muestra con dos decimales.
 */

using System;

class Practica
{
    static void Main()
    {
        int anyos, maximo=0, minimo=0, ventas;
        double total=0, media=0;
        Console.WriteLine("Indica el período en años");
        anyos = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Introduce las ventas de los {0} años", anyos);
        for(int i =1; i<=anyos; i++)
        {
            ventas = Convert.ToInt32(Console.ReadLine());
            if(i==1)
            {
                maximo = ventas;
                minimo = ventas;
            }
            else
            {
                if(ventas>maximo)
                {
                    maximo=ventas;
                }
                if(ventas<minimo)
                {
                    minimo=ventas;
                }
            }
            total = total + ventas;
            media = total/anyos;
        }
        Console.WriteLine("Las ventas máximas son de {0} euros", maximo);
        Console.WriteLine("Las ventas mínimas son de {0} euros", minimo);
        Console.WriteLine("Las ventas medias son de {0} euros", 
            media.ToString("N2"));
    }
}
