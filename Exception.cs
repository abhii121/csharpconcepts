using System;
namespace csharpconcepts
{

    public class OddNumException : Exception
    {
        public override string Message
        {
            get
            {
                return "There cannot be an odd divisor";
            }
        }
    }
    class check
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Please enter two numbers and type of the numbers must be integer:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            try
            {
                if (b % 2 > 0)
                {
                    throw new OddNumException();
                }
                c = a / b;
                Console.WriteLine(c);
            }
            catch (OddNumException two)
            {
                Console.WriteLine(two.Message);
            }
            Console.WriteLine("The program ends here");
            Console.ReadKey();
        }
    }
}