using System;
using System.Collections.Generic;

namespace t1904a.assignment2
{
    public class Action
    {
         public List<Product> listproduct = new List<Product>();
        public Cart c1 = new Cart();
        public Product p1 = new Product();


        public void AddCustomer()
        {
            Console.WriteLine("Nhap ID : ");
            c1.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ten kh : ");
            c1.Customer = Console.ReadLine();
            Console.WriteLine("Nhap thanh pho : ");
            c1.City = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap quoc gia : ");
            c1.Country = Convert.ToString(Console.ReadLine());

        }

        public void TotalMoney()
        {
            string str1 = "Ha Noi";
            string str2 = "HCM";
            string str3 = "Viet Nam";
            string strN = c1.City;
            string strC = c1.Country;
            int T = 0;
            if(String.Compare(strC, str3, true) == 0)
            {
                if (String.Compare(str1, strN, true) == 0 || String.Compare(str2, strN, true) == 0)
                {
                    foreach (Product i in listproduct)
                    {
                        T = i.Price + T;
                    }
                    c1.GrandTotal = T + T * 1 / 100;
                    Console.WriteLine("TotalMoney = " + c1.GrandTotal);
                }
                else
                {
                    foreach (Product i in listproduct)
                    {
                        T = i.Price + T;
                    }
                    c1.GrandTotal = T + T * 2 / 100;
                    Console.WriteLine("TotalMoney = " + c1.GrandTotal);
                }
            }
            else
            {
                foreach (Product i in listproduct)
                {
                    T = i.Price + T;
                }
                c1.GrandTotal = T + T * 5 / 100;
                Console.WriteLine("TotalMoney = " + c1.GrandTotal);
            }
        }

        public void ShowCustomer()
        {
            Console.WriteLine("ID :" + c1.id);
            Console.WriteLine("Ten kh : " + c1.Customer);
            Console.WriteLine("Thanh pho : " + c1.City);
            Console.WriteLine("Quoc gia : " + c1.Country);

        }



        public void addproduct()
        {

            Console.WriteLine("id : ");
            int a = p1.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("name : ");
            string b = p1.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("price : ");
            int c = p1.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("qty : ");
            int d = p1.Qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("image : ");
            string e = p1.Image = Convert.ToString(Console.ReadLine());
            p1.imgList.Add(p1.Image);
            Console.WriteLine("desc : ");
            string f = p1.Desc = Convert.ToString(Console.ReadLine());

            Product p = new Product(a, b, c, d, e, f);
            listproduct.Add(p);
            
        }

        public void RemoveProduct()
        {
            foreach (Product i in listproduct)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Chon sp de xoa");
            int s = Convert.ToInt32(Console.ReadLine());
            listproduct.RemoveAt(s);
            Console.WriteLine("da xoa");
            Console.WriteLine("danh sach anh da cap nhat : ");
            Console.WriteLine("ID" + " " + "Name" + " " + "Price" + " " + "image" + " " + "Qty" + " " + "Desc");
            foreach (Product i in listproduct)
            {
                Console.WriteLine(i.Id + " " + i.Name + " " + i.Price + " " + i.Image + " " + i.Qty + " " + i.Desc);
            }
        }

        public void ShowProduct()
        {
            Console.WriteLine("ID" + " "+"Name" + " " + "Price" + " " + "image" + " " + "Qty" + " " + "Desc");
            foreach (Product i in listproduct)
            {
                Console.WriteLine(i.Id + " " +i.Name + " " + i.Price + " " + i.Image + " " + i.Qty + " " +i.Desc);
            }
        }
    }
}