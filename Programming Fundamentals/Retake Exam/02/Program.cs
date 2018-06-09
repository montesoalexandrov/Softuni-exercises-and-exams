using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Трябва да превърна memory display-а в четлива форма
            //Докато не получа командата "Visual Studio crash" ще получавам линии от изгледа на паметта в 2-byte integer. 
            //Всеки ред съдържа 22 такива integer-а разделени от празно място.
            //Първите числа различни от 0, които ще получа, ще бъдат "32656 19759 32763"
            //продължава с нули докато не стигне две 0 обграждащи int, който показва колко числа ще имам в поредицата => 0 INT 0
            //След това започват числата от поредицата, които трябва да запиша в масив/списък. 
            //Всяко число отговаря на символ от ASCII таблицата, и всичките формират string.
            //Разкодирайки всеки ред, записвам стринга в нов масив/списък.
            //принтирам всички стрингове, които съм записал в масива/списъкa.

            string pattern = @"[1-9]+[0-9]*";
            string word = string.Empty;

            var words = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Visual Studio crash")
                {
                    if (word.Length != 0) // Проверявам дали при спиране на програмата няма някоя записана дума, която да не е в списъка
                    {
                        words.Add(word);
                    }
                    break;
                }

                MatchCollection matches = Regex.Matches(input, pattern);

                for (int i = 0; i < matches.Count; i++)
                {
                    int unicode = Convert.ToInt16(Convert.ToString(matches[i])); // конвертирам в число(int)

                    char character = (char)unicode; // конвертирам в буква по уникодската таблица

                    if (unicode.ToString().Length != 1 && unicode != 32656 && unicode != 19759 && unicode != 32763) // проверявам да не се запише грешен символ
                    {
                        word = word + character.ToString(); // записвам буквите една по една в стринг
                    }

                    if (unicode == 32656 && word != "")
                    {
                        words.Add(word);
                        word = String.Empty;
                    }
                }
            }
            Console.WriteLine(String.Join("\n", words));
        }
    }
}