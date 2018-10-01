using System;

public class Program
{
    static void Main(string[] args)
    {
        string command;
        var studentSystem = new StudentSystem();

        while ((command = Console.ReadLine()) != "Exit")
        {
            studentSystem.ParseCommand(command, Console.WriteLine);
        }
    }
}