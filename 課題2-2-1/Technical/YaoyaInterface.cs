using System;
namespace Technical
{
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
}
