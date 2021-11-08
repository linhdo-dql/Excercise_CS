using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab05
{
    /// <summary>
    /// Bài 5.2 trong Lab05
    /// Yêu cầu:
    /// Hiện mảng theo dạng dòng cột
    /// Tính tổng các phần tử có index row = index column
    /// Tìm phần tử nhỏ nhất trong các cột
    /// Tìm các phần tử chia hết cho 7
    /// Tính tổng các phần tử ở đường viền mảng
    /// Chuyển thành mảng 1 chiều rồi sắp xếp
    /// </summary>
    class Lab5_2
    {
        public void ShowResult()
        {
            int[,] arr = InputArray();
            Console.WriteLine("--------------3.2-------------");
            Console.WriteLine("a. Mảng: ");
            ShowArray(arr);
            Console.WriteLine("b. Tổng các phần tử có chỉ số hàng bằng chỉ số cột: " + SumColumIndexEqualsRowIndex(arr));
            Console.WriteLine("c. Phần tử nhỏ nhất trên cột: ");
            FindMinInColumns(arr);
            Console.Write("d. Các phần tử chia hết cho 7 là: ");
            GetItemDivisibleOf7(arr);
            Console.WriteLine();
            Console.WriteLine("e. Tổng các phần tử ở đường viền mảng: " + SumOfItemInBorderArray(arr));
            Console.WriteLine("f. Mảng 2 chiều thành mảng 1 chiều rồi sắp xếp: ");
            ShowArray1D(Convert2DArrayTo1DArray(arr));
        }
        /// <summary>
        /// Hiển thị mảng 1 chiều
        /// </summary>
        /// <param name="arr"></param>
        public void ShowArray1D(int[] arr)
        {
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
        }/// <summary>
        /// Hiển thị mảng 2 chiều
        /// </summary>
        /// <param name="arr"></param>
        public void ShowArray(int[,] arr)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0, -4} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Nhập mảng
        /// </summary>
        public int[,] InputArray()
        {
            int[,] arr = new int[4,4];
            for (int i = 0; i < 4; i++)
            {  
                for(int j =0; j<4; j++)
                {
                    bool check = false;
                    Console.Write("a[{0},{1}] = ", i, j);
                    while (!check)
                    {
                        try
                        {
                            arr[i,j] = Convert.ToInt32(Console.ReadLine());
                            check = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Nhập sai vui lòng nhập lại: ");
                            check = false;
                        }
                    }
                }    

            }
            return arr;
        }
        /// <summary>
        /// Tính tổng các phần tử có index row = index column
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int SumColumIndexEqualsRowIndex(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            return sum;
        }
        /// <summary>
        /// Tìm giá trị nhỏ nhất trên mỗi cột
        /// </summary>
        /// <param name="arr"></param>
        public void FindMinInColumns(int[,] arr)
        {
            for (int i = 0; i < 4; i++)
            {
                int min = arr[0, i];
                for (int j = 1; j < 4; j++)
                {
                    if (arr[j, i] < min)
                    {
                        min = arr[j, i];
                    }
                }
                Console.WriteLine("Cột {0} là: {1}", i + 1, min);
            }
        }
        /// <summary>
        /// Đếm số lượng các hần tử chia hết cho 7
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public void GetItemDivisibleOf7(int[,] arr)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (arr[i, j] % 7 == 0)
                    {
                        Console.Write(arr[i, j]+" ,");
                    }
                }
            }
        }
        /// <summary>
        /// Tính tổng các phần tử nhằm ở đường viền mảng
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int SumOfItemInBorderArray(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0 || j == 0 || i == 3 || j == 3)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            return sum;
        }
        /// <summary>
        /// Chuyển mảng 2 chiều thành mảng 1 chiều rồi sắp xếp
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] Convert2DArrayTo1DArray(int[,] arr)
        {
            List<int> arr1D = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr1D.Add(arr[i, j]);
                }
            }
            arr1D.Sort();
            return arr1D.ToArray();
        }
    }
}
