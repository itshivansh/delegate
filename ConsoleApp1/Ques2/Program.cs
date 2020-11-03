using System;

namespace Ques2
{
    public delegate int CalculateAdd (int first, int second);
    public delegate int CalculateSubtract(int first, int second);
    public delegate int CalculateMutiply(int first, int second);
    public delegate int CalculateDivide(int first, int second);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first num and Second num");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            CalculateAdd add = new CalculateAdd(Add);
            CalculateSubtract sub = new CalculateSubtract(Subtract);
            CalculateMutiply multiply = new CalculateMutiply(Multiply);
            CalculateDivide division = new CalculateDivide(Divide);
            Console.WriteLine($"Add result is :: {add(first, second)}");
            Console.WriteLine($"Subtraction result is :: {sub(first, second)}");
            Console.WriteLine($"multiplication result is :: {multiply(first, second)}");
            Console.WriteLine($"division result is :: {division(first, second)}");
        }
        public static int Add(int first, int second)
        {
            int result = first + second;
            return result;
            //Console.WriteLine($"Sum is :: {result}");
        }
        public static int Subtract(int first, int second)
        {
            int result = first - second;
            return result;
            //Console.WriteLine($"Difference is :: {result}");
        }
        public static int Multiply(int first, int second)
        {
            int result = first * second;
            return result;
            //Console.WriteLine($"Multiplication is :: {result}");
        }
        public static int Divide(int first, int second)
        {
            int result = first / second;
            return result;
            //Console.WriteLine($"Division result is :: {result}");
        }
    }
}
