using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Hospital
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var departments = new Dictionary<string, List<string>>();
            var doctors = new Dictionary<string, List<string>>();

            var input = string.Empty;

            while ((input = Console.ReadLine()) != "Output")
                FillHospitalData(departments, doctors, input);

            while ((input = Console.ReadLine()) != "End")
            {
                PrintPatients(departments, doctors, input);
            }
        }

        private static void FillHospitalData(Dictionary<string, List<string>> departments, Dictionary<string, List<string>> doctors, string input)
        {
            var patientData = input.Split();
            var department = patientData[0];
            var doctor = patientData[1] + " " + patientData[2];
            var patient = patientData[3];

            if (!departments.ContainsKey(department))
            {
                departments.Add(department, new List<string>());
            }
            departments[department].Add(patient);

            if (!doctors.ContainsKey(doctor))
            {
                doctors.Add(doctor, new List<string>());
            }
            doctors[doctor].Add(patient);
        }

        private static void PrintPatients(Dictionary<string, List<string>> departments, Dictionary<string, List<string>> doctors, string input)
        {
            var inputData = input.Split();
            int room;

            if (inputData.Length == 1)
            {
                var department = inputData[0];

                foreach (var patient in departments[department])
                {
                    Console.WriteLine(patient);
                }
            }
            else if (int.TryParse(inputData[1], out room))
            {
                var department = inputData[0];
                int skip = 3 * (room - 1);

                foreach (var patient in departments[department].Skip(skip).Take(3).OrderBy(p => p))
                {
                    Console.WriteLine(patient);
                }
            }
            else
            {
                var doctor = inputData[0] + " " + inputData[1];

                foreach (var patient in doctors[doctor].OrderBy(p => p))
                {
                    Console.WriteLine(patient);
                }
            }
        }
    }
}