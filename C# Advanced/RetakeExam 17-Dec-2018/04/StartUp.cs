namespace _04
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            var knives = new Stack<int>();
            var set = new List<int>();

            foreach (var token in input)
            {
                knives.Push(int.Parse(token));
            }

            input = Console.ReadLine().Split(" ");
            var forks = new Queue<int>();
            foreach (var token in input)
            {
                forks.Enqueue(int.Parse(token));
            }

            while (knives.Count != 0 && forks.Count != 0)
            {
                int knife = knives.Pop();
                int fork = forks.Peek();

                if (knife == fork)
                {
                    knife += 1;
                    knives.Push(knife);
                    forks.Dequeue();
                }
                else if (knife > fork)
                {
                    forks.Dequeue();
                    set.Add(knife + fork);
                }
            }

            Console.WriteLine($"The biggest set is: {set.Max()}");
            Console.WriteLine(String.Join(" ", set));
        }
    }
}