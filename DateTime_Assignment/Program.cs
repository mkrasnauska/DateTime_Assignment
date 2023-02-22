using System;


namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---------\nWelcome \nToday is:\n" + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            Console.WriteLine("Please Enter a number:");
            Double YourNumber = Convert.ToDouble(Console.ReadLine());
            DateTime YourDateTime = DateTime.Now.AddHours(YourNumber);
            Console.WriteLine("in {0} hours it will be : \n{1}", YourNumber, YourDateTime);
            Console.ReadLine();
        }
    }
}
