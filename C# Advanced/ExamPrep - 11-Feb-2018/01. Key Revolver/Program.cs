using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            var locks = new Queue<int>();
            var bullets = new Stack<int>();

            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            var bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            foreach (var lockk in locksInput)
            {
                locks.Enqueue(lockk);
            }

            foreach (var bullet in bulletsInput)
            {
                bullets.Push(bullet);
            }

            int bulletCounter = 0;
            int currentLock = 0;

            while (locks.Count != 0)
            {
                if (bullets.Count == 0)
                {
                    if (currentLock != -1)
                    {
                        Console.WriteLine($"Couldn't get through. Locks left: {locks.Count + 1}");
                    }
                    else
                    {
                        Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    }
                    Environment.Exit(0);
                }

                currentLock = locks.Dequeue();

                while (bullets.Count != 0)
                {
                    if (bulletCounter == gunBarrelSize)
                    {
                        Console.WriteLine("Reloading!");
                        bulletCounter = 0;
                    }

                    int currentBullet = bullets.Pop();
                    intelligenceValue -= bulletPrice;
                    bulletCounter++;

                    if (currentLock >= currentBullet)
                    {
                        Console.WriteLine("Bang!");
                        currentLock = -1;

                        if (bulletCounter == gunBarrelSize)
                        {
                            if (bullets.Count > 0)
                            {
                                Console.WriteLine("Reloading!");
                                bulletCounter = 0;
                            }
                        }

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }
                }
            }

            Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligenceValue}");
        }
    }
}