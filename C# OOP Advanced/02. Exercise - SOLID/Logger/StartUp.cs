﻿namespace Logger
{
    using System;

    public class StartUp
    {

        static void Main(string[] args)
        {
            int countOfAppenders = int.Parse(Console.ReadLine());
            var controller = new Controller();
            controller.Act(countOfAppenders);
        }
    }
}