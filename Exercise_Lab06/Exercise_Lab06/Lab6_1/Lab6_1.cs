using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab06.Lab6_1
{
    /// <summary>
    /// Bài 6.1 trong Lab06
    /// Yêu cầu:
    /// Tạo 1 collections Book
    /// In danh sách sách theo giá tăng dần
    /// Tìm sách theo title
    /// Đưa ra quyển sách xuất bản năm 2004
    /// Xóa những quyển sách của nhà suất bản "Nhi Dong"
    /// </summary>
    class Lab6_1
    {
        public void ShowResult()
        {
            List<Book> b = InitCollection();
            Console.WriteLine("a. Tạo Collections: ");
            Display(b);
            Console.WriteLine("b. Danh sách sách sắp xếp theo giá tăng dần: ");
            Display(ColectionPriceIncrease(b));
            Console.WriteLine("c. Nhập tên sách: ");
            string title = Console.ReadLine();
            Console.WriteLine(FindBook(b, title) != null ? FindBook(b, title).ToString() : $"Không có sách nào có tên {title}.");
            Console.WriteLine("d. Danh sách sách năm 2004: ");
            if (BookIn2004(b).Count!=0)
            {
                Display(BookIn2004(b));
            }
            else
            {
                Console.WriteLine("Không có quyển sách nào xuất bản năm 2004.");
            }
            Console.WriteLine("e. Danh sách sách sau khi xóa các sách cảu nhà xuất bản 'Nhi Dong': ");
            Display(DeleteBooks(b));
        }
        /// <summary>
        /// Phương thức khởi tạo 1 Collection
        /// </summary>
        public List<Book> InitCollection()
        {
            List<Book> books = new List<Book>()
            {
                new Book() {id=123,title="hello kitty",author="Mavel",price=12000,year=2031},
                new Book() {id=125,title="than dong dat viet",author="Nhi Dong",price=15000,year=2011},
                new Book() {id=124,title="doraemon",author="Kim Dong",price=11000,year=2009},
                new Book() {id=120,title="dragon ball",author="Namec",price=25000,year=2019},
                new Book() {id=121,title="money",author="Hama",price=12000,year=2031},
                new Book() {id=126,title="ban tre oi",author="Nhi Dong",price=15000,year=2021},
                new Book() {id=129,title="no name",author="Kim Dong",price=11000,year=2004},
                new Book() {id=127,title="perfect",author="Halo",price=25000,year=1992},
                new Book() {id=122,title="like and like",author="Mavel",price=12000,year=2011},
                new Book() {id=128,title="hahaha",author="DC",price=15000,year=2008}
            };
            return books;
        }
        public void Display(List<Book> books)
        {
            foreach (Book b in books)
            {
                Console.WriteLine(b.ToString());
            }
        }
        /// <summary>
        /// In danh sách sách theo giá tăng dần
        /// </summary>
        public List<Book> ColectionPriceIncrease(List<Book> books)
        {
            //Cách 1: 
            books.Sort(
                (p1, p2) =>
                {
                    if (p1.price > p2.price)
                    {
                        return 1;
                    }
                    else if (p1.price == p2.price)
                    {
                        return 0;
                    }
                    return -1;
                }
            );
            //Cách 2: 
           /* for (int i = 0; i< books.Count - 1; i++)
            {
                for(int j = i+1; j< books.Count; j++)
                {
                    if(books[i].price>books[j].price)
                    {
                        Book s = books[i];
                        books[i] = books[j];
                        books[j] = s;
                    }
                }
            }*/
            return books;
        }
        /// <summary>
        /// Tìm sách theo tiêu đề
        /// </summary>
        /// <param name="books"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public Book FindBook(List<Book> books, string title)
        {   
            //Cách 1:
            return books.Find((b) => { return b.title == title; });
            //Cách 2:
            /*foreach(Book b in books)
             {
                 if(title.Equals(b.title))
                 {
                     return b;
                 }
             }
            return null;*/
        }
        /// <summary>
        /// Lấy danh sách các quyển sách năm 2004
        /// </summary>
        /// <param name="books"></param>
        public List<Book> BookIn2004(List<Book> books)
        {   
            //Cách 1:
            return books.FindAll((e) => { return e.year == 2004; });
            //Cách 2:
            /*foreach (Book b in books)
            {
                if (b.year == 2004)
                {
                    Console.WriteLine(b.ToString());
                }
            }*/
        }
        /// <summary>
        /// Xóa những sách của nhà suất bản "Nhi Dong"
        /// </summary>
        /// <param name="books"></param>
        /// <returns></returns>
        public List<Book> DeleteBooks(List<Book> books)
        {   
            //Cách 1:
            books.RemoveAll((b) => { return b.author == "Nhi Dong"; });
            return books;
            //Cách 2:
            //return books.FindAll((b) => { return b.author != "Nhi Dong"; });
            //Cách 3:
            /*int length = books.Count;
            for (int i = 0; i < length; i++)
            {
                if (books[i].author.Equals("Nhi Dong"))
                {
                    books.RemoveAt(i);
                    i--;
                    length--;
                }
            }
            return books;*/
           
        }
    }
}
