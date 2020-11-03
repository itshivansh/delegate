using System;

namespace Delegate
{
    public delegate void CalculateHandler(int first, int second);
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first num and Second num");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            CalculateHandler add, sub, multiply, division, del;
            add = new CalculateHandler(Add);
            sub = new CalculateHandler(Subtract);
            multiply = new CalculateHandler(Multiply);
            division = new CalculateHandler(Divide);
            del = add + sub + multiply + division;
            del(first,second);
#region Ques1

            //CalculateHandler del = new CalculateHandler(Add);
            //del += Subtract;
            //del += Multiply;
            //del += Divide;
            //del(first,second);
#endregion
        }
        public static void Add(int first, int second)
        {
            int result = first + second;
        Console.WriteLine($"Sum is :: {result}");
        }
        public static void Subtract(int first, int second)
        {
            int result = first - second;
            Console.WriteLine($"Difference is :: {result}");
        }
        public static void Multiply(int first, int second)
        {
            int result = first * second;
            Console.WriteLine($"Multiplication is :: {result}");
        }
        public static void Divide(int first, int second)
        {
            int result = first / second;
            Console.WriteLine($"Division result is :: {result}");
        }
    }
}
