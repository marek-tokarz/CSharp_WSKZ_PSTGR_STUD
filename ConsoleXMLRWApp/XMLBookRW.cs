using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace ConsoleXMLRWApp
{
    public class XMLBookRW : BookShopRW
    {
        public override void readFromXMLFile()
        {
            XmlDocument xdoc = new XmlDocument();
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "Books.xml");
            XmlNodeList xNodeList;
            string str = null;
            FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
            xdoc.Load(fs);
            xNodeList = xdoc.GetElementsByTagName("book");
            for (int i = 0; i < xNodeList.Count; i++)
            {
                Console.WriteLine("===========");
                Console.WriteLine("book " + i);
                Console.WriteLine("===========");
                for (int j = 0; j<7;j++)
                {
                    str = xNodeList[i].ChildNodes.Item(j).InnerText.Trim() + " ";
                    Console.WriteLine(str);
                }
            }
        }

        public override void writeToXMLFile(BookProduct bookProduct)
        {
            XmlDocument xdoc = new XmlDocument();
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "Books.xml");
            xdoc.Load(fullPath);
            XmlNode xBookElement = xdoc.CreateNode(XmlNodeType.Element, "book", null);
            XmlNode xTitle = xdoc.CreateNode(XmlNodeType.Element, "title", null);
            XmlNode xAuthor = xdoc.CreateNode(XmlNodeType.Element, "author", null);
            XmlNode xCategory = xdoc.CreateNode(XmlNodeType.Element, "category", null);
            XmlNode xLabel = xdoc.CreateNode(XmlNodeType.Element, "label", null);
            XmlNode xISBN = xdoc.CreateNode(XmlNodeType.Element, "isbn", null);
            XmlNode xReleaseDate = xdoc.CreateNode(XmlNodeType.Element, "releaseDate", null);
            XmlNode xCatalogNumber = xdoc.CreateNode(XmlNodeType.Element, "catalogNumber", null);

            xBookElement.AppendChild(xTitle);
            xTitle.InnerText = bookProduct.getTitle();

            xBookElement.AppendChild(xAuthor);
            xAuthor.InnerText = bookProduct.getAuthor();

            xBookElement.AppendChild(xCategory);
            xCategory.InnerText = bookProduct.getCategory();

            xBookElement.AppendChild(xLabel);
            xLabel.InnerText = bookProduct.getLabel();

            xBookElement.AppendChild(xISBN);
            xISBN.InnerText = bookProduct.getISBN().ToString();

            xBookElement.AppendChild(xReleaseDate);
            xReleaseDate.InnerText = bookProduct.getReleaseDate();

            xBookElement.AppendChild(xCatalogNumber);
            xCatalogNumber.InnerText = bookProduct.getCatalogNumber().ToString();

            xdoc.DocumentElement.AppendChild(xBookElement);
            xdoc.Save(fullPath);
        }

    }
}
