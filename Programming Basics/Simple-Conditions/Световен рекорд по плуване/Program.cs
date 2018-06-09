using System;

namespace Световен_рекорд_по_плуване
{
    class Program
    {
        static void Main(string[] args)
        {
            var rekordSekundi = double.Parse(Console.ReadLine());
            var razstoqnieMetri = double.Parse(Console.ReadLine());
            var vremeSekundi1metar = double.Parse(Console.ReadLine());

            var vremeBezZabavqne = razstoqnieMetri * vremeSekundi1metar;
            var vremeZabavqne = Math.Floor(razstoqnieMetri / 15) * 12.5;
            var obshtoVreme = vremeBezZabavqne + vremeZabavqne;

            var razlika = obshtoVreme - rekordSekundi;

            if (obshtoVreme < rekordSekundi) Console.WriteLine($"Yes, he succeeded! The new world record is {obshtoVreme:f2} seconds.");
            else if (obshtoVreme >= rekordSekundi) Console.WriteLine($"No, he failed! He was {razlika:f2} seconds slower.");
        }
    }
}
