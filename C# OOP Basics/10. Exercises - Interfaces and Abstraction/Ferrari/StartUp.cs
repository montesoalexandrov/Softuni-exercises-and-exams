using System;

namespace Ferrari
{
    public class StartUp
    {
        static void Main()
        {
            var driver = Console.ReadLine();
            Ferrari spider = new Ferrari(driver);

            Console.WriteLine(spider.ToString());
        }
    }
}