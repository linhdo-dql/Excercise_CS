using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04
{ 
    /// <summary>
    /// Lớp đối tượng NhanVien
    /// </summary>
    abstract class NhanVien
    {
        protected string ten;
        protected string diaChi;
        public abstract double TinhLuong();
        public abstract void HienThi();
    }
}
