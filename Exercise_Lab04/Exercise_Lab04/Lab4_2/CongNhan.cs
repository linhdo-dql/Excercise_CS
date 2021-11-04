using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04.Lab4_2
{
    class CongNhan: NhanVien
    {
        private int soLuongSanPham { get; set; }

        public override void HienThi()
        {
            Console.WriteLine("{0} {1} {2} ", ten, diaChi, soLuongSanPham); throw new NotImplementedException();
        }

        public override double TinhLuong()
        {
            throw new NotImplementedException();
        }
    }
}
