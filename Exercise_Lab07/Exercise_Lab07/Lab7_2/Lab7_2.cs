using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab07.Lab7_2
{
    /// <summary>
    /// Bài 7.2 trong Lab07
    /// Yêu cầu:
    /// Sử dụng các ngoại lệ
    /// InvalidCastException.
    /// IndexOutOfRangeException.
    /// ArrayTypeMismatchException.
    /// </summary>
    class Lab7_2
    {
        public void ShowResult()
        {
            UsingInvalidCastException();
            UsingIndexOutOfRangeException();
            UsingArrayTypeMismatchException();
        }
        /// <summary>
        /// InvalidCastException
        /// Lỗi xảy ra khi ép kiểu
        /// </summary>
        public void UsingInvalidCastException()
        {
            bool check = true;
            try
            {
                Char s = Convert.ToChar(check);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine(e.StackTrace);
            }
            try
            {
                Char s = Convert.ToChar(check);
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine("Lỗi xảy ra khi ép kiểu"+ ice.StackTrace);
            }
            
        }
        /// <summary>
        /// IndexOutOfRangeException
        /// Lỗi xảy ra khi truy xuất chỉ số không có/vượt quá giới hạn các phần tử trong mảng
        /// </summary>
        public void UsingIndexOutOfRangeException()
        {
            int[] arr = new int[3] { 1, 2, 3 };
            try
            {
                Console.WriteLine(arr[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine(e.StackTrace);
            }
            try
            {
                Console.WriteLine(arr[10]);
            }
            catch (IndexOutOfRangeException ioore)
            {
                Console.WriteLine("Không tìm thấy phần tử có chỉ số trên." + ioore.StackTrace);
            }
        }
        /// <summary>
        /// ArrayTypeMismatchException
        /// Lỗi xảy ra khi lưu trữ một phần tử không đúng kiểu của mảng
        /// </summary>
        public void UsingArrayTypeMismatchException()
        {
            string[] arr = { "a", "b", "c" };
            Object[] objs = (Object[])arr;
            try
            {
                objs[2] = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine(e.StackTrace);
            }
            try
            {
                objs[2] = 1;
            }
            catch (ArrayTypeMismatchException arme)
            {
                Console.WriteLine("Giá trị được gán không đúng kiểu dữ liệu của mảng." + arme.StackTrace);
            }
        }
    }
}
