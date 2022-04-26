using System;
namespace csharpconcepts
{
    class DivNumbers
    {      //initialize int
        DivNumbers()
        {

        }
        public void division(int num1, int num2)
        {
            try
            {
                int result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {   //declare variable e
                Console.WriteLine("Exception caught: ", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", num1 / num2);
            }
        }
        static void Main()
        {
            DivNumbers d = new DivNumbers();
            d.division(5, 0);//value within the parameter if we give one parameter 0 then it will handle the exception
            Console.ReadKey();
        }
    }
}
