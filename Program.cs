namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Ejercicio Calculadora
           int option = 0;

           while(option != 5)
           {
              Console.WriteLine("Escribir operacion a realizar (1- sumar, 2-restar, 3- dividir, 4- multiplicar, 5- salir) ");
              option = Convert.ToInt32(Console.ReadLine());


                if (option == 5)
                {
                    Console.WriteLine("Saliste");
                    break;
                    
                }

               if (option < 1 || option > 5)
                {
                    Console.WriteLine("Opcion invalida");
                    continue;

                }

              
              Console.WriteLine("Escribir numero 1: ");
              int number1 = Convert.ToInt32(Console.ReadLine());
              
              Console.WriteLine("Escribir numero 2: ");
              int number2 = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine(addNumbers(number1, number2));
                        break;

                    case 2:
                        Console.WriteLine(substractNumbers(number1, number2));
                        break;

                    case 3:
                        Console.WriteLine(divideNumbers(number1, number2));
                        break;

                    case 4:
                        Console.WriteLine(multyNumbers(number1, number2));
                        break;       
                }

               
            }

            Console.ReadKey(); 
        }

        public static int addNumbers(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("La suma es de: ");
            return c;
            
        }

         public static int substractNumbers(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("La resta es de: ");
            return c;
            
        }

         public static int divideNumbers(int a, int b)
        {   
            try
            {
                int c = a / b;
                Console.WriteLine("La division es de: ");
                return c;
            } catch (DivideByZeroException)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                return 0;
            }
            
            
        }

         public static int multyNumbers(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("La multplicacion es de ");
            return c;
            
        }


       
    }
}