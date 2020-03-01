using System;

namespace t1904a.lab5
{
    public class Program
    {
        static void Main(string[] args)
        {
            KhachHangVn k1 = new KhachHangVn(0, "Nam", new DateTime(2020, 01, 01), 220, "sinh hoat");
            KhachHangNn k2 = new KhachHangNn(0, "Tùng", new DateTime(2020, 01, 01), 220, "Mỹ");            
            KhachHangVn k3 = new KhachHangVn(0, "Anh", new DateTime(2020, 02, 01), 220, "sinh hoat");
            QuanLyVN qlvn = new QuanLyVN();
            QuanLyNN qlnn  = new QuanLyNN();
            qlvn.addKH(k1);
            qlvn.addKH(k3);
            qlnn.addKH(k2);
            qlvn.getInfo();
            qlnn.getInfo();
        }
    }
}