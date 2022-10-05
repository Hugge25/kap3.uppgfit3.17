using System;

namespace uppgfit317
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två stycken nummer(använd mellanslag t.ex. 0 1)");
            string[] tokens = Console.ReadLine().Split();

            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);

            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            string matte = Console.ReadLine();

            switch(matte)
            {
                case "1":
                    int c = a + b;
                    Console.WriteLine($"{a} + {b} = {c}");
                    break;

                case "2":
                    int d = a - b;
                    Console.WriteLine($"{a} - {b} = {d}");
                    break;

                case "3":
                    int e = a * b;
                    Console.WriteLine($"{a} * {b} = {e}");
                    break;

                case "4":
                    int f = a / b;
                    Console.WriteLine($"{a} ÷ {b} = {f}");
                    break;

                default:
                    Console.WriteLine("Skriv ett nummer mellan 1-4");
                    break;
            }
        }
    }
}