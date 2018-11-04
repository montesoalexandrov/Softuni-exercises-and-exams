namespace MilitaryElite.Core
{
    using System;
    using System.Linq;
    using MilitaryElite.Enums;
    using MilitaryElite.Models;
    using MilitaryElite.Contracts;
    using System.Collections.Generic;

    public class Engine
    {
        private ICollection<ISoldier> soldiers;
        private ISoldier soldier;

        public Engine ()
        {
            this.soldiers = new List<ISoldier>();
        }

        public void Run()
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split();

                string type = inputArgs[0];
                int id = int.Parse(inputArgs[1]);
                string firstName = inputArgs[2];
                string lastName = inputArgs[3];

                if (type == "Private")
                {
                    decimal salary = decimal.Parse(inputArgs[4]);
                    soldier = GetPrivateSoldier(id, firstName, lastName, salary);
                }
                else if (type == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(inputArgs[4]);
                    soldier = GetLeutenantGeneral(id, firstName, lastName, salary, inputArgs);
                }
                else if (type == "Engineer")
                {
                    decimal salary = decimal.Parse(inputArgs[4]);
                    soldier = GetEngineer(id, firstName, lastName, salary, inputArgs);
                }
                else if (type == "Commando")
                {
                    decimal salary = decimal.Parse(inputArgs[4]);
                    soldier = GetCommando(id, firstName, lastName, salary, inputArgs);
                }
                else if (type == "Spy")
                {
                    int codeNumber = int.Parse(inputArgs[4]);
                    soldier = GetSpy(id, firstName, lastName, codeNumber);
                }
                
                if (soldier != null)
                {
                    this.soldiers.Add(soldier);
                }
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }

        private ISoldier GetSpy(int id, string firstName, string lastName, int codeNumber)
        {
            ISpy spy = new Spy(id, firstName, lastName, codeNumber);
            return spy;
        }

        private ISoldier GetCommando(int id, string firstName, string lastName, decimal salary, string[] inputArgs)
        {
            string corpsAsString = inputArgs[5];

            if (!Enum.TryParse(corpsAsString, out Corps corps))
            {
                return null;
            }

            ICommando commando = new Commando(id, firstName, lastName, salary, corps);

            for (int counter = 6; counter < inputArgs.Length; counter+=2)
            {
                string codeName = inputArgs[counter];
                string stateAsString = inputArgs[counter + 1];

                if (!Enum.TryParse(stateAsString, out State state))
                {
                    continue;
                }

                IMission mission = new Mission(codeName, state);
                commando.Missions.Add(mission); 
            }

            return commando;
        }

        private ISoldier GetEngineer(int id, string firstName, string lastName, decimal salary, string[] inputArgs)
        {
            string corpsAsString = inputArgs[5];

            if (!Enum.TryParse(corpsAsString, out Corps corps))
            {
                return null;
            }

            IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);

            for (int counter = 6; counter < inputArgs.Length; counter+=2)
            {
                string partName = inputArgs[counter];
                int workedHours = int.Parse(inputArgs[counter + 1]);

                IRepair repair = new Repair(partName, workedHours);

                engineer.Repairs.Add(repair);
            }

            return engineer;
        }

        private ISoldier GetLeutenantGeneral(int id, string firstName, string lastName, decimal salary, string[] inputArgs)
        {
            ILeutenantGeneral leutenantGeneral = new LeutenantGeneral(id, firstName, lastName, salary);

            for (int counter = 5; counter < inputArgs.Length; counter++)
            {
                int privateId = int.Parse(inputArgs[counter]);
                IPrivate privateSoldier = (IPrivate) this.soldiers.FirstOrDefault(s => s.Id == privateId);
                leutenantGeneral.Privates.Add(privateSoldier);
            }

            return leutenantGeneral;
        }

        private ISoldier GetPrivateSoldier(int id, string firstName, string lastName, decimal salary)
        {
            IPrivate privateSoldier = new Private(id, firstName, lastName, salary);
            return privateSoldier;
        }
    }
}