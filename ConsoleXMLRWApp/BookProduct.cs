using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleXMLRWApp
{
    public class BookProduct
    {
        private string title = "";
        private string author = "";
        private string category = "";
        private string label = "";
        private int isbn = 0;
        private string releaseDate = "";
        private int catalogNumber = 0;

        public BookProduct(string title, string author, string category, string label, int isbn, string releaseDate, int catalogNumber)
        {
            this.title = title;
            this.author = author;
            this.category = category;
            this.label = label;
            this.isbn = isbn;
            this.releaseDate = releaseDate;
            this.catalogNumber = catalogNumber;
        }

        public string getTitle()
        {
            return this.title;
        }

        public string getAuthor()
        {
            return this.author;
        }

        public string getCategory()
        {
            return this.category;
        }

        public string getLabel()
        {
            return this.label;
        }

        public int getISBN()
        {
            return this.isbn;
        }

        public string getReleaseDate()
        {
            return this.releaseDate;
        }

        public int getCatalogNumber()
        {
            return this.catalogNumber;
        }

    }
}
