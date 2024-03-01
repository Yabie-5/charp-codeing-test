using System;

namespace Technical
{
    class Program
    {
        static void Main(string[] args)
        {
            Yaoya owner = new Yaoya();
            IStaff staff = (IStaff)owner;
            //staff.AddProduct(new Vegetable("きゃべつ", 200));
            //staff.AddProduct(new Vegetable("にんじん", 100));
            //staff.AddProduct(new Vegetable("じゃがいも", 150));
            staff.PrintProduct();
        }
        
    }
}
