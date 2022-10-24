/* Programa que le pide al usuario una longitud (real) y una unidad (P para 
 * pulgadas y C para centímetros). El programa convierte la longitud a la otra
 * unidad. Si la longitud no es un dato correcto, el programa la vuelve a pedir
 * hasta que lo sea. Si la unidad no es válida, se muestra un mensaje de "unidad
 * no válida" y el programa finaliza. La conversión se muestra con 3 decimales.
 */

using System;

class Ejercicio
{
    static void Main()
    {
        double longitud=0, pulgadasACm, cmAPulgadas;
        char unidad;
        bool correcto;
        
        do
        {
            Console.WriteLine("Introduce una longitud");
            try
            {
                longitud = Convert.ToDouble(Console.ReadLine());
                correcto=true;
            }
            catch(Exception)
            {
                correcto=false;
            }
        }
        while(!correcto);
        
        Console.WriteLine("Introduce la unidad (C=cm, P=pulgadas)");
        unidad=Convert.ToChar(Console.ReadLine());
        if(unidad=='C')
        {
            cmAPulgadas = longitud/2.54;
            Console.WriteLine(longitud+"cm = "+cmAPulgadas.ToString("N3")+
                " pulgada"+((cmAPulgadas==1)?"":"s"));
        }
        else if(unidad=='P')
        {
            pulgadasACm = longitud*2.54;
            Console.WriteLine(longitud+" pulgada"+((longitud==1)?"":"s")+
                " = "+pulgadasACm.ToString("N3")+"cm");
        }
        else
        {
            Console.WriteLine("Unidad no válida");
        }
    }
}
