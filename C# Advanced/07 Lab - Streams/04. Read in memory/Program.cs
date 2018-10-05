using System;
using System.IO;
using System.Text;

namespace _04._Read_in_memory
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "1t";
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(text)))
            {
                int oneByte;
                while ((oneByte = stream.ReadByte()) != -1)
                {
                    var character = (char)oneByte;
                    Console.Write(character);
                }
            }
        }
    }
}
