using System;
namespace Technical
{
    using System.Collections.Generic;

    public interface IStaff
    {
        void AddProduct(Vegetable vegetable);
        void PrintProduct();
    }
    interface IPayment
    {

    }

    public class Yaoya: IPayment, IStaff
    {
        private List<Vegetable> products = new List<Vegetable>();
        //public Yaoya()
        //{
        //}

        public void AddProduct(Vegetable vegetable)
        {
            products.Add(vegetable);
        }

        public void PrintProduct()
        {
            if (products.Count > 0)
            {
                foreach(Vegetable item in products)
                {
                    Console.WriteLine("{0}: {1}",item.VegetableName, item.Value);
                }

            }
            else {
                Console.WriteLine("商品がありません");
            }

        }

        
    }
}
