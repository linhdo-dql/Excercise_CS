using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04.Lab4_3
{   
    /// <summary>
    /// Interface cho việc quản lý lưu trữ dữ liệu
    /// </summary>
    interface IStorage
    {
        object data { get; }
        void Read(string fileName);
        void Write(string fileName);
    }
}
