using System;

namespace t1904a.practical
{
     public class Phone 
       {
           protected string phonename;
           protected string phonetype;
           protected float phoneprice;
   
           public Phone()
           {
           }
   
           public Phone(string phonename, string phonetype, float phoneprice)
           {
               this.phonename = phonename;
               this.phonetype = phonetype;
               this.phoneprice = phoneprice;
           }
   
           protected string Phonename
           {
               get => phonename;
               set => phonename = value;
           }
   
           protected string Phonetype
           {
               get => phonetype;
               set => phonetype = value;
           }
   
           protected float Phoneprice
           {
               get => phoneprice;
               set => phoneprice = value;
           }
   
           public void display()
           {
               Console.WriteLine("Phone : "+phonename +"--"+"Type : "+phonetype + "--"+"Price:"+Phonetype);
           }
       }
}
