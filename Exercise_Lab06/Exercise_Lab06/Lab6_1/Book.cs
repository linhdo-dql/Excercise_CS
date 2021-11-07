using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab06.Lab6_1
{
    /// <summary>
    /// Lớp đối tượng Book
    /// </summary>
    class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int year { get; set; }
        public int price { get; set; }

        public Book()
        {
        }

        public Book(int id, string title, string author, int year, int price)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.year = year;
            this.price = price;
        }
        //ghi đè phương thức toString()
        public override string ToString()
        {
            return $"Book[{id}, {title}, {author}, {year}, {price}]";
        }
       
    }
}
