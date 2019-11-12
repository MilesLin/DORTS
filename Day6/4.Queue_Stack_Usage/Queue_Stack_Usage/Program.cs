using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack_Usage
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          Stack        */
            Stack<string> stack = new Stack<string>();
            stack.Push("Mike");
            stack.Push("Bob");
            string name = stack.Pop();
            Console.WriteLine(name);

            string name2 = stack.Peek();
            Console.WriteLine(name2);

            Console.WriteLine(stack.Count);

            /*          Queue        */
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Mike");
            queue.Enqueue("Bob");
            string name3 = queue.Dequeue();
            Console.WriteLine(name3);

            string name4 = queue.Peek();
            Console.WriteLine(name4);

            Console.WriteLine(queue.Count);

        }
    }
}
