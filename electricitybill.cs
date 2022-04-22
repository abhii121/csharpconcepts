using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconcepts
{
    internal class electricitybill
    {

        public abstract class GST_Calculation
        {
            protected double Bill;
            public abstract void GetBill();
            public void Calculate_GST(double GST)
            {
                Console.WriteLine("Electricity Bill is:{0}", Bill + GST);
            }
        }
        public class ebill : GST_Calculation
        {
            public override void GetBill()
            {
                Bill = 1200;
            }

        }
      
        public class Abstraction
        {
            public static void Main()
            {
                GST_Calculation calc;
                calc = new ebill();
                calc.GetBill();
                calc.Calculate_GST(240);
                
            }
        }
    }
       
}

