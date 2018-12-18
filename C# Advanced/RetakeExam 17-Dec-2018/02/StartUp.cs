namespace _02
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main(string[] args)
        {
            string text = String.Empty;

            while ((text = Console.ReadLine()) != "Report")
            {
                string pattern = @",{1}[A-Za-z]+[0-9]{1}|_{1}[A-Za-z]+[0-9]{1}";

                MatchCollection words = Regex.Matches(text, pattern);

                string result = string.Empty;

                foreach (var match in words)
                {
                    string word = match.ToString();
                    char symbol = word[0];
                    int value = (int)Char.GetNumericValue(word[word.Length - 1]);
                    string newWord = word.Substring(1, word.Length - 2);

                    foreach (char ch in newWord)
                    {
                        int currentIndex = (int)(ch);

                        if (symbol == ',')
                        {
                            result += Convert.ToChar(currentIndex + value);
                        }
                        else if (symbol == '_')
                        {
                            result += Convert.ToChar(currentIndex - value);
                        }
                    }

                    result += " ";
                }
                Console.WriteLine(result.Trim());
            }
        }
    }
}