﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Files
{
    class File
    {
        public string Root { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFiles = int.Parse(Console.ReadLine());

            var filesPerRoot = new Dictionary<string, List<File>>();

            for (int i = 0; i < numberOfFiles; i++)
            {
                string[] fileInfo = Console.ReadLine()
                    .Split(new[] { "\\", ";" }, StringSplitOptions.RemoveEmptyEntries);

                string fileRoot = fileInfo[0];
                string fileName = fileInfo[fileInfo.Length - 2];
                long fileSize = long.Parse(fileInfo[fileInfo.Length - 1]);

                if (!filesPerRoot.ContainsKey(fileRoot))
                {
                    filesPerRoot[fileRoot] = new List<File>();
                }

                var filesInCurrentRoot = filesPerRoot[fileRoot];
                var existingFile = filesInCurrentRoot
                    .FirstOrDefault(f => f.Name == fileName);

                if (existingFile == null)
                {
                    var file = new File
                    {
                        Name = fileName,
                        Root = fileRoot,
                        Size = fileSize
                    };
                    filesInCurrentRoot.Add(file);
                }
                else
                {
                    existingFile.Size = fileSize;
                }
            }

            string[] query = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string ext = query[0];
            string root = query[2];

            if (!filesPerRoot.ContainsKey(root))
            {
                Console.WriteLine("No");
                return;
            }

            var result = filesPerRoot[root]
                .Where(f => f.Name.EndsWith(ext))
                .OrderByDescending(f => f.Size)
                .ThenBy(f => f.Name)
                .ToList();

            if (!result.Any())
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var file in result)
                {
                    Console.WriteLine($"{file.Name} - {file.Size} KB ");
                }
            }


        }
    }
}