/*
 * Programa que muestra un menú que le permite al usuario almacenar juegos en
 * un array y además le permite borrar juegos en una posición, mostrar el juego
 * más caro, mostrar los juegos del tipo que pida el usuario y buscarlos por
 * título
 */

using System;

class Practica_4_2
{
    enum genero {ROL = 1, INFANTIL, PUZZLE, OTROS};
    
    enum opciones {SALIR, NUEVO, BORRAR, CARO, TIPO, TITULO};
    
    struct infoBasica
    {
       public int edadMin;
       public int minJugadores;
       public int maxJugadores;
    }
    
    struct juego
    {
        public string nombre;
        public infoBasica info;
        public float precio;
        public genero tipo;
        
    }
    
    public static void Main()
    {
        juego[] catalogo = new juego[30];
        juego precioMax;
        char confirmacion;
        opciones opcion;
        genero opcionGenero;
        int cantidad = 0, posicion;
        string titulo;
        
        do
		{
            Console.Clear();
			Console.WriteLine("Menú de opciones:");
			Console.WriteLine((int)opciones.NUEVO + 
				". Nuevo Juego");
			Console.WriteLine((int)opciones.BORRAR + 
				". Borrar Juego");
			Console.WriteLine((int)opciones.CARO + 
				". Juego más caro");
			Console.WriteLine((int)opciones.TIPO + 
				". Juegos por tipo");
            Console.WriteLine((int)opciones.TITULO + 
				". Juegos por título");
            Console.WriteLine((int)opciones.SALIR + 
				". Salir");
			Console.WriteLine("Elige una opción del menú:");
			
			opcion = (opciones)Convert.ToInt32(Console.ReadLine());
			
			switch(opcion)
			{
				case opciones.NUEVO:
                
                    juego nuevo;
                    
                    if(cantidad < catalogo.Length)
					{
                        Console.WriteLine("Introduzca la información basica: ");
                        Console.WriteLine("Titulo: ");
                        nuevo.nombre = Console.ReadLine();
                        
                        Console.WriteLine("Edad Mínima: ");
                        nuevo.info.edadMin = 
                            Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Jugadores mínimos: ");
                        nuevo.info.minJugadores = 
                            Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Jugadores máximos: ");
                        nuevo.info.maxJugadores = 
                            Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Tipo de juego: ");
                        foreach(genero g in Enum.GetValues(typeof(genero)))
                        {
                            Console.WriteLine("{0}. {1}", (int)g, g);
                        }                       
                        nuevo.tipo = (genero)Convert.ToInt32(Console.ReadLine());
                        
                        try
                        {
                            Console.WriteLine("Precio: ");
                            nuevo.precio = 
                                Convert.ToSingle(Console.ReadLine());
                            if(nuevo.precio > 0)
                            {
                                catalogo[cantidad] = nuevo;
                                cantidad++;
                            }
                            else
                            {
                                Console.WriteLine("Precio no valido");
                            }
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("Precio no válido");
                        }
					}
                    else
                    {
                        Console.WriteLine("Catálogo completo.");
                    }
                    
					break;
                    
				case opciones.BORRAR:
                
                    if(cantidad != 0)
                    {
                        for(int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine((i+1) + ". " + catalogo[i].nombre);
                            Console.WriteLine("Edad mínima: " +
                                catalogo[i].info.edadMin);
                            Console.WriteLine("Mínimo de jugadores: " +
                                catalogo[i].info.minJugadores);
                            Console.WriteLine("Máximo de jugadores: " +
                                catalogo[i].info.maxJugadores);
                            Console.WriteLine("Precio: " + catalogo[i].precio);
                            Console.WriteLine("Género: " + catalogo[i].tipo);
                           Console.WriteLine("----------------------");
                        }
                        
                        Console.WriteLine("Introduzca la posición a borrar: ");
                        posicion = Convert.ToInt32(Console.ReadLine());
                        posicion--;
                        
                        if(posicion >= 0 && posicion < cantidad)
                        {
                            Console.WriteLine("¿Seguro que quiere " + 
                            "borrar el juego? (S/N)");
                            confirmacion = Convert.ToChar(Console.ReadLine());
                            if(confirmacion == 'S')
                            {
                                for(int i = posicion; i < cantidad - 1; i++)
                                {
                                    catalogo[i] = catalogo[i+1];
                                }
                                cantidad--;
                            }
                            else
                            {
                                Console.WriteLine("No se ha borrado el juego");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Posición incorrecta");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay juegos en el catálogo");
                    }
					
					break;
                    
				case opciones.CARO:
                    if(cantidad != 0)
                    {
                        precioMax = catalogo[0];
                        for(int i = 0; i < cantidad; i++)
                        {
                            if(precioMax.precio < catalogo[i].precio )
                            {
                                precioMax = catalogo[i];
                            }
                        }
                        Console.WriteLine("Título: " + 
                            precioMax.nombre);
                        Console.WriteLine("Edad mínima: " +
                            precioMax.info.edadMin);
                        Console.WriteLine("Mínimo de jugadores: " +
                            precioMax.info.minJugadores);
                        Console.WriteLine("Máximo de jugadores: " +
                            precioMax.info.maxJugadores);
                        Console.WriteLine("Precio: " + 
                            precioMax.precio);
                        Console.WriteLine("Género: " + 
                            precioMax.tipo);
                    }
                    else
                    {
                        Console.WriteLine("No hay juegos en el catálogo.");
                    }
					break;
                    
				case opciones.TIPO:
                
                    bool encontrado = false;
                
					Console.WriteLine("Introduzca el tipo que quiera buscar");
                    foreach(genero g in Enum.GetValues(typeof(genero)))
                    {
                        Console.WriteLine("{0}. {1}", (int)g, g);
                    }                       
                    
                    opcionGenero = (genero)Convert.ToInt32(Console.ReadLine());
                    
                    if(opcionGenero <= genero.OTROS && opcionGenero >= genero.ROL)
                    {
                        for(int i = 0; i < cantidad; i++)
                        {
                            if((genero)opcionGenero == catalogo[i].tipo)
                            {
                               encontrado = true;
                               
                               Console.WriteLine("Título: " + 
                               catalogo[i].nombre);
                               Console.WriteLine("Edad mínima: " +
                               catalogo[i].info.edadMin);
                               Console.WriteLine("Mínimo de jugadores: " +
                               catalogo[i].info.minJugadores);
                               Console.WriteLine("Máximo de jugadores: " +
                               catalogo[i].info.maxJugadores);
                               Console.WriteLine("Precio: " + 
                               catalogo[i].precio);
                               Console.WriteLine("Género: " + 
                               catalogo[i].tipo);
                               Console.WriteLine("----------------------");
                            }
                        }
                        if(!encontrado)
                        {
                            Console.WriteLine("No se ha encontrado ese genero");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tipo no valido");
                    }
                    
					break;
                    
                case opciones.TITULO:
                
                    if(cantidad != 0)
                    {
                        Console.WriteLine("Escribe un titulo de juego: ");
                        titulo = Console.ReadLine().ToLower();
                        for(int i = 0; i < cantidad ; i++)
                        {
                            if(catalogo[i].nombre.ToLower().Contains(titulo))
                            {
                                Console.WriteLine("Título: " + 
                                catalogo[i].nombre);
                                Console.WriteLine("Edad mínima: " +
                                catalogo[i].info.edadMin);
                                Console.WriteLine("Mínimo de jugadores: " +
                                catalogo[i].info.minJugadores);
                                Console.WriteLine("Máximo de jugadores: " +
                                catalogo[i].info.maxJugadores);
                                Console.WriteLine("Precio: " + 
                                catalogo[i].precio);
                                Console.WriteLine("Género: " + 
                                catalogo[i].tipo);
                                Console.WriteLine("----------------------");
                            }
                        }
                    }
                    break;
                    
                case opciones.SALIR:
                    Console.WriteLine("Fin del programa");
                    break;
				default:
					Console.WriteLine("Opción incorrecta");
					break;
			}
            
            if (opcion != opciones.SALIR)
            {
                Console.WriteLine("Pulsa Intro para continuar...");
                Console.ReadLine();
            }
		}
		while(opcion != opciones.SALIR);
    }
}
