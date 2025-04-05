using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFieldAcces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delta delta = new Delta();
            Console.WriteLine("Type a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type c:");
            int c = Convert.ToInt32(Console.ReadLine());

            delta.setA(a);
            delta.setB(b);
            delta.setC(c);

            Console.WriteLine("This is delta: {0}", delta.MakeDelta());
        }
    }
}
