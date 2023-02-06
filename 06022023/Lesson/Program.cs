using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DateTime date = new DateTime(2021,10,23,23,30,0);

            date = date.AddYears(10);
            date = date.AddMonths(4);
            date = date.AddDays(40);
            date = date.AddYears(-30);

            Console.WriteLine(date.DayOfYear);
            Console.WriteLine(date.Year);
            Console.WriteLine(date.Minute);
            Console.WriteLine(date.Hour);
            Console.WriteLine(date.Second);
            Console.WriteLine(date.DayOfWeek);

            string dateStr = "10-03-2022 14:25";
            DateTime newDate = Convert.ToDateTime(dateStr);


            Console.WriteLine(newDate.Date);
            Console.WriteLine(newDate.ToString("dd-MM-yyyy HH:mm"));
            Console.WriteLine(newDate.ToString("ddd"));
            Console.WriteLine(newDate.ToString("dddd-MMMM-yyyy HH:mm:ss"));

            Console.WriteLine("Tarix daxil edin:");
            string dateInputStr = Console.ReadLine();
            DateTime dateInput = Convert.ToDateTime(dateInputStr);

            Console.WriteLine(dateInput.ToString("dd-MMMM-yyyy HH:mm"));
            Console.WriteLine(dateInput.DayOfWeek);

            Console.WriteLine(DateTime.Now);
            if(dateInput>DateTime.Now)
                Console.WriteLine("gelecek tarixdir");
            else
                Console.WriteLine("kecmis tarixdir");

            Console.WriteLine("1-ci imtahan tarixini daxil edin");
            string examDate1Str = Console.ReadLine();
            DateTime examDate1 = Convert.ToDateTime(examDate1Str);

            Console.WriteLine("2-ci imtahan tarixini daxil edin");
            string examDate2Str = Console.ReadLine();
            DateTime examDate2 = Convert.ToDateTime(examDate2Str);

            var diff = examDate2.Date - examDate1.Date; 

            

            Console.WriteLine(diff);

            Console.WriteLine(diff.TotalSeconds);
            Console.WriteLine(diff.TotalMinutes);
            Console.WriteLine(diff.TotalHours);
            Console.WriteLine(diff.TotalDays);

            Console.WriteLine(diff.Seconds);
            Console.WriteLine(diff.Minutes);
            Console.WriteLine(diff.Hours);
            Console.WriteLine(diff.Days);







        }
    }
}
