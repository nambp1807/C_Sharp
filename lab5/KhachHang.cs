using System;

namespace t1904a.lab5
{
    public class KhachHang
    {
        private int id;
        private string ten;
        private DateTime ngayXuat;
        private float sl;
        private static int[] donGia = { 1000,1200,1500,2000};
        private static int[] dinhMuc = { 50,100,200 };
        private double thanhTien;

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime NgayXuat { get => ngayXuat; set => ngayXuat = value; }
        
        public static int[] DonGia { get => donGia; set => donGia = value; }
        public static int[] DinhMuc { get => dinhMuc; set => dinhMuc = value; }
        public float Sl { get => sl; set => sl = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }

        public KhachHang()
        {
        }

        public KhachHang(int id, string ten, DateTime ngayXuat, float sl)
        {
            Id = id;
            Ten = ten;
            NgayXuat = ngayXuat;
            Sl = sl;
        }

        public double CalMoney()
        {
            double money = 0;
            if(Sl < DinhMuc[0])
            {
                money = DonGia[0] * Sl;
            }
            else if(Sl < DinhMuc[1])
            {
                money = DonGia[0] * 50 + DonGia[1] * (Sl - 50) ;
            }
            else if(Sl < DinhMuc[2])
            {
                money = DonGia[0] * 50 + DonGia[1] * 50 + DonGia[2] * (Sl - 100);
            }
            else
            {
                money = DonGia[0] * 50 + DonGia[1] * 50 + DonGia[2] * 100 + DonGia[3] * (Sl - 200);
            }

            return money;
        }
    }
}