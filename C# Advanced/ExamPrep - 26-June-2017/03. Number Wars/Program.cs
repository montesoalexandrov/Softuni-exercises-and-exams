using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var firstPlayerCards = new Queue<string>(input);

            input = Console.ReadLine().Split(' ');
            var secondPlayerCards = new Queue<string>(input);

            int turns = 0;

            while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0)
            {
                turns++;
                if (turns == 1000000)
                {
                    if (firstPlayerCards.Count > secondPlayerCards.Count)
                    {
                        Console.WriteLine($"First player wins after {turns} turns");
                    }
                    else if (firstPlayerCards.Count < secondPlayerCards.Count)
                    {
                        Console.WriteLine($"Second player wins after {turns} turns");
                    }
                    else
                    {
                        Console.WriteLine($"Draw after {turns} turns");
                    }
                    break;
                }

                var firstPlayerCard = firstPlayerCards.Dequeue();
                var secondPlayerCard = secondPlayerCards.Dequeue();

                int firstPlayerIntValue = int.Parse(firstPlayerCard.Substring(0, firstPlayerCard.Length - 1));
                int secondPlayerIntValue = int.Parse(secondPlayerCard.Substring(0, secondPlayerCard.Length - 1));

                if (firstPlayerIntValue > secondPlayerIntValue)
                {
                    firstPlayerCards.Enqueue(firstPlayerCard);
                    firstPlayerCards.Enqueue(secondPlayerCard);
                }
                else if (firstPlayerIntValue < secondPlayerIntValue)
                {
                    secondPlayerCards.Enqueue(secondPlayerCard);
                    secondPlayerCards.Enqueue(firstPlayerCard);
                }
                else
                {
                    var warDeck = new List<string>();
                    warDeck.Add(firstPlayerCard);
                    warDeck.Add(secondPlayerCard);

                    bool inWar = true;
                    bool gameFinished = false;

                    while (inWar)
                    {
                        int firstPlayerCharValue = 0;
                        int secondPlayerCharValue = 0;

                        //Check that both players have the required three cards for war
                        if (firstPlayerCards.Count < 3 && secondPlayerCards.Count >= 3) 
                        {
                            Console.WriteLine($"Second player wins after {turns} turns");
                            gameFinished = true;
                            break;
                        }
                        else if (firstPlayerCards.Count >= 3 && secondPlayerCards.Count < 3)
                        {
                            Console.WriteLine($"First player wins after {turns} turns");
                            gameFinished = true;
                            break;
                        }
                        else if (firstPlayerCards.Count < 3 && firstPlayerCards.Count < 3)
                        {
                            Console.WriteLine($"Draw after {turns} turns");
                            gameFinished = true;
                            break;
                        }

                        //
                        for (int i = 0; i < 3; i++)
                        {
                            firstPlayerCard = firstPlayerCards.Dequeue();
                            secondPlayerCard = secondPlayerCards.Dequeue();

                            warDeck.Add(firstPlayerCard);
                            warDeck.Add(secondPlayerCard);

                            firstPlayerCharValue += (Convert.ToInt32(firstPlayerCard.Last()));
                            secondPlayerCharValue += (Convert.ToInt32(secondPlayerCard.Last()));
                        }

                        if (firstPlayerCharValue > secondPlayerCharValue)
                        {
                            foreach (var card in warDeck.OrderByDescending(x => int.Parse(x.Substring(0, x.Length - 1))).ThenByDescending(x => Convert.ToInt32(x.Last())))
                            {
                                firstPlayerCards.Enqueue(card);
                                inWar = false;
                            }
                        }
                        else if (firstPlayerCharValue < secondPlayerCharValue)
                        {
                            foreach (var card in warDeck.OrderByDescending(x => int.Parse(x.Substring(0, x.Length - 1))).ThenByDescending(x => Convert.ToInt32(x.Last())))
                            {
                                secondPlayerCards.Enqueue(card);
                                inWar = false;
                            }
                        }
                    }

                    if (gameFinished)
                        break;
                }
            }

            if (secondPlayerCards.Count == 0)
            {
                Console.WriteLine($"First player wins after {turns} turns");
            }
            else if (firstPlayerCards.Count < secondPlayerCards.Count)
            {
                Console.WriteLine($"Second player wins after {turns} turns");
            }
        }
    }
}