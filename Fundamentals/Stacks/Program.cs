using System;
using System.Collections.Generic;

namespace Stackzos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining a new stack
            Stack<int> stack = new Stack<int>();

            //add element to the stack using Push()
            //adding elements to the stack and printing the value at the top of the stack using peek
            //adding elements using Push()
          
            if(stack.Count > 0) // Verificar antes de remover para evitar erro
            stack.Pop();


            stack.Push(1);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            stack.Push(3);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());
            int myStackItem = stack.Pop();
            Console.WriteLine("Popped Item: {0}", myStackItem);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());

            while (stack.Count > 0)
                stack.Pop();



            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            //defining a new stack of int
            Stack<int> myStack = new Stack<int>();

            foreach (int number in numbers)
            {
                myStack.Push(number);
                Console.Write(number + " ");
            }

            while (stack.Count > 0)
            {
               int number = stack.Pop();
               Console.Write(number + " ");
            }
                
        }
    }
}
