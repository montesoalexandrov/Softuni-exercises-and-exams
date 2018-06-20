using System;
namespace _16.Debugging_Exercise_Instruction_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine();
            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');
                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            var operandOne = long.Parse(codeArgs[1]);
                            result += operandOne + 1;
                            break;
                        }
                    case "DEC":
                        {
                            var operandOne = long.Parse(codeArgs[1]);
                            result += operandOne - 1;
                            break;
                        }
                    case "ADD":
                        {
                            var operandOne = long.Parse(codeArgs[1]);
                            var operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            var operandOne = long.Parse(codeArgs[1]);
                            var operandTwo = long.Parse(codeArgs[2]);
                            result = (operandOne * operandTwo);
                            break;
                        }
                }
                Console.WriteLine(result);
                opCode = Console.ReadLine();
            }
        }
    }
}