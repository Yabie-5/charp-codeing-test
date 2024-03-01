using System;

namespace Technical
{
    class Program
    {
        static void Main(string[] args)
        {
            
                // 商品を追加
                Yaoya u1 = new Yaoya();
                IStaff staff = (IStaff)u1;
                staff.AddProduct(new Vegetable("きゃべつ", 200));
                staff.AddProduct(new Vegetable("にんじん", 100));
                staff.AddProduct(new Vegetable("じゃがいも", 150));

                // 商品を購入
                IPayment customer = (IPayment)u1;

            while (true)
            {
                customer.PrintProduct();
                int id = 0;
                try
                {
                    id = int.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("数値を入力してください.");
                }

                customer.CalcTotalPrice(id);
                customer.PrintReceipt();

                Console.WriteLine("続けて購入しますか？ 続ける:Y、続けない:N\n");
                string continueFlag = Console.ReadLine();
                if (continueFlag == "Y")
                {
                    continue;
                }
                else if (continueFlag == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("{0}無効な入力です.プログラムを終了します.", continueFlag);
                    return;
                }
            }
        }
        
    }
}
