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
        public void AddBook()
        {
            id = InputIntExecption("Nhập id sách: ");
            Console.Write("Nhập tiêu đề sách: ");
            name = Console.ReadLine();
            while (name.Trim() == "")
            {
                Console.Write("Sai. Nhập lại: ");
                name = Console.ReadLine();
            }
            Console.Write("Nhập tác giả bản sách: ");
            author = Console.ReadLine();
            while (author.Trim() == "")
            {
                Console.Write("Sai. Nhập lại: ");
                author = Console.ReadLine();
            }
            price = InputIntExecption("Nhập giá bán sách: ");
            Console.Write("Nhập nhà xuất bản sách: ");
            publisher = Console.ReadLine();
            while (publisher.Trim() == "")
            {
                Console.Write("Sai. Nhập lại: ");
                publisher = Console.ReadLine();
            }
            year = InputIntExecption("Nhập năm xuất bản: ");
           
        }
        public int InputIntExecption(string message)
        {
            dynamic tmp;
            Console.Write(message);
            tmp = Console.ReadLine();
            while (!int.TryParse(tmp, out int value))
            {
                Console.Write("Sai. Nhập lại: ");
                tmp = Console.ReadLine();
            }
            return int.Parse(tmp);
        }


    }
}
