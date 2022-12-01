/* 
 * Programa que mediante un enum creamos un menú en el que usando estructuras y
 * arrays de estructuras podemos almacenar artistas y sus canciones.
 * Pudiendo insertar canciones, ver el listado de las existentes, buscar y 
 * ordenarlas.
 * */
using System;

class Practica040301
{
    enum opciones {SALIR, INSERTAR_FINAL, VER_LISTADO, BUSCAR, ORDENAR_ALFA, 
        ORDENAR_TAMANYO}
    
    struct duracionCancion
    {
        public int minutos;
        public int segundos;
    }
    
    struct cancion
    {
        public string artista;
        public string titulo;
        public duracionCancion duracion;
        public int tamanyoKB;
    }
    
    static void Main()
    {
        opciones opcion;
        cancion[] canciones = new cancion[100];
        int cantidad = 0;
        string artistaSe;
        bool existe;
        
        do
        {
            Console.WriteLine((int)opciones.INSERTAR_FINAL + 
            ". Añadir canción al final ");
            Console.WriteLine((int)opciones.VER_LISTADO + 
            ". Ver listado de titulos");
            Console.WriteLine((int)opciones.BUSCAR + 
            ". Buscar canciones por artista");
            Console.WriteLine((int)opciones.ORDENAR_ALFA + 
            ". Ordenar canciones alfabéticamente (ascendente)");
            Console.WriteLine((int)opciones.ORDENAR_TAMANYO + 
            ". Ordenar canciones por tamaño (descendente)");
            Console.WriteLine((int)opciones.SALIR + ". Salir");
            Console.WriteLine();
            Console.Write("Opción: ");
            opcion = (opciones)Convert.ToInt32(Console.ReadLine());
            
            
            switch(opcion) 
            {
                case opciones.INSERTAR_FINAL:
                    
                    Console.WriteLine();
                    
                    if (cantidad < canciones.Length)
                    {
                        cancion nueva;
                        Console.WriteLine("Artista: ");
                        nueva.artista = Console.ReadLine();
                        Console.WriteLine("Título: ");
                        nueva.titulo = Console.ReadLine();
                        Console.WriteLine("Minutos: ");
                        nueva.duracion.minutos = 
                            Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Segundos: ");
                        nueva.duracion.segundos = 
                            Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Tamaño /KB/: ");
                        nueva.tamanyoKB = Convert.ToInt32(Console.ReadLine());
                        
                        canciones[cantidad] = nueva;
                        cantidad++;
                    }
                    else
                        Console.WriteLine("No caben más canciones.");
                    
                    Console.WriteLine();

                break;
                case opciones.VER_LISTADO:
                
                    Console.Clear();
                    
                    Console.WriteLine("Listado de titulos de canciones:");
                    for (int i = 0; i < cantidad; i++)
                        Console.WriteLine(canciones[i].titulo);
                        
                    Console.WriteLine();
                        
                break;
                case opciones.BUSCAR:
                    
                    Console.WriteLine();
                    
                    Console.WriteLine("Introduce nombre del artista: ");
                    artistaSe = Console.ReadLine();
                    
                    existe = false;
                    
                    for (int i = 0; i < cantidad; i++)
                        if (artistaSe.ToLower() == 
                            canciones[i].artista.ToLower())
                        {
                            existe = true;
                            Console.WriteLine();
                            Console.WriteLine("Canciones de " 
                                + canciones[i].artista + ":");
                            Console.WriteLine(canciones[i].titulo);
                        }
                    
                    if (!existe)
                        Console.WriteLine("No existen canciones del artista.");
                        
                    Console.WriteLine();
                    
                break;
                case opciones.ORDENAR_ALFA:
                
                if (cantidad > 1)
                {
                    for (int i = 0; i < cantidad; i++)
                    {
                        for (int j = 0; j < cantidad - i -1; j++)
                        {
                            if (canciones[j].titulo.ToLower()
                                .CompareTo(canciones[j+1].titulo.ToLower()) > 0)
                            {
                                cancion auxiliar = canciones[j];
                                canciones[j] = canciones[j+1];
                                canciones[j+1] = auxiliar;
                            }
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Lista ordenada correctamente.");
                    Console.WriteLine();
                    Console.WriteLine("Listado de titulos de canciones:");
                    for (int i = 0; i < cantidad; i++)
                        Console.WriteLine(canciones[i].titulo);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("No hay canciones suficientes para" + 
                    " ordenar. Introduce al menos 2 canciones.");
                }
                    
                break;
                
                case opciones.ORDENAR_TAMANYO:
                
                if (cantidad > 1)
                {
                    for (int i = 0; i < cantidad; i++)
                    {
                        for (int j = 0; j < cantidad - i -1; j++)
                        {
                            if (canciones[j].tamanyoKB < 
                                canciones[j+1].tamanyoKB)
                            {
                                cancion auxiliar = canciones[j];
                                canciones[j] = canciones[j+1];
                                canciones[j+1] = auxiliar;
                            }
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Lista ordenada correctamente.");
                    Console.WriteLine();
                    Console.WriteLine("Listado de titulos de canciones:");
                    for (int i = 0; i < cantidad; i++)
                        Console.WriteLine(canciones[i].titulo + " - " + 
                            canciones[i].tamanyoKB + "KB");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("No hay canciones suficientes para" + 
                    " ordenar. Introduce al menos 2 canciones.");
                }

                break;
                
                case opciones.SALIR:
                    Console.Clear();
                    Console.WriteLine("FIN");
                break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Opción no disponible.");
                break;
            }
            if (opcion != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Pulsa intro para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        while (opcion != 0);
    }
}
