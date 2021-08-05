using System;

namespace Problem3 {
    class Program {
        static void Main(string[] args) {
            int num = ReadInt("number");

            string result = "";

            if(num < 0 || num > 100) {
                result = "число должно находится в промежутке 0-100";
            } else if(num <= 14) {
                result = "[0 - 14]";
            } else if (num <= 35) {
                result = "[15 - 35]";
            } else if (num <= 50) {
                result = "[36 - 50]";
            } else if (num <= 100) {
                result = "[51 - 100]";
            }

            Console.WriteLine(result);
        }

        static int ReadInt(string varName) {
            Console.Write(varName + " = ");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
