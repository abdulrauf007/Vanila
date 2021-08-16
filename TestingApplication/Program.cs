using System;

namespace TestingApplication
{
    class Program
    {

        public int Sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            var result = program.Sum(5, 5);

            Console.WriteLine(result);
        }
    }
}

