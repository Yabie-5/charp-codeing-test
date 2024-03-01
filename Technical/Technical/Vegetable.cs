using System;
namespace Technical
{

    public class Vegetable
    {
        public string VegetableName { set; get; }

        public int Value { set; get; }

        public Vegetable(string vegetableName, int value)
        {
            VegetableName = vegetableName;
            Value = value;
        }

    }
}
