namespace t1904a
{
    public class Products
    {
        private int id;
        private string name;
        private float price;
        private int qty;
        private string img;
        private string desc;


        public Products()
        {
            
        }

        public int Id
        {
            get { return id;}
            set { this.id = value; }
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public float Price
        {
            get { return price; }
            set { this.price = value; }
        }

        public int Qty
        {
            get { return qty; }
            set { this.qty = value; }
        }

        public string Img
        {
            get { return img; }
            set { this.img = value; }
        }

        public string Desc
        {
            get { return desc; }
            set { this.desc = value; }
        }
    }
    
}