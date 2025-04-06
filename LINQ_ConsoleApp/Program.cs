using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleLINQquerries simpleLINQquerries = new SimpleLINQquerries();
            string[] strArr = new string[4];
            string letter = "";
            Console.WriteLine("Type a letter: ");
            letter = Console.ReadLine();

            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine("Type a name");
                strArr[i] = Console.ReadLine();
            }

            simpleLINQquerries.ArrayQueryMethod(letter, strArr);
            simpleLINQquerries.DisplayUserName();
        }
    }
}
