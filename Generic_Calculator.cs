using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconcepts
{
    internal class GenericCalculator
    {
        public abstract class AbstractCalculator<T>
        {
            public abstract T Add(T input1, T input2);
            public abstract T Sub(T input1, T input2);
            public abstract T Multiply(T input1, T input2);
            public abstract T Divide(T input1, T input2);
        }

        public class IntCalculator : AbstractCalculator<int>
        {
            public override int Add(int input1, int input2)
            {
                return input1 + input2;
            }

            public override int Sub(int input1, int input2)
            {
                return input1 - input2;
            }

            public override int Multiply(int input1, int input2)
            {

                return input1 * input2;
            }

            public override int Divide(int input1, int input2)
            {
                return input1 / input2;
            }

        }

        public class ArithmeticOperation<T>

        {
            AbstractCalculator<T> _myCalculator;


            public ArithmeticOperation(AbstractCalculator<T> myCalculator)
            {
                this._myCalculator = myCalculator;
            }
            public T Sum(List<T> items)
            {
                dynamic sum = 0;

                for (int i = 0; i < items.Count; i++)
                {
                    sum = _myCalculator.Add(sum, items[i]);
                }


                return sum;
            }

            public T Sub(List<T> items)
            {
                dynamic sub = 0;
                for (int i = 0; i < items.Count; i++)
                {
                    sub = _myCalculator.Sub(sub, items[i]);
                }
                return sub;
            }

            public T Multiply(List<T> items)
            {
                dynamic mul = 1;

                for (int i = 0; i < items.Count; i++)
                {
                    mul = _myCalculator.Multiply(mul, items[i]);
                }
                return mul;
            }
            public T Divide(List<T> items)
            {
                dynamic div = 1;
                for (int i = 0; i < items.Count; i++)
                {
                    if (div == 1)
                    {

                        div = _myCalculator.Divide(items[i], div);
                    }
                    else

                    {
                        div = _myCalculator.Divide(div, items[i]);

                    }
                }

                return div;
            }
        }

        public class Generics
        {
            public static void Main(string[] args)
            {
                ArithmeticOperation<int> intOperation = new(new IntCalculator());
                List<int> numbers = new List<int> { 20,10};

                Console.WriteLine("Addition : {0}", intOperation.Sum(numbers));
                Console.WriteLine("Substraction : {0}", intOperation.Sub(numbers));
                Console.WriteLine("Mulitplication : {0}", intOperation.Multiply(numbers));
                Console.WriteLine("Division : {0}", intOperation.Divide(numbers));
            }
        }


    }
}
