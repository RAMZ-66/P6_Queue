using System;
using System.Collections.Generic;

namespace P6_Queue
{
    class QueueClientes
    {
        public Queue<Cliente> fila = new Queue<Cliente>();

        public List <string> clientesAtendidos = new List<string>();
        
        public void Formarse(Cliente cliente) 
        {
            this.fila.Enqueue(cliente);
        }  
        // Metodo para mostrar en consola la información del cliente que sigue y quitarlo de la fila
        // Dequeue(Cliente cliente)
        // {
        //     Cliente clienteAtendido;

        //     clienteAtendido = cliente;

        //     this.fila.Dequeue(fila.Count - 1);

                 

        //     Console.WriteLine($"Cliente: {fila.Count}");
        //     Console.WriteLine($"Producto: {cliente.producto}");




        // }

        public Cliente Dequeue()
        {
            if (this.fila.Count == 0)
            {
                return null;
                Console.WriteLine("No hay clientes por atender");
            }

            else
            {
                Cliente cliente = this.fila.Dequeue();
                return cliente;

                Console.WriteLine($"El cliente {cliente.nombre} compra {cliente.producto}");
                
                this.clientesAtendidos.Add("cliente");
                
            }
        }

        // Método para mostrar en Consola el cliente que sigue (Peek)
        public string Peek()
        {
        if (this.fila.Count == 0)
        {
            Console.WriteLine("No hay clientes por mostrar");
            return null;            
        }
        
        else
        {                     
            Cliente cliente = this.fila.Peek();

            return cliente.nombre;

            // Console.WriteLine("El siguiente cliente por atender es: " + cliente.nombre);
        }

        }


        public void ClientesEnFila()
        {            
            foreach (var cliente in this.fila)
            {
                // Console.WriteLine(cliente.nombre);


            }     
        }

        // Método para mostrar el número de clientes actualmente formados en la fila
        public int TotalDeClientesFormados()
        {
            if(this.fila.Count == 0)
            {
                Console.WriteLine("No hay nadie formado en la fila");
                return 0;
            }
            else
            {
                return this.fila.Count;                
            }
        }

        // Método para mostrar el nombre de cada cliente y lo que va a comprar
        public void CompraDeCadaCliente()
        {
            if(this.fila.Count == 0)
            {
                Console.WriteLine("No hay nadie formado en la fila");
            }
            
            foreach (var cliente in this.fila)
            {
                Console.WriteLine($"El cliente {cliente.nombre} va a comprar {cliente.producto}");
            }
        }

        // Método para mostrar cuantos clientes en total se han atendido
        public int ClientesAtendidos()
        {
            if (this.fila.Count == 0)
            {
                return 0;
            }
            
            else
            {
                return this.clientesAtendidos.Count;
            }            
        }


    }
}
