using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            WoodPlate woodPlate = new WoodPlate(a, b);
            woodPlate.DisplayInfos();
        }
    }
}
