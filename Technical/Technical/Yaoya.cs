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
        void PrintProduct();
        int CalcTotalPrice(int id);
        void PrintReceipt();
    }

    public class Yaoya : IPayment, IStaff
    {
        private List<Vegetable> products = new List<Vegetable>();
        public int totalPrice
        {
            private set; get;
        }
        public Yaoya()
        {
            totalPrice = 0;
        }

        public void AddProduct(Vegetable vegetable)
        {
            products.Add(vegetable);
        }

        public void PrintProduct()
        {
            if (products.Count > 0)
            {
                Console.WriteLine("どの野菜を購入しますか?");
                for (int i = 0; i<products.Count; i++)
                {
                    Console.WriteLine("{0}:{1} ({2}円)",i+1,products[i].VegetableName, products[i].Price);
                }

            }
            else {
                Console.WriteLine("商品がありません\n");
            }

        }


        public int CalcTotalPrice(int id) {
            // コンソールの表示が1~なので,Listに会うようにindex調整
            id -= 1;
            try
            {
                totalPrice += products[id].Price;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("範囲外の入力です. 1~{0}で入力してください.",products.Count+1);
            }
            return totalPrice;
        }

        public void PrintReceipt()
        {
            Console.WriteLine("合計: {0}円\n",totalPrice);
        }

        
    }
}
