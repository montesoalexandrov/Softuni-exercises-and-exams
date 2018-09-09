using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            var departments = new Dictionary<string, List<string>>();
            var doctors = new Dictionary<string, List<string>>();

            var input = "";

            while ((input = Console.ReadLine()) != "Output")
            {
                var patientData = input.Split(' ');
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

            while ((input = Console.ReadLine()) != "End")
            {
                var inputData = input.Split(' ');
                int room;

                if (inputData.Length == 1)
                {
                    var department = inputData[0];

                    foreach (var patient in departments[department])
                    {
                        Console.WriteLine(patient);
                    }
                }
                else if (int.TryParse(inputData[1], out room)) //print patients from this room in this department
                {
                    var department = inputData[0];
                    int skip = 3 * (room - 1);

                    foreach (var patient in departments[department].Skip(skip).Take(3).OrderBy(p => p))
                    {
                        Console.WriteLine(patient);
                    }
                }
                else if (!int.TryParse(inputData[1], out room)) // print patients treated by that doctor
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
}