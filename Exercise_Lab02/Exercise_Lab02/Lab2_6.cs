using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab02
{
    /// <summary>
    /// Bài 2.6 trong Lab02
    /// Yêu cầu: Viết chương trình nhập vào 3 số nguyên a, b, c. 
    /// Xét xem a,b,c có tạo thành độ dài 3 cạnh của một tam giác không?.
    /// Nếu là a,b,c là độ dài 3 cạnh của tam giác thì xét xem tam giác gì.
    /// Input: 3 số a,b,c
    /// Output: Tạo thành tam giác không? Tam giác gì?(Nếu có).
    /// </summary>
    class Lab2_6
    {
        /// <summary>
        /// Kiểm tra điều kiện hình thành 1 tam giác
        /// </summary>
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
        /// <summary>
        /// Kiểm tra tính chất của tam giác
        /// </summary>
        public void Triangle()
        {
            int a = 0, b = 0, c = 0;
            Input(a);
            Input(b);
            Input(c);
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
        /// <summary>
        /// Tính bình phương 1 số
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private double Pows(int number)
        {
            return Math.Pow(number, 2);
        }
        public void Input(int number)
        {
            do
            {
                number = -1;
                try
                {
                    Console.WriteLine("Nhập độ dài cạnh: ");
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Độ dài cạnh phải là số!");
                }
            }
            while (number < 0);
        }
    }

}
