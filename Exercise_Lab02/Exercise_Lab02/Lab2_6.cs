using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab02
{
    class Lab2_6
    {   
        //Kiểm tra điều kiện hình thành 1 tam giác
        private bool CheckTriangle(int a, int b, int c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a) && a * b * c > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Triangle()
        {
            Console.WriteLine("Nhập cạnh a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập cạnh b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập cạnh c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (CheckTriangle(a, b, c))
            {
                if (a == b || b == c || c == a)
                {
                    Console.WriteLine("Tam giác cân");
                }
                else if (a == b && b == c)
                {
                    Console.WriteLine("Tam giác đều");
                }
                else if ((Pows(a) == Pows(b) + Pows(c)) || (Pows(b) == Pows(a) + Pows(c)) || (Pows(c) == Pows(a) + Pows(b)))
                {
                    Console.WriteLine("Tam giác vuông");
                }
                else
                {
                    Console.WriteLine("Tam giác thường");
                }

            }
            else
            {
                Console.WriteLine("Không phải tam giác!");
            }
        }
        //Tính bình phương một số
        private double Pows(int number)
        {
            return Math.Pow(number, 2);
        }
    }

}
