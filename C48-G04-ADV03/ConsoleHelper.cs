using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C48_G04_ADV03
{
    internal class ConsoleHelper
    {
        public static void PrintList<T>(string listName, List<T> items)
        {
            Console.WriteLine($"{listName} : [{string.Join(", ", items)}]");

        }

        public static void PrintHashSet<T>(string setName, HashSet<T> items)
        {
            Console.WriteLine($"{setName} : [{string.Join(", ", items)}]");

        }
        public static void PrintQueue<T>(string queueName, Queue<T> items)
        {
            Console.WriteLine($"{queueName} : [{string.Join(", ", items)}]");

        }
        public static void PrintStack<T>(string stackName, Stack<T> items)
        {
            Console.WriteLine($"{stackName} : [{string.Join(", ", items)}]");

        }
        public static void PrintArray<T>(string arrayName, T[] items)
        {
            Console.WriteLine($"{arrayName} : [{string.Join(", ", items)}]");

        }
        public static void PrintCollection<T>(string colName, IEnumerable<T> items)
        {
            Console.WriteLine($"{colName} : [{string.Join(", ", items)}]");

        }
    }
}
