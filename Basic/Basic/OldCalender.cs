using System;
namespace Basic
{
    using System.Collections.Generic;
    using System.Globalization;

    public class OldCalender
    {
        private JapaneseLunisolarCalendar jlCalender = new JapaneseLunisolarCalendar();

        public enum Rokuyos
        {
            大安,
            赤口,
            先勝,
            友引,
            先負,
            仏滅
        }

        public OldCalender()
        {
        }

        public DateTime ConvOldCalender(DateTime newDateTime)
        {
            // int lunarEra = jlCalender.GetEra(newDateTime);
            int lunarYear = jlCalender.GetYear(newDateTime);
            int lunarMonth = jlCalender.GetMonth(newDateTime);
            int lunarDay = jlCalender.GetDayOfMonth(newDateTime);

            // int leapMon = jlCalender.GetLeapMonth(lunarYear, lunarEra);
            switch (lunarMonth)
            {
                case 13:// 閏月の場合は調整.
                    lunarMonth -= 1;
                    DateTime leapYearDate = new DateTime(lunarYear - 1, lunarMonth, lunarDay);
                    return leapYearDate;

                default:
                    DateTime lunDate = new DateTime(lunarYear, lunarMonth, lunarDay);
                    return lunDate;
            }
        }


        public void PrintRokuyo(int mon, int day)
        {
            int key = (mon + day) % 6;


            switch (key)
            {
                case 0:
                    Println(Rokuyos.大安);
                    return;
                case 1:
                    Println(Rokuyos.赤口);
                    return;
                case 2:
                    Println(Rokuyos.先勝);
                    return;
                case 3:
                    Println(Rokuyos.友引);
                    return;
                case 4:
                    Println(Rokuyos.先負);
                    return;
                default:
                    Println(Rokuyos.仏滅);
                    return;
            }


        }

        public void Println(Rokuyos rokuyo) {
            Console.WriteLine("{0}", rokuyo);
        }
    }
}
