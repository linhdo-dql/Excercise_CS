using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Lab3_2
    {
        public void ReadBook()
        {
            Book book1 = new Book("Lê Văn Lan",500,"ICPCC","Làm gì thì làm");
            book1.Display();
            string flip = "";
            do
            {
                Console.WriteLine("Lật trang trước hoặc sau ('t' hoặc 's'):");
                flip = Console.ReadLine();
                if(flip=="s")
                {
                    book1.flipPageBackward();
                }
                else if(flip=="t")
                {
                    book1.flipPageForward();
                }
            } while (flip != "");
        }
    }
}
