using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTask
{
    class Program
    {
        static void Main(string[] args)
        {
            StringLogic item = new StringLogic();
            Console.Write("Введите строку: ");
            string someString = Console.ReadLine();
            string modifiedString;
            Console.WriteLine($"Начальное количество символов: {someString.Length}");
            modifiedString = item.RemoveStringElements(someString);
            Console.WriteLine(modifiedString);
            Console.ReadLine();
        }
    }
}
