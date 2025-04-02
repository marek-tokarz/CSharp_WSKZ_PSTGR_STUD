using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFunctionsPropertiesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            string answer = "";

            Console.WriteLine("What function do you choose?");
            Console.WriteLine("Linear, quadratic, cubic or rational?");
            Console.WriteLine("For linear, type: linear");
            Console.WriteLine("For quadratic, type: quadratic");
            Console.WriteLine("For cubic, type: cubic");
            Console.WriteLine("For rational, type: rational");
            answer = Console.ReadLine();
            if (answer == "linear")
            {
                Console.WriteLine("Type a:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type b:");
                b = Convert.ToInt32(Console.ReadLine());

                LinearFunction linearFunction = new LinearFunction(a, b);
                Console.WriteLine("Those are parameters of a linear function");
                Console.WriteLine("a: " + linearFunction.AFactor);
                Console.WriteLine("b: " + linearFunction.BFactor);
                Console.WriteLine("Derivative of a linear function: " + linearFunction.DerivativeLinearFunction);
                Console.WriteLine("Derivative of a quadratic function: " + linearFunction.DerivativeQuadraticFunction);
                Console.WriteLine("Derivative of a cubic function: " + linearFunction.DerivativeCubeFunction);
                Console.WriteLine("Derivative of a rational function: " + linearFunction.DerivativeRationalFunction);
            }
            else if (answer == "quadratic")
            {
                Console.WriteLine("Type a:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type b:");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type c:");
                c = Convert.ToInt32(Console.ReadLine());

                QuadraticFunction quadratic = new QuadraticFunction(a, b, c, 2);

                Console.WriteLine("Those are parameters of a quadratic function");
                Console.WriteLine("a: " + quadratic.AFactor);
                Console.WriteLine("b: " + quadratic.BFactor);
                Console.WriteLine("c: " + quadratic.CFactor);
                Console.WriteLine("Delta: " + quadratic.Delta);
                Console.WriteLine("Derivative of a linear function: " + quadratic.DerivativeLinearFunction);
                Console.WriteLine("Derivative of a quadratic function: " + quadratic.DerivativeQuadraticFunction);
                Console.WriteLine("Derivative of a cubic function: " + quadratic.DerivativeCubeFunction);
                Console.WriteLine("Derivative of a rational function: " + quadratic.DerivativeRationalFunction);
            }
            else if (answer == "cubic")
            {
                Console.WriteLine("Type a:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type b:");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type c:");
                c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type c:");
                d = Convert.ToInt32(Console.ReadLine());

                CubeFunction qubic = new CubeFunction(a, b, c, d, 3, 2);

                Console.WriteLine("Those are parameters of a qubic function");
                Console.WriteLine("a: " + qubic.AFactor);
                Console.WriteLine("b: " + qubic.BFactor);
                Console.WriteLine("c: " + qubic.CFactor);
                Console.WriteLine("d: " + qubic.DFactor);
           
                Console.WriteLine("Derivative of a linear function: " + qubic.DerivativeLinearFunction);
                Console.WriteLine("Derivative of a quadratic function: " + qubic.DerivativeQuadraticFunction);
                Console.WriteLine("Derivative of a cubic function: " + qubic.DerivativeCubeFunction);
                Console.WriteLine("Derivative of a rational function: " + qubic.DerivativeRationalFunction);
            }
            else if (answer == "rational")
            {
                Console.WriteLine("Type a:");
                a = Convert.ToInt32(Console.ReadLine());

                RationalFunction rational = new RationalFunction(a);

                Console.WriteLine("Those are parameters of a rational function");
                Console.WriteLine("a: " + rational.AFactor);
               
                Console.WriteLine("Derivative of a linear function: " + rational.DerivativeLinearFunction);
                Console.WriteLine("Derivative of a quadratic function: " + rational.DerivativeQuadraticFunction);
                Console.WriteLine("Derivative of a cubic function: " + rational.DerivativeCubeFunction);
                Console.WriteLine("Derivative of a rational function: " + rational.DerivativeRationalFunction);
            }

        }
    }
}
