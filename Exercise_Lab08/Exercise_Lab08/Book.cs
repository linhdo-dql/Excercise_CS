using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab08
{
    /// <summary>
    /// Tạo lớp Book(id, name, author, price, publisher, year) lưu thông tin về sách.
    /// </summary>
    class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public int price { get; set; }
        public string publisher { get; set; }
        public int year { get; set; }
        public Book()
        {
        }
        public Book(int id, string name, string author, int price, string publisher, int year)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.price = price;
            this.publisher = publisher;
            this.year = year;
        }
        public override string ToString()
        {
            return $"Book[{id}, {name}, {author}, {price}, {publisher}, {year}]";
        }
    }
}
