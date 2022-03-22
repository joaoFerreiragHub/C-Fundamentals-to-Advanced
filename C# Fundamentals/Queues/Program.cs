using System;
using System.Collections.Generic;

namespace Queuez
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            //defining a queue of integers
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            Console.WriteLine("The vlaue at the front of the queue is: {0}", queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine("The vlaue at the front of the queue is: {0}", queue.Peek());
            queue.Enqueue(3);
            queue.Dequeue(); //removes item
            Console.WriteLine("The vlaue at the front of the queue is: {0}", queue.Peek());

            while (queue.Count > 0)
            {
                //Dequeue() will return the element that was removed from the queue
                Console.WriteLine("The Front Value {0} was removed from the queue", queue.Dequeue());
                //print the queu count\
                Console.WriteLine("Currente queue count is : {0}", queue.Count);
            }
            */

            //Criamos uma queue
            Queue<Order> queue = new Queue<Order>();
            

            // adicionamos as ordems a queue
            foreach(Order o in RecieveOrderFromBranch1())
            {
                queue.Enqueue(o);
            }

            foreach (Order o in RecieveOrderFromBranch2())
            {
                queue.Enqueue(o);
            }

            // enquanto houver ordens, processar
            while(queue.Count>0)
            {
                Order currentOrder = queue.Dequeue();
                currentOrder.ProcessOrder();
            }

        }

        static Order[] RecieveOrderFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2, 4),
                new Order(6, 10)
             };
            return orders;
        }

        static Order[] RecieveOrderFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(3, 5),
                new Order(4, 4),
                new Order(5, 10)
            };
            return orders;
        }
    }

    class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }

        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} was processed.");
        }
    }
}
