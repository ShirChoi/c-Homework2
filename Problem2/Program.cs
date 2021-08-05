using System;

namespace Problem2 {
    class Program {
        static void Main(string[] args) {
            double operand1 = ReadDouble("operand1");
            double operand2 = ReadDouble("operand2");

            Console.Write("sign = ");
            string sign = Console.ReadLine();

            double result;

            switch (sign) {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if(operand2 == 0) {
                        System.Console.WriteLine("нельзя делить на ноль");

                        return;
                    }

                    result = operand1 / operand2;
                    break;
                default:
                    System.Console.WriteLine($"операция {sign} не поддерживается");
                    return;
                    break;
            }

            System.Console.WriteLine($"result = {result}");
        }

        static double ReadDouble(string varName) {
            Console.Write(varName + " = ");

            return Convert.ToDouble(Console.ReadLine());
        }
    }
}
