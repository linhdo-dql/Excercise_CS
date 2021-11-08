using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab05
{   
    /// <summary>
    /// Bài 5.1 trong Lab05
    /// Yêu cầu:
    /// Nhập hiện mảng
    /// Tìm giá trị nhỏ nhất trong mảng
    /// Đảo các phần tử trong mảng
    /// Sắp xếp mảng tăng, giảm
    /// Tìm các số nguyên tố trong Mảng
    /// Số lượng các sô dương liên tiếp nhiều nhất
    /// Trung bình cộng các phần tử dương trong mảng
    /// Mảng có các phần tử âm dương đan xen?
    /// </summary>
    class Lab5_1
    {
        public void ShowResult()
        {
            Console.WriteLine("Nhập mảng: ");
            int[] arr = InputArray();
            int[] arr2 = (int[])arr.Clone();
            Console.WriteLine("--------3.1----------");
            Console.WriteLine("Mảng: ");
            ShowArray(arr);
            Console.WriteLine();
            Console.WriteLine("a. Giá trị nhỏ nhất của mảng là: " +Min(arr));
            Console.Write("b. Mảng sau khi đảo các giá trị: ");
            ShowArray(ExchangeArray(arr));
            Console.WriteLine();
            Console.WriteLine("c. Mảng sau khi sắp xếp: ");
            Console.Write("Tăng: ");
            ShowArray(SortIncreaseOrDecrease(arr, true));
            Console.WriteLine();
            Console.Write("Giảm: ");
            ShowArray(SortIncreaseOrDecrease(arr, false));
            Console.WriteLine();
            Console.Write("d. Các số nguyên tố trong mảng: ");
            GetPrime(arr);
            Console.WriteLine();
            Console.WriteLine("e. Số lượng các số dương liên tiếp nhiều nhất là: " + CheckAmountPositive(arr2));
            Console.WriteLine("f. Trung bình cộng các phần tử dương: "+AvgPositiveItem(arr2));
            Console.WriteLine("g. Mảng âm dương đan xen? " +(CheckPositiveNegativeIntertwined(arr2) ? "Có" : "Không"));
        }
        /// <summary>
        /// Nhập mảng
        /// </summary>
        public int[] InputArray()
        {
            int[] arr = new int[10];
            for(int i = 0; i<10; i++)
            {
                bool check = false;
                Console.Write("a[{0}] = ", i);
                while (!check)
                {
                    try
                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                        check = true;
                    }
                    catch (FormatException)
                    {   
                        Console.WriteLine("Nhập sai vui lòng nhập lại: ");
                        check = false;
                    }
                }
                
            }
            return arr;
        }
        /// <summary>
        /// Phương thức hiện mảng
        /// </summary>
        public void ShowArray(int[] arr)
        {
            foreach(int x in arr)
            {
                Console.Write(x + " ");
            }
        }
        /// <summary>
        /// Phương thức tìm Min trong mảng
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int Min(int[] arr)
        {
            return arr.Min();
            /*int min = arr[0];
            for(int i = 1; i< arr.Length-1; i++)
            {
                if(min>arr[i])
                {
                    min = arr[i];
                }
            }
            return min;*/
        }
        /// <summary>
        /// Phương thức đảo mảng
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] ExchangeArray(int[] arr)
        {
            Array.Reverse(arr);
           /* for(int i = 0; i< arr.Length/2; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = tmp;
            }*/
            return arr;
        }
        /// <summary>
        /// Phương thức sắp xếp mảng tăng hoặc giảm dần
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public int[] SortIncreaseOrDecrease(int[] arr, bool type)
        {   
            Array.Sort(arr);
            if(!type)
            {
                Array.Reverse(arr);
            }
            /*for(int i =0; i<arr.Length-1; i++)
            {
                for(int j = i+1; j<arr.Length; j++)
                {
                    if(type)
                    {
                        if(arr[i]>arr[j])
                        {
                            int tmp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = tmp;
                        }
                    }
                    else
                    {
                        if (arr[i] < arr[j])
                        {
                            int tmp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = tmp;
                        }
                    }    
                }
            } */   
            return arr;
        }
        /// <summary>
        /// Phương thức tim số nguyên tố trong mảng
        /// </summary>
        /// <param name="arr"></param>
        public void GetPrime(int[] arr)
        {
            List<int> primes = new List<int>();
            for(int i =0; i< arr.Length; i++)
            {
                if (arr[i] >= 2 && CheckPrime(arr[i]))
                {
                    Console.Write(arr[i] + " , ");
                }
            }
        }
        /// <summary>
        /// Phương thức kiểm tra số nguyên tố
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool CheckPrime(int number)
        {
            for(int i = 2; i< Math.Sqrt(number); i++)
            {
                if(number%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Phương thức đếm số dương liên tiếp 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int CheckAmountPositive(int[] arr)
        {
            int amount = 0;
            List<int> amounts = new List<int>();
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]>0) 
                { 
                    amount = amount +1;
                }
                else
                {
                    amounts.Add(amount);
                    amount = 0;
                }
            }
            amounts.Sort();
            return amounts[amounts.Count-1];
        }
        /// <summary>
        /// Phương thức tính trung bình cộng các số dương
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public float AvgPositiveItem(int[] arr)
        {
            int sum = 0;
            int positive = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]>0)
                {
                    sum += arr[i];
                    positive++;
                }
            }
            return sum / positive;
        }
        /// <summary>
        /// Phương thức kiểm tra âm dương đan xen hay không?
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool CheckPositiveNegativeIntertwined(int[] arr)
        {
            int intertwined = 1;
            for (int i=0; i<arr.Length-1; i++)
            {
                if ((arr[i] > 0 && arr[i + 1] > 0) || (arr[i + 1] < 0 && arr[i] < 0))
                {
                    intertwined = 0;
                    break;
                }
            }
            return intertwined == 1 ? true : false;
        }
    }
}
