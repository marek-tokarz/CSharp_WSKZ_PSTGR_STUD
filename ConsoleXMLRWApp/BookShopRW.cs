using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleXMLRWApp
{
    public abstract class BookShopRW
    {
        public abstract void readFromXMLFile();

        public abstract void writeToXMLFile(BookProduct bookProduct);
    }
}
