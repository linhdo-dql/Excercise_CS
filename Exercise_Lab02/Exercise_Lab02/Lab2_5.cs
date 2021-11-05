using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab02
{   
    /// <summary>
    /// Bài 2.5 trong Lab02
    /// Yêu cầu: Vẽ một số hình bằng thuật toán
    /// </summary>
    class Lab2_5
    {   
        /// <summary>
        /// Vẽ tam giác dấu * đáy hướng xuống dưới
        /// </summary>
        public void Lab2_5a()
        {
            for(int i =0; i<=6; i++)
            {   
                for(int j =0; j < i; j++)
                {
                    Console.Write("*");
                }
               
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Vẽ tam giác dấu $ đáy hướng lên trên
        /// </summary>
        public void Lab2_5b()
        {
            for (int i = 6; i >= 1; i--)
            {
                for (int k = i; k >= 1; k--)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Vẽ tam giác cân * đáy hướng xuống dưới
        /// </summary>
        public void Lab2_5c()
        {
            for(int i =0; i<=6; i++)
            {
                for(int j = i; j < 6; j++) {
                    Console.Write(" "); ;
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
