using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            int a = 0;
            int b = 0;
            int c = 0;
            double x = 0;
            Console.WriteLine("What type of function?");
            Console.WriteLine("Linear, quadratic, rational?");
            answer = Console.ReadLine();
            if (answer == "linear")
            {
                Console.WriteLine("Type a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type x: ");
                x = Convert.ToDouble(Console.ReadLine());

                LinearFunction linear = new LinearFunction(a, b, x);
                Console.WriteLine("Value of a linear function before x has changed: " + linear.FunValue);
                Console.WriteLine("Type x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Value of a linear function after x has changed: " + linear.Update(x));
            }
            else if (answer == "quadratic")
            {
                Console.WriteLine("Type a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type c: ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type x: ");
                x = Convert.ToDouble(Console.ReadLine());

                QuadraticFunction quadratic = new QuadraticFunction(a, b, c, x);
                Console.WriteLine("Value of a quadratic function before x has changed: " + quadratic.FunValue);
                Console.WriteLine("Type x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Value of a quadratic function after x has changed: " + quadratic.Update(x));
            }
            else if (answer == "rational")
            {
                Console.WriteLine("Type a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type x: ");
                x = Convert.ToDouble(Console.ReadLine());

                RationalFunction rational = new RationalFunction(a, x);
                Console.WriteLine("Value of a rational function before x has changed: " + rational.FunValue);
                Console.WriteLine("Type x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Value of a rational function after x has changed: " + rational.update(x));

            }
        }
    }
}
