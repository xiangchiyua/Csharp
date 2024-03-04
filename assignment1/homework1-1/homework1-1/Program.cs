using System.Net.Http.Headers;

namespace homework1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the first number:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("the second number:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("operator:");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine('\n'+"answer");
            switch (op)
            {
                case '+': Console.WriteLine(a + b); break;
                case '-': Console.WriteLine(a - b); break;
                case '*': Console.WriteLine(a * b); break;
                case '/': Console.WriteLine(a / b); break;
            }

        }
    }
}
