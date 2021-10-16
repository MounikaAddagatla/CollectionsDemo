using System;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Collection Demo Project");
            Collections collections = new Collections();
            Console.WriteLine("List Elements");
            collections.List();
            Console.WriteLine("----------");
            Console.WriteLine("Stack Elements");
            collections.Stack();
            Console.WriteLine("----------");
            Console.WriteLine("Queue Elements");
            collections.Queue();
            Console.WriteLine("------------");
            Console.WriteLine("Dictionary Values");
            collections.Dictionary();
            Console.ReadLine();
        }
    }
}
