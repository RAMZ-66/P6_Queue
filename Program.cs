using System;
using System.Collections.Generic;

namespace P6_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueClientes queueClientes = new QueueClientes();

            string opcion = "";

            while (opcion != "9")
            {

                opcion = "";

                while(opcion != "1" && opcion != "2" && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "9")
                {
                    Console.WriteLine("Porfavor selecciona una opción válida:");
                    Console.WriteLine("");
                    Console.WriteLine("1) Formar clientes (Push)");
                    Console.WriteLine("2) Atender clientes (Dequeue)");                
                    Console.WriteLine("3) Consultar próximo cliente (Peek)");                                        
                    Console.WriteLine("4) Consultar clientes formados actualmente (Peek)");                                        
                    Console.WriteLine("5) Consultar nombre y producto de cada cliente formado actualmente");
                    Console.WriteLine("6) Consultar total de clientes atendidos");   
                    Console.WriteLine("9) Salir del programa");   


                    opcion = Console.ReadLine();                   

                    // 1) Formar clientes (Push)
                    if (opcion == "1")                   
                    {          
                        Console.WriteLine("Introduce el nombre del Cliente:");

                        string nombre = Console.ReadLine();

                        Console.WriteLine("Introduce el producto a comprar por el cliente");

                        string producto = Console.ReadLine();

                        Cliente cliente = new Cliente(nombre, producto);

                        queueClientes.fila.Enqueue(cliente);                       
                    }

                    // 2) Atender clientes (Dequeue)
                    else if (opcion == "2")
                    {
                        queueClientes.Dequeue();                      
                    }

                    // 3) Consultar próximo cliente (Peek)
                    else if (opcion == "3")
                    {
                        Console.WriteLine("");
                        // Peek
                        string nombre = queueClientes.Peek();   

                        Console.WriteLine("El próxmo cliente por atender es " + nombre);                     
                    }

                    // 4) Consultar total de clientes formados actualmente
                    else if (opcion == "4")
                    {
                        Console.WriteLine("");
                        // Peek
                        Console.WriteLine($"Numero de clientes formados: {queueClientes.TotalDeClientesFormados()}");                                             
                    }

                    // Consultar los datos del cliente y lo que va a comprar
                    else if (opcion == "5")
                    {
                        queueClientes.CompraDeCadaCliente();
                    }

                    else if (opcion == "6")
                    {
                        Console.WriteLine($"El total de clientes atendidos es {queueClientes.ClientesAtendidos()}");
                    }

                    
                    // Salir del programa
                    else if (opcion == "9")
                    {

                        Console.WriteLine("Hasta luego");            
                        
                    }
                        
                }
            
            }
                                                     
        }
    }
}
