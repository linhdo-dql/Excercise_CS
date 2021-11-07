using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab06.Lab6_2
{   
    /// <summary>
    /// Bài 6.2 trong Lab06
    /// Tạo một hashtable lưu danh sách các ngày trong tuần với key từ 1-8
    /// Tìm ngày TueDay, in ra thông báo nếu tìm thấy hoặc không
    /// In ra các ngày trong tuần bao gồm cả key và value.
    /// </summary>
    class Lab6_2
    {
        public void ShowResult()
        {
            Hashtable h = InitHashtable();
            Console.WriteLine("a.");
            Console.WriteLine(FindOnHashtable(h,"Tueday")?"Tìm thấy Tueday":"Không tìm thấy Tueday");
            Console.WriteLine("b.");
            //In ra các phần tử không tuần tự, tối ưu hóa tốc độ xử lý
            ShowHashtable(h);
        }
        /// <summary>
        ///Tạo một hashtable lưu danh sách các ngày trong tuần với key từ 1-8
        /// </summary>
        /// <returns></returns>
        public Hashtable InitHashtable()
        {
            Hashtable h = new Hashtable();
            h["1"] = "Monday";
            h["2"] = "Tuesday";
            h["3"] = "Wednesday";
            h["4"] = "Thursday";
            h["5"] = "Friday";
            h["6"] = "Friday";
            h["7"] = "Saturday";
            h["8"] = "Sunday";
            return h;
        }
        /// <summary>
        /// Tìm ngày trong tuần
        /// </summary>
        /// <param name="h"></param>
        /// <param name="dayInWeek"></param>
        /// <returns></returns>
        public bool FindOnHashtable(Hashtable h, string dayInWeek)
        {
            //Cách 1:
            return h.ContainsValue(dayInWeek);
            //Cách 2:
            /*var values = h.Values;
            foreach(var v in values)
            {
                if(v.ToString() == dayInWeek)
                {
                    return true;
                }
            }
            return false;*/
        }
        /// <summary>
        /// In ra các ngày trong tuần bao gồm cả key và value.
        /// </summary>
        /// <param name="h"></param>
        public void ShowHashtable(Hashtable h)
        {
            foreach(DictionaryEntry ht in h)
            {
                Console.WriteLine($"Key: {ht.Key}, Value: {ht.Value}");
            }
        }
    }
}
