using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Като всеки геймър Пешо има акаунт в Tseam. Той обича да купува игри.
            //Ще ми се даде акаунта на Пешо с всички негови игри => стрингове разделени от спейсове.
            //Ще получавам различни команди какво да правя с акаунта на Пешо докато не получа "Play".
            //Командите ще са
            //1. "Install {game}"
            //2. "Uninstall {game}"
            //3. "Update {game}"
            //4. "Expansion {game}-{expansion}"
            //Ако получа команда "install" инсталирам играта на последната позиция в акаунта, НО САМО, АКО ВЕЧЕ НЕ Е ИНСТАЛИРАНА.
            //Ако получа команда "uninstall" изтривам играта, ако съществува.
            //Ако получа команда "update" и играта съществува я поставям на последната позиция в акаунта.
            //Ако получа командата "expansion" трябва да проверя дали играта съществува, и добавям след името експанжъна във формат {game}:{expansion}
            //На първия ред получавам поредицата с игрите, които са разделени от спейсове. Докато не получа "Play" ще получавам команди.
            //Когато програмата приключи трябва да принтирам игрите от акаунта на пешо на един ред, разделени от спейсове.

            var gameList = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while (true)
            {
                if (input == "Play!")
                {
                    break;
                }

                string[] tokens = input.Split(new[] { ' ', '-' }).ToArray();

                string command = tokens[0];
                string game = tokens[1];

                if (command == "Install" && !gameList.Contains(game))
                {
                    gameList.Add(game);
                }

                else if (command == "Uninstall" && gameList.Contains(game))
                {
                    gameList.Remove(game);
                }

                else if (command == "Update" && gameList.Contains(game))
                {
                    gameList.Remove(game);
                    gameList.Add(game);
                }

                else if (command == "Expansion" && gameList.Contains(game))
                {
                    string expansion = tokens[2];
                    string newGame = game + ":" + expansion;
                    int index = gameList.FindIndex(x => x.StartsWith(game)) + 1;
                    Console.WriteLine();
                    gameList.Insert(index, newGame);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", gameList));
        }
    }
}