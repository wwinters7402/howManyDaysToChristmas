using System;

namespace LydiaDateSpan
{

    public class time

    {


    }
    class Program
    {


        static void Main(string[] args)
        {

            DateTime local = DateTime.Now;
            var shortDateNow = DateTime.Now.ToShortDateString();
            DateTime Christmas = new DateTime(2021, 12, 25);

            TimeSpan daysToChristmas = Christmas - local;

           

           

            Console.WriteLine("Lydia today is " + shortDateNow + ". And there are " + daysToChristmas.Days + " days until Christmas.");






            Console.ReadLine();







        }
    }
}
