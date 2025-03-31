namespace ConsoleXMLRWApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string answear = "";
            XMLBookRW xmlbrw = new XMLBookRW();
            Console.WriteLine("If you want to read a XML document Books.xml");
            Console.WriteLine("then type: reading");
            Console.WriteLine("If you want to write to a XML document Books.xml");
            Console.WriteLine("then type: writing");

            answear = Console.ReadLine();
            if(answear == "reading")
            {
                xmlbrw.readFromXMLFile();
            }
            else if (answear == "writing")
            {
                string book_title = "";
                string book_author = "";
                string book_category = "";
                string book_label = "";
                int book_isbn = 0;
                string releaseDate = "";
                int catalogNumber = 0;

                Console.WriteLine("Book title: ");
                book_title = Console.ReadLine();

                Console.WriteLine("Book author: ");
                book_author = Console.ReadLine();

                Console.WriteLine("Book category: ");
                book_category = Console.ReadLine();

                Console.WriteLine("Book label: ");
                book_label = Console.ReadLine();

                Console.WriteLine("Book ISBN: ");
                book_isbn = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Book release date: ");
                releaseDate= Console.ReadLine();

                Console.WriteLine("Book catalog number: ");
                catalogNumber = Convert.ToInt32(Console.ReadLine());

                BookProduct bp = new BookProduct(book_title, book_author, book_category, book_label, book_isbn, releaseDate, catalogNumber);

                xmlbrw.writeToXMLFile(bp);  
            }

            Console.ReadKey();
        }
    }
}