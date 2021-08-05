using System;

namespace Problem1 {
    class Program {
        static void Main(string[] args) {
            int A = ReadInt("A");
            int B = ReadInt("B");

            if(A != B) {
                A = Math.Max(A, B);
                B = Math.Max(A, B);
            } else {
                A = B = 0;
            }

            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");
        }

        static int ReadInt(string varName) {
            Console.Write(varName + " = ");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
