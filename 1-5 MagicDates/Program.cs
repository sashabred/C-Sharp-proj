using System;

namespace _1_5_MagicDates
{
    class Program
    {
         static void Main(string[] args)
        {
            MagicDate21();
        }

        static void MagicDate21() {
            DateTime dec2001 = DateTime.Parse("31.12.2100");
            for (DateTime dateIn= DateTime.Parse("01.01.2001"); dateIn<dec2001;dateIn= dateIn.AddDays(1.0)) {
                int day = dateIn.Day;
                int month = dateIn.Month;
                string yearStr =  dateIn.Year.ToString().Substring(2);
                int year = int.Parse(yearStr);
                if (day*month == year ) {
                    Console.WriteLine(dateIn.ToString("dd.MM.yyyy"));
                }        
            }      
        }
    }
}
