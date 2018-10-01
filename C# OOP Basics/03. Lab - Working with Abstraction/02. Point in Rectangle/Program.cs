using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var coords = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var rectangle = new Rectangle(coords[0], coords[1], coords[2], coords[3]);
        var pointsCount = int.Parse(Console.ReadLine());

        for (int counter = 0; counter < pointsCount; counter++)
        {
            var pointsCoord = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var point = new Point(pointsCoord[0], pointsCoord[1]);
            var containsPoint = rectangle.Contains(point);

            Console.WriteLine(containsPoint);
        }
    }
}