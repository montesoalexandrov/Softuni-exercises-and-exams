namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var animals = new Queue<Animal>();
            string animalType;

            while ((animalType = Console.ReadLine()) != "Beast!")
            {
                var currentAnimalTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (animalType.Trim())
                    {
                        case "Cat":
                            Animal cat = new Cat(currentAnimalTokens[0], int.Parse(currentAnimalTokens[1]), currentAnimalTokens[2]);
                            animals.Enqueue(cat);
                            break;
                        case "Dog":
                            Animal dog = new Dog(currentAnimalTokens[0], int.Parse(currentAnimalTokens[1]), currentAnimalTokens[2]);
                            animals.Enqueue(dog);
                            break;
                        case "Frog":
                            Animal frog = new Frog(currentAnimalTokens[0], int.Parse(currentAnimalTokens[1]), currentAnimalTokens[2]);
                            animals.Enqueue(frog);
                            break;
                        case "Kitten":
                            Animal kitten = new Kitten(currentAnimalTokens[0], int.Parse(currentAnimalTokens[1]));
                            animals.Enqueue(kitten);
                            break;
                        case "Tomcat":
                            Animal tomcat = new Tomcat(currentAnimalTokens[0], int.Parse(currentAnimalTokens[1]));
                            animals.Enqueue(tomcat);
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                }
                catch (ArgumentException ArgEx)
                {
                    Console.WriteLine(ArgEx.Message); ;
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                animal.ProduceSound();
            }
        }
    }
}