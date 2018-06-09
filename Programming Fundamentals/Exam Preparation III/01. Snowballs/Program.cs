using System;
using System.Numerics;

namespace _01.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger snowballValue = 0;
            int highSnowballSnow = 0;
            int highSnowballTime = 0;
            int highSnowballQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if(currentSnowballValue > snowballValue)
                {
                    snowballValue = currentSnowballValue;
                    highSnowballSnow = snowballSnow;
                    highSnowballTime = snowballTime;
                    highSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{highSnowballSnow} : {highSnowballTime} = {snowballValue} ({highSnowballQuality})");
        }
    }
}