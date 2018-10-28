namespace Mankind
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            var studentData = Console.ReadLine().Split();
            var workerData = Console.ReadLine().Split();

            Student student = null;
            Worker worker = null;

            try
            {
                student = new Student(studentData[0], studentData[1], studentData[2]);
                worker = new Worker(workerData[0], workerData[1], decimal.Parse(workerData[2]), decimal.Parse(workerData[3]));
            }
            catch (ArgumentException ArgEx)
            {
                Console.WriteLine(ArgEx.Message);
                Environment.Exit(0);
            }

            Console.WriteLine(student.ToString());
            Console.WriteLine(worker.ToString());
        }
    }
}