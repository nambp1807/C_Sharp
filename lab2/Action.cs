using System;

namespace t1904a
{
    public class Action
    {
        Products p = new Products();

        public void inputProducts()
        {
            Console.WriteLine("nhap id :");
            p.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap ten :");
            p.Name = Console.ReadLine();
            Console.WriteLine("nhap gia :");
            p.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap qty :");
            p.Qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap image :");
            p.Img = Console.ReadLine();
            Console.WriteLine("nhap Desc :");
            p.Desc = Console.ReadLine();
        }

        public void showProduct()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("ShowProduct : "+p.Id+"    "+p.Name+"    "+p.Price+"    "+p.Qty+"    "+p.Img+"    "+p.Desc);
        }
    }
}