namespace t1904a.practical
{
    public class Program
    {
        static void Main(string[] args)
        {
            Phone p = new Phone("nam","display",56789);
            MobilePhone mp = new MobilePhone();
            p.display();
            mp.display();
        }
    }
}