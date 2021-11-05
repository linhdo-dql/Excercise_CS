using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04
{  
    /// <summary>
    /// Lớp đối tượng NhanVienBanHang
    /// </summary>
    class NhanVienBanHang: NhanVien
    {
        private int soLuongBanDuoc;
        /// <summary>
        /// Phương thức hiển thị thông tin NhanVienBanHang
        /// Ghi đè phương thức trừu tượng từ lớp NhanVien
        /// </summary>
        public override void HienThi()
        {
            Console.WriteLine("{0} {1} {2} ", ten, diaChi, soLuongBanDuoc);
        }
        /// <summary>
        /// Phương thức TinhLuong
        /// Ghi đè phương thức trừu tượng từ lớp NhanVien
        /// </summary>
        /// <returns></returns>
        public override double TinhLuong()
        {
            throw new NotImplementedException();
        }
    }
}
