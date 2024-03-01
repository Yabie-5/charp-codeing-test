using System;
namespace Technical
{

    public class Vegetable
    {
        public string VegetableName { set; get; }

        public int Price { set; get; }

        public Vegetable(string vegetableName, int price)
        {
            VegetableName = vegetableName;
            Price = price;
        }

    }
}
