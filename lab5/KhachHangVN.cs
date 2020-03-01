using System;
using System.Globalization;

namespace t1904a.lab5
{
    public class KhachHangVn : KhachHang
    {
        private string doiTuong;

        public string DoiTuong { get => doiTuong; set => doiTuong = value; }

        public KhachHangVn() :base()
        {
        }

        public KhachHangVn(int id, string ten, DateTime ngayXuat, float sl, string doiTuong)
            :base(id, ten, ngayXuat, sl)
        {
            DoiTuong = doiTuong;
            ThanhTien = CalMoney();
        }

        public void inputInfo()
        {
            Console.WriteLine("Nhap ID: ");
            Id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten: ");
            Ten = Console.ReadLine();
            Console.WriteLine("Nhap ngay (MM/dd/yyyy) : ");
            NgayXuat = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Nhap so luong: ");
            Sl = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap doi tuong: ");
            DoiTuong = Console.ReadLine();            
            ThanhTien = CalMoney();
        }

        public void getInfo()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Ten: " + Ten);
            Console.WriteLine("Ngay: " + NgayXuat.ToString("MM/dd/yyyy"));
            Console.WriteLine("So luong: " + Sl);
            Console.WriteLine("Doi tuong: " + DoiTuong);
            Console.WriteLine("Thanh tien: " + ThanhTien);
        }
    }
}