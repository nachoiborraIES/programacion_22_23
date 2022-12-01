using System;
using System.Text;

class Ejercicio_04b_03
{
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
		public int tamKB;
	}
	
	enum opciones {INSERTAR=1, MOSTRAR, BUSCAR, ORDENAR_TIT, ORDENAR_TAM, SALIR}	
	
	static void Main()
	{
		cancion[] canciones = new cancion[100];
		cancion nuevaCancion;
		int cantidad = 0, opcion;
		string artistaABuscar;
		bool hayResultados;
		
		do
		{
			Console.WriteLine("Menú de opciones:");
			Console.WriteLine((int)opciones.INSERTAR + 
				". Añadir canción al final");
			Console.WriteLine((int)opciones.MOSTRAR + 
				". Mostrar títulos de las canciones");
			Console.WriteLine((int)opciones.BUSCAR + 
				". Buscar por artista");
			Console.WriteLine((int)opciones.ORDENAR_TIT + 
				". Ordenar alfabéticamente por título");
			Console.WriteLine((int)opciones.ORDENAR_TAM + 
				". Ordenar descendentemente por tamaño");
			Console.WriteLine((int)opciones.SALIR + 
				". Salir");
			Console.WriteLine("Elige una opción del menú:");
			
			opcion = Convert.ToInt32(Console.ReadLine());
			
			switch((opciones)opcion)
			{
				case opciones.INSERTAR:
				
					if (cantidad < canciones.Length)
					{
						Console.WriteLine("Escribe el artista de la canción:");
						nuevaCancion.artista = Console.ReadLine();
						Console.WriteLine("Escribe el título de la canción:");
						nuevaCancion.titulo = Console.ReadLine();
						Console.WriteLine("Escribe los minutos de la canción:");
						nuevaCancion.duracion.minutos = 
							Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Escribe los segundos de la canción:");
						nuevaCancion.duracion.segundos = 
							Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Escribe el tamaño en KB:");
						nuevaCancion.tamKB = Convert.ToInt32(Console.ReadLine());
						
						canciones[cantidad] = nuevaCancion;
						cantidad++;
						
					}
					break;
                    
				case opciones.MOSTRAR:
                
					for(int i = 0; i < cantidad; i++)
					{
						Console.WriteLine("Título: {0}", 
							canciones[i].titulo);
					}				
					break;
                    
				case opciones.BUSCAR:
					Console.WriteLine("Escribe el artista a buscar:");
					artistaABuscar = Console.ReadLine();
					hayResultados = false;
					for(int i = 0; i < cantidad; i++)
					{
						if(canciones[i].artista == artistaABuscar)
						{
							hayResultados = true;
							Console.Write(canciones[i].titulo);
							Console.WriteLine(" {0}:{1}",
								canciones[i].duracion.minutos,
								canciones[i].duracion.segundos);
						}
					}
					if(!hayResultados)
					{
						Console.WriteLine("No se han encontrado canciones");
					}
					break;
                
                // Opcion que ordena las canciones con todos sus datos por
                // orden alfabético según el tiítulo
				case opciones.ORDENAR_TIT:
                
                    for(int i = 0; i < canciones.Length - 1; i++)
                    {
                        for(int j = i+1; j < canciones.Length; j++)
                        {
                            if (canciones[i].titulo.CompareTo
                                (canciones[j].titulo) > 0)
                            {
                                cancion auxiliar = canciones[i];
                                canciones[i] = canciones[j];
                                canciones[j] = auxiliar;
                            }
                        }
                    }
                    
                    for(int i = 0; i < cantidad; i++)
					{
						Console.WriteLine("Título: {0}", 
							canciones[i].titulo);
					}
                
					break;
                
                // Opcion que ordena las canciones con todos sus datos de mayor
                // a menor según su tamaño en KB
				case opciones.ORDENAR_TAM:
                    
                    for (int i = 0; i < canciones.Length; i++)
                    {
                        for (int j = 0; j < canciones.Length - i - 1; j++)
                        {
                            if (canciones[j].tamKB < canciones[j+1].tamKB)
                            {
                                cancion auxiliar = canciones[j];
                                canciones[j] = canciones[j+1];
                                canciones[j+1] = auxiliar;
                            }
                        }
                    }
                    
                    for(int i = 0; i < cantidad; i++)
					{
						Console.WriteLine("Título: {0}", 
							canciones[i].titulo);
					}
                
					break;
                    
				case opciones.SALIR:
                
					Console.WriteLine("Fin del programa");
					break;
                    
				default:
                
					Console.WriteLine("Opción incorrecta");
					break;
			}
		}
		while(opcion != (int)opciones.SALIR);				
	}
}
