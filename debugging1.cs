using System;
delegate int NumberChanger(int n);
namespace csharpconcepts
{
    class TestDelegate
    {
        static int num = 1;    
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
       
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);



            
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }   }
