using System;
using System.Collections;

namespace Non_Generic_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            Console.Write("How many items do u want to push ? ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                myStack.Push(Console.ReadLine());
            }

            //shallow copy of stack 
            Stack newStack = (Stack)myStack.Clone();

            Console.WriteLine("My Stack Items Are : ");
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            if (myStack.Count > 0)
            {
                Console.Write("My Stack Peek Value : ");
                Console.WriteLine(myStack.Peek());
            }

            Console.Write("My Stack Search Value : ");
            var searchValue = Console.ReadLine();
            Console.WriteLine(myStack.Contains(searchValue));

            if (myStack.Count > 0)
            {
                Console.Write("My Stack Poped Value : ");
                Console.WriteLine(myStack.Pop());
            }

            myStack.Clear();

            Console.WriteLine("My Stack Initial : ");

            foreach (var item in newStack)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
