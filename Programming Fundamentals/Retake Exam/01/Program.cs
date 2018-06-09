using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Когато Пешо губи започва да чуби компонентите на компютъра си.
            //На всеки 2 загубени игри той чупи headset-а си
            //На всеки 3 загубени игри той чупи мишката си
            //Когато Пешо счупи headset-а и мишката си след една и съща загубена игра, той чупи и клавиатурата си.
            //Всеки втори път когато счупи клавиатурата си, той чупи и монитора си.
            //1. на първия ред ще получавам броя загубени игри на Пешо
            //2. на втория ред ще получавам цената на headset - double
            //3. на третия ред цената на мишката в double
            //4. на четвъртия ред цената на клавиатурата в double
            //5. на петия ред цената на дисплея в double
            //6. Трябва да принтирам колко пари е изхарчил Пешо

            int lostGamesCount = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double sum = 0.0;
            int brokenKeyboards = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {

                if (i % 2 == 0) //ако броя загубени игри е четно число => чупи headset 
                {
                    sum += headsetPrice;
                }

                if (i % 3 == 0) // ако броя загубени игри се дели без остатък на 3 => чупи мишката си
                {
                    sum += mousePrice;
                }

                if (i % 2 == 0 && i % 3 == 0) //ако двете горни условия са вярни в един и също момент той чупи клавиатурата си
                {
                    brokenKeyboards++;
                    sum += keyboardPrice;

                    if (brokenKeyboards % 2 == 0) //всеки път когато счупените клавиатури са четен брой, той чупи и монитор
                    {
                        sum += displayPrice;
                    }
                }
            }

            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}