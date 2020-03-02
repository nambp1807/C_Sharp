using System.Collections.Generic;

namespace t1904a.assignment2
{
    public class Cart
    {
        private int Id;
        private string customer;
        private int grandTotal;
        private string city;
        private string country;
        public List<Product> productlist = new List<Product>();

        public int id
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }

        public string Customer
        {
            get
            {
                return customer;
            }

            set
            {
                customer = value;
            }
        }

        public int GrandTotal
        {
            get
            {
                return grandTotal;
            }

            set
            {
                grandTotal = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }
    }
}