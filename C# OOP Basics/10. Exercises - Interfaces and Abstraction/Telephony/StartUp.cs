namespace Telephony
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split();
            string[] inputUrls = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();

            foreach (var number in inputNumbers)
            {
                smartphone.Call(number);
            }

            foreach (var url in inputUrls)
            {
                smartphone.Browse(url);
            }
        }
    }
}