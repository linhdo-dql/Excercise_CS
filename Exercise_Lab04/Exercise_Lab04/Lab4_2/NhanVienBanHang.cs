using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04
{
    class NhanVienBanHang: NhanVien
    {
        private int soLuongBanDuoc;

        public override void HienThi()
        {
            Console.WriteLine("{0} {1} {2} ", ten, diaChi, soLuongBanDuoc);
        }

        public override double TinhLuong()
        {
            throw new NotImplementedException();
        }
    }
}
