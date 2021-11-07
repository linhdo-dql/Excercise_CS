using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab08
{
    /// <summary>
    /// Bài 8.1 trong Lab08
    /// Yêu Cầu:
    /// Tạo lớp Book(id, name, author, price, publisher, year) lưu thông tin về sách.
    /// Khởi tạo mảng 10 quyển sách.
    /// Sử dụng câu truy vấn LINQ để thực hiện các thao tác trên mảng sách vừa tạo:
    /// Hiển thị tất cả các quyển sách
    /// Hiển thị những quyển sách có giá từ 1000-5000
    /// Hiển thị những quyển sách xuất bản năm 2015
    /// Hiển thị những quyển sách có tên Lập trình
    /// Đếm các quyển sách của nhà xuất bản Giáo Dục.
    /// </summary>
    class Lab8_1
    {
        public void ShowResult()
        {
            Book[] books = InitArrayBook();

            ///Hiển thị tất cả các quyển sách
            Console.WriteLine("a. Hiển thị tất cả quyển sách: ");
            var querySelect = from b in books select b;
            Display(querySelect);

            ///Hiển thị những quyển sách có giá từ 1000-5000
            Console.WriteLine("b. Sách có giá từ 1000 - 5000 là: ");
            var priceFrom1000To5000 = books.Where((b) => { return b.price >= 1000 && b.price <= 5000; });
            Display(priceFrom1000To5000);

            /// Hiển thị những quyển sách xuất bản năm 2015
            Console.WriteLine("c. Sách xuất bản năm 2015 là: ");
            var year2015 = books.Where((b) => { return b.year == 2015; });
            Display(year2015);

            /// Hiển thị những quyển sách có tên Lập trình
            Console.WriteLine("d. Sách có tên Lập trình là: ");
            var bookOfName = books.Where((b) => { return b.name.Contains("Lập trình"); });
            Display(bookOfName);

            /// Đếm các quyển sách của nhà xuất bản Giáo Dục.
            Console.WriteLine("e. Số lượng sách của nhà xuất bản giáo dục là: " + books.Count((b) => b.publisher.Equals("Giáo Dục")));
        }
        public void Display(dynamic query)
        {
            foreach (var book in query)
            {
                Console.WriteLine(book);
            }

        }
        /// <summary>
        /// Khởi tạo mảng 10 quyển sách.
        /// </summary>
        /// <returns></returns>
        public Book[] InitArrayBook()
        {
            var books = new Book[]
            {
                new Book(101,"Doraemon","Fujio",5000,"Kim Đồng",1999),
                new Book(102,"Pokemon","Hasaki",3000,"Nhi Đồng",2015),
                new Book(103,"7 viên ngọc rồng","Songoku",8000,"Kim Đồng",1998),
                new Book(104,"Conan","Watashi",10000,"Thiêu Nhi",2009),
                new Book(105,"Thần đồng đất Việt","Halo",5000,"Giáo Dục",1999),
                new Book(106,"Ô Long Viện","Haha",4000,"Giáo Dục",1997),
                new Book(107,"Jindo","Mela",6000,"Nhi Đồng",1999),
                new Book(108,"Lập trình hướng đối tượng","India",9000,"Giáo Dục",2000),
                new Book(109,"Shin","Shin nosuke",7000,"Kim Đồng",1999),
                new Book(110,"Kỹ thuật Lập trình cơ sở","Fujio",15000,"Kim Đồng",2005),
            };
            return books;
        }

    }
}
