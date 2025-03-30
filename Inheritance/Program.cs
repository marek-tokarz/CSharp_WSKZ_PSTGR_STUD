namespace Inheritance
{
    public abstract class Shape
    {
        public enum Color { RED, GREEN, BLUE };

        protected Color color;

        protected String name;

        public Shape (Color color, String name)
        {
            this.color = color;
            this.name = name;
        }

        public abstract Double Area();

        public abstract Double Perimeter();
    }

    public class Rectangle : Shape
    {
        protected Double a, b;

        public Rectangle(double a, double b, Color color, String name) : base(color, name)
        {
            this.a = a;
            this.b = b;
        }

        public override Double Area()
        {
            return a * b;
        }

        public override Double Perimeter()
        {
            return 2 * (a + b);
        }

        public override string? ToString()
        {
            return "Rectangle, a = " + a + ", b = " + b + " of color: " + color + " and name: " + name;
        }
    }

    public class Square : Rectangle
    {
        protected Double a;

        public Square(double a, Color color, String name) : base(a, a, color, name)
        {
            this.a = a;
        }

        public override string? ToString()
        {
            return "Square, a = " + a + " of color: " + color + " and name: " + name;
        }
    }

    public class Circle: Shape
    {
        private Double r;

        public Circle(double r, Color color, String name) : base(color, name)
        {
            this.r = r;
        }

        public override Double Area()
        {
            return Math.PI * r * r;
        }

        public override Double Perimeter()
        {
            return 2 * Math.PI * r;
        }

        public override string? ToString()
        {
            return "Circle, r = " + r + " of color: " + color + " and name: " + name;
        }
    }

    public class Program
    {
        public static void Main()
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle(2, 3, Shape.Color.BLUE, "nice"));
            shapes.Add(new Square(2, Shape.Color.RED, "interesting"));
            shapes.Add(new Circle(4, Shape.Color.GREEN, "funny"));

            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
                Console.WriteLine(shape.Area());
                Console.WriteLine(shape.Perimeter());
            }
        }
    }
}