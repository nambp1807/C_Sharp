using System;
using System.Collections.Generic;

namespace t1904a.lab5
{
    public class QuanLyVN
    {
        List<KhachHangVn> khList = new List<KhachHangVn>();

        public QuanLyVN()
        {
        }

        public QuanLyVN(List<KhachHangVn> khList)
        {
            KhList = khList;
        }

        internal List<KhachHangVn> KhList { get => khList; set => khList = value; }

        public void addKH(KhachHangVn kh)
        {            
            KhList.Add(kh);
        }

        public float totalQ()
        {
            float total = 0;
            foreach (KhachHangVn k in KhList)
            {
                total += k.Sl;
            }
            return total;
        }

        public void getInfo()
        {
            int count = 0;
            Console.WriteLine("Nhap thang va nam gioi han: (MM/yyyy)"); 
            String[] s = Console.ReadLine().Split("/", StringSplitOptions.RemoveEmptyEntries);
            foreach (KhachHangVn k in KhList)
            {
                if (k.NgayXuat.Month == Convert.ToInt32(s[0]) && k.NgayXuat.Year == Convert.ToInt32(s[1]))
                {
                    k.getInfo();
                    count++;
                }
            }
            if (count == 0) Console.WriteLine("Khong co hoa don phu hop");
        }
    }
}