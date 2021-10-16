using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
    class Collections
    {
        public void List()
        {
            List<string> names = new List<string>();
            names.Add("Dell");
            names.Add("Hp");
            names.Add("AvitaPura");
            names.Add("Lenovo");
            names.Insert(2, "Apple");
            Console.WriteLine("Checking if the element is present or not" + names.Contains("AvitaPura"));
            Console.WriteLine("count numer of elements in list:" + names.Count);
            Console.WriteLine("Printing list of elements");
            foreach (string name in names)
            
                Console.WriteLine(name);
                names.Sort();
                Console.WriteLine("Printing the list of elements after sorting");
            
            foreach (string name in names)
            
                Console.WriteLine(name);
                names.Remove("Lenovo");
           
            Console.WriteLine("counting the list of elements after removing::" + names.Count);

        }

        public void Stack()
        {
            Stack myStack = new Stack();
            //add element in stack
            myStack.Push("Hd1");
            myStack.Push("Hd2");
            myStack.Push("Hd3");
            myStack.Push("Hd4");
            foreach (var element in myStack)
            {
                Console.WriteLine(element);
            }
            //counting all elements in stack
            Console.WriteLine("total elements present in stack is::" + myStack.Count);
            //removing topmost element
            Console.WriteLine("Top most element present in stack::" + myStack.Pop());
            Console.WriteLine("total elements present in stack after poping one element" + myStack.Count);
            //printing topmost element in stack
            Console.WriteLine("TopMost present in stack is::" + myStack.Peek());
            bool reslt = myStack.Contains("Jose");
            Console.WriteLine("elemnet present in stack::" + reslt);
            //clearing the stack
            myStack.Clear();
            Console.WriteLine("total elements present in stack after clearing all  elements::" + myStack.Count);
        }

        public void Queue()
        {
            Queue queue = new Queue();
            //adding element in queue
            queue.Enqueue("Wipro");
            queue.Enqueue("amazon");
            queue.Enqueue("google");
            queue.Enqueue("tcs");
            foreach (var element in queue)
                Console.WriteLine(element);
            //counting number of elements in queue
            Console.WriteLine("Total number of elements present in queue is::" + queue.Count);
            //removing topmost element in queue
            Console.WriteLine("Removing top most element in queue::" + queue.Dequeue());
            Console.WriteLine("Total number of elements after removing one element::" + queue.Count);
            //getting topmost element in queue
            Console.WriteLine("Printng top most element in queue::" + queue.Peek());
            //checking element is present or not in queue
            Console.WriteLine("Checking element is present or not::" + queue.Contains("google"));
            //clearing all elents in queue
            queue.Clear();
            Console.WriteLine("Total number of elements after clearing the queue::" + queue.Count);

        }

        public void Dictionary()
        {
            Dictionary<int, String> dict = new Dictionary<int, string>();
            dict.Add(1, "jan");
            dict.Add(2, "feb");
            dict.Add(3, "march");
            dict.Add(4, "april");

            //printing the elements in dictionay
            foreach (KeyValuePair<int, string> ele in dict)
            {
                Console.WriteLine("{0} : {1}",
                            ele.Key, ele.Value);
            }

            //Removing element in dictionaty
            Console.WriteLine("Counting the Number of elements Before removing::" + dict.Count);
            dict.Remove(1);
            Console.WriteLine("Counting the Number of elements after removing::" + dict.Count);
            var result = dict.ContainsKey(2);
            Console.WriteLine("Checking if the key is present or not::" + result);
            var valueResult = dict.ContainsValue("Anna");
            Console.WriteLine("Checking if the value is present or not::" + valueResult);
            dict.Clear();
            Console.WriteLine("Counting the Number of elements after clearing the dictionary::" + dict.Count);

        }
    }
}
