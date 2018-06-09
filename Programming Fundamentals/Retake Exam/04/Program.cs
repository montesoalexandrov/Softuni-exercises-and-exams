using System;
using System.Collections.Generic;
using System.Linq;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пешо се бори да стане майстор на класа Challenger. Така че внимателно наблюдава статистиката.
            //Ще получа няколко input редове в един от следните формати
            //1. "{player} -> {position} -> {skill}"
            //2. "{player} vs {player}"
            //Играча и позицията са СТРИНГОВЕ. Скила е ИНТ.
            //Когато получа играч с неговата позиция и скил го добавям в player pool, ако той НЕ ПРИСЪСТВА.
            //ИНАЧЕ добавям неговата позиция и скил или актуализирам неговия скил, НО САМО ако новата стойност е ПО-ВИСОКА.
            //Ако получа "{player} vs {player}" и двамата играчи съществуват, те се дуелират със следните правила:
            //1.Сравнява се техните позиции => Ако имат поне един общ, играчът с по-добри скил точки побеждава, а другия е премахнат. Ако завършат наравно и двамата продължават напред. Ако двамата нямат общ скил, и двамата продължават напред.
            //Програмата прекъсва когато получа команда "Season end". 
            //Трябва да принтирам играчите ordered by total skill in desecending order, then ordered by player name in ascending order. Foreach player print their position and skill, ordered desecending by skill, then ordered by position name in ascending order.

            var players = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Season end")
                {
                    break;
                }

                string[] tokens = input.Split(new[] { "->", " ", "vs" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (tokens.Length == 3)
                {
                    string player = tokens[0];
                    string skill = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if (!players.ContainsKey(player))//проверявам дали играча се съдържа в речника
                    {
                        players[player] = new Dictionary<string, int>(); //ако не се го създавам
                    }

                    if (!players[player].ContainsKey(skill))//проверявам дали играча притежава определен скил
                    {
                        players[player][skill] = points; //ако не го притежава го създавам
                    }
                    else
                    {
                        if(players[player][skill] < points)
                        {
                            players[player][skill] = points;
                        }
                    }
                }

                if (tokens.Length == 2)
                {
                    string firstPlayer = tokens[0];
                    string secondPlayer = tokens[1];

                    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                    {
                        foreach (var firstSkill in players[firstPlayer]) //проверявам дали има свъпадение в някой от скиловете на играчите
                        {
                            foreach (var secondSkill in players[secondPlayer]) // ||-||-||
                            {
                                if (firstSkill.Key == secondSkill.Key) // ||-||-||
                                {
                                    if(firstSkill.Value > secondSkill.Value) // АКО има таъв скил, проверявам на кой от двамата е по-силен
                                    {
                                        players.Remove(secondPlayer);
                                        break;
                                    }

                                    else if(secondSkill.Value > firstSkill.Value)
                                    {
                                        players.Remove(firstPlayer);
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    }
                }
            }

            foreach (var player in players.OrderByDescending(x => (x.Value.Values.Sum())).ThenBy(x => (x.Key)))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var skill in player.Value.OrderByDescending(x => (x.Value)).ThenBy(x => (x.Key)))
                {
                    Console.WriteLine($"- {skill.Key} <::> {skill.Value}");
                }
            }
        }
    }
}