using System;

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
        public void AddBook()
        {
            id = InputIntExecption("Nhập id sách: ");
            Console.Write("Nhập tiêu đề sách: ");
            title = Console.ReadLine();
            while (title.Trim() == "")
            {
                Console.Write("Sai. Nhập lại: ");
                title = Console.ReadLine();
            }
            Console.Write("Nhập nhà xuất bản sách: ");
            author = Console.ReadLine();
            while (author.Trim() == "")
            {
                Console.Write("Sai. Nhập lại: ");
                author = Console.ReadLine();
            }
            year = InputIntExecption("Nhập năm xuất bản: ");
            price = InputIntExecption("Nhập giá bán sách: ");
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
