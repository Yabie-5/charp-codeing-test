using System;

namespace Basic
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int Year = 0;
            int Mon = 0;
            int Day = 0;

            try
            {
                Console.WriteLine("年を入力してください");
                Year = int.Parse(Console.ReadLine());
                Console.WriteLine("月を入力してください");
                Mon = int.Parse(Console.ReadLine());
                Console.WriteLine("日を入力してください");
                Day = int.Parse(Console.ReadLine());

                if(Year <= 0 || Mon <= 0 || Day <= 0)
                {
                    throw new ArgumentException("無効な入力です。");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Int型で入力してください。");
                return;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            OldCalender oldCalender = new OldCalender();
            DateTime newDateTime = new DateTime(Year, Mon, Day);
            DateTime lunDateTime = oldCalender.ConvOldCalender(newDateTime);
            oldCalender.PrintRokuyo(lunDateTime.Month, lunDateTime.Day);
            

        }
    }
}
