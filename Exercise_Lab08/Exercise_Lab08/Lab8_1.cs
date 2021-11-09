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
        Book[] books;
        public void ShowResult()
        {
            Menu();
        }
        public void Display(dynamic query)
        {
            foreach (var book in query)
            {
                Console.WriteLine(book);
            }

        }
        public void Menu()
        {
            Console.WriteLine("-----------------------------Bài 8.1-------------------------------");
            Console.WriteLine("1. Tạo mảng Book. ");  
            Console.WriteLine("2. Hiện thị mảng Book. ");
            Console.WriteLine("3. Hiển thị những quyển sách có giá từ 1000-5000. ");
            Console.WriteLine("4. Sách xuất bản năm 2015. ");
            Console.WriteLine("5. Sách có tên Lập trình.");
            Console.WriteLine("6. Số lượng sách của nhà xuất bản giáo dục. ");
            Console.WriteLine("0. Thoát.");
            Console.WriteLine("Mời chọn: ");
            dynamic choose = Console.ReadLine();
            while (!int.TryParse(choose, out int value))
            {
                Console.Write("Sai. Nhập lại: ");
                choose = Console.ReadLine();
            }
            switch (int.Parse(choose))
            {
                case 0: break;
                case 1:
                    books = InitArrayBook();
                    Console.WriteLine();
                    Menu();
                    break;
                case 2:
                    if (books.Length != 0)
                    {
                        ///Hiển thị tất cả các quyển sách
                        Console.WriteLine("Mảng vừa tạo: ");
                        var querySelect = from b in books select b;
                        Display(querySelect);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Chưa tạo mảng.");
                    }
                    Menu();
                    break;
                case 3:
                    if (books.Length != 0)
                    {
                        ///Hiển thị những quyển sách có giá từ 1000-5000
                        var priceFrom1000To5000 = books.Where((b) => { return b.price >= 1000 && b.price <= 5000; });
                        if(priceFrom1000To5000.Count() != 0)
                        {
                            Display(priceFrom1000To5000);
                        }
                        else
                        {
                            Console.WriteLine("Không có sách nào có giá từ 1000 - 5000.");
                        }
                        
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Chưa tạo mảng.");
                    }
                    Menu();
                    break;
                case 4:
                    if (books.Length != 0)
                    {
                        /// Hiển thị những quyển sách xuất bản năm 2015
                        var year2015 = books.Where((b) => { return b.year == 2015; });
                        if (year2015.Count() != 0)
                        {
                            Display(year2015);
                        }
                        else
                        {
                            Console.WriteLine("Không có sách nào xuất bản năm 2015.");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Chưa tạo Mảng.");
                    }
                    Menu();
                    break;
                case 5:
                    if (books.Length != 0)
                    {
                        /// Hiển thị những quyển sách có tên Lập trình
                        Console.WriteLine("Sách có tên Lập trình là: ");
                        var bookOfName = books.Where((b) => { return b.name.Contains("Lập trình"); });
                        if (bookOfName.Count()==0)
                        {
                            Console.WriteLine("Không có sách có tên Lập trình.");
                        }
                        else
                        {
                            Display(bookOfName);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Chưa tạo mảng.");
                    }
                    Menu();
                    break;
                case 6:
                    if (books.Length != 0)
                    {
                        /// Đếm các quyển sách của nhà xuất bản Giáo Dục.
                        Console.WriteLine("Số lượng sách của nhà xuất bản giáo dục là: " + books.Count((b) => b.publisher.Equals("Giáo Dục")));
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Chưa tạo Mảng.");
                    }
                    Menu();
                    break;

                default: Menu(); break;
            }
        }
        /// <summary>
        /// Khởi tạo mảng 10 quyển sách.
        /// </summary>
        /// <returns></returns>
        public Book[] InitArrayBook()
        {
            Console.Write("Nhập số lượng sách: ");
            dynamic size = Console.ReadLine();
            while (!int.TryParse(size, out int value))
            {
                Console.Write("Sai. Nhập lại: ");
                size = Console.ReadLine();
            }
            size = int.Parse(size);
            books = new Book[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Sách {0}", i);
                Book b = new Book();
                b.AddBook();
                books[i] = b;
            }
            return books;
            /*var books = new Book[]
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
            return books;*/
        }

    }
}
