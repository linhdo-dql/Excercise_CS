using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{   
    /// <summary>
    /// Lớp đối tượng Book
    /// </summary>
    class Book
    {   
        /// <summary>
        /// Khai báo và cài đặt các hàm get, set tự động cho đối tượng
        /// </summary>
        public string author { get; set; }
        public int pages { get; set; }
        public string isbn { get; set; }
        public string title { get; set; }
        public int currentPage { get; set; }
        /// <summary>
        /// Hàm khởi tạo cho đối tượng
        /// </summary>
        public Book(string author, int pages, string isbn, string title)
        {
            this.author = author;
            this.pages = pages;
            this.isbn = isbn;
            this.title = title;
            this.currentPage = 1;
        }
        /// <summary>
        /// Hàm khởi tạo không tham số
        /// </summary>
        public Book()
        {

        }
        /// <summary>
        /// Phương thức hiển thị thông tin đối tượng ra màn hình
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"Tác giả: {author} \nSố lượng trang: {pages} \nTiêu chuẩn quốc tế: {isbn} \nTiêu đề: {title} \nTrang hiệ tại: {currentPage}");
        }
        /// <summary>
        /// Phương thức lật trang trước
        /// </summary>
        public void flipPageForward()
        {
            currentPage = currentPage - 1;
            Console.WriteLine("Trang hiện tại: "+currentPage);
        }
        /// <summary>
        /// Phương thức lật trang sau
        /// </summary>
        public void flipPageBackward()
        {
            currentPage = currentPage + 1;
            Console.WriteLine("Trang hiện tại: "+currentPage);
        }


    }
}
