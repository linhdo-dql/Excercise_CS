using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Book
    {
        public string author { get; set; }
        public int pages { get; set; }
        public string isbn { get; set; }
        public string title { get; set; }
        public int currentPage { get; set; }

        public Book(string author, int pages, string isbn, string title)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
            this.currentPage = 1;
        }

        public Book()
        {

        }

        public void Display()
        {
            Console.WriteLine($"Tác giả: {author} \nSố lượng trang: {pages} \nTiêu chuẩn quốc tế: {isbn} \nTiêu đề: {title} \nTrang hiệ tại: {currentPage}");
        }
        public void flipPageForward()
        {
            currentPage = currentPage - 1;
            Console.WriteLine("Trang hiện tại: "+currentPage);
        }

        public void flipPageBackward()
        {
            currentPage = currentPage + 1;
            Console.WriteLine("Trang hiện tại: "+currentPage);
        }


    }
}
