using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine(Math.Sqrt(number));

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }

        private static Exception newArgumenException()
        {
            throw new NotImplementedException();
        }
    }
}
