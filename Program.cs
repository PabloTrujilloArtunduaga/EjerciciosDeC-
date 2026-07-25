namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Ejercicio Gestor de Tareas Pendientes (To-Do List)
           List<Tarea> tareaLista = new List<Tarea>();           
           int contadorId = 1;
           int option = 0;


           while(option != 5)
            {
               
                

                Console.WriteLine("Acción a realizar: (1- Crear, 2- Listar, 3- Borrar, 4- Actualizar, 5- Salir)");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Crear descripción de la tarea.");
                        Console.WriteLine("Escribir la descripción de la tarea: ");
                        String descripcion = Console.ReadLine() ?? "";
                        Console.WriteLine("Escribir el estado de la tarea: ");
                        String estadoTarea = Console.ReadLine() ?? "";
                        Tarea nuevaTarea = new Tarea(contadorId, descripcion, estadoTarea);
                        tareaLista.Add(nuevaTarea);
                        contadorId++;
                        break;
                    case 2:
                        Console.WriteLine("Listar tareas.");
                        foreach(Tarea t in tareaLista)
                        {
                            Console.WriteLine($"ID: {t.Id} | Tarea: {t.Descripcion} | Estado: {t.Estado}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Eliminar tarea.");
                        Console.WriteLine("Eliminar por ID: ");
                        int idAEliminar = Convert.ToInt32(Console.ReadLine());
                        Tarea tareaAEliminar = tareaLista.Find(t => t.Id == idAEliminar);
                            if(tareaAEliminar != null)
                            {
                                tareaLista.Remove(tareaAEliminar);
                                Console.WriteLine($"La tarea con ID {idAEliminar} fue eliminada con éxito.");
                            } else
                            {
                                Console.WriteLine("No se encontró ese ID.");
                            }
                        
                        break;
                    case 4:
                        Console.WriteLine("Actualizar tarea.");
                        Console.WriteLine("Seleccionar ID: ");
                        int idAactualizar = Convert.ToInt32(Console.ReadLine());
                        Tarea tareaActualizar = tareaLista.Find(t => t.Id == idAactualizar);
                         if(tareaActualizar != null)
                            {
                                Console.WriteLine("Escribir la descripción de la tarea: ");
                                String nuevaDescripcion = Console.ReadLine() ?? "";
                                Console.WriteLine("Escribir el estado de la tarea: ");
                                String NuevoEstadoTarea = Console.ReadLine() ?? "";
                                tareaActualizar.Descripcion = nuevaDescripcion;
                                tareaActualizar.Estado = NuevoEstadoTarea;
                                Console.WriteLine("Tarea actualizada.");
                                
                            } else
                            {
                                Console.WriteLine("No se encontró ese ID.");
                            }
                        break;
                    case 5:
                        Console.WriteLine("Saliste.");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;

                        
                }
                
            }
        }

    }



    public class Tarea
    {
    public int Id { get; private set; }
    public string Descripcion { get; set; }
    public string Estado { get; set; }

    
        public Tarea(int id, string descripcion, string estado)
        {
            Id = id;
            Descripcion = descripcion;
            Estado = estado; 
        }
  
    }
}