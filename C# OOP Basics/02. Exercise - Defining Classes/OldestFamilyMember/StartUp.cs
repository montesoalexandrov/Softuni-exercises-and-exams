using System;

namespace OldestFamilyMember
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int familyMembers = int.Parse(Console.ReadLine());
            for (int counter = 0; counter < familyMembers; counter++)
            {
                var inputData = Console.ReadLine().Split(' ');
                var name = inputData[0];
                var age = int.Parse(inputData[1]);

                var member = new Person();
                member.Name = name;
                member.Age = age;
                family.AddMember(member);
            }

            var oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
