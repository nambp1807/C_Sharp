using System;

namespace t1904a.assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Action a1 = new Action();
            a1.AddCustomer();

            string Chon;
            while (true)
            {
                Console.WriteLine("Chon 1 de them san pham.");
                Console.WriteLine("Chon 2 de xoa sp.");
                Console.WriteLine("Chon 3 de hien thi toan bo thong tin.");
                Console.WriteLine("Chon 4 de Tinh tong tien.");

                Chon = Console.ReadLine();
                switch (Chon)
                {
                    case "1":
                        a1.addproduct();
                        break;
                    case "2":
                        a1.RemoveProduct();

                        break;
                    case "3":
                        a1.ShowCustomer();
                        a1.ShowProduct();
                        break;
                    case "4":
                        a1.TotalMoney();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}