using System; 

namespace DLithe2
{
    public class DLithe_Batch2
    {
        public static void Main()
        {
            //Datatypes
            int a = 7;
            Console.WriteLine("Integer Value is:{0}", a);
            float b = 3.14f;
            double c = 123.45678;
            Console.WriteLine("Float Value is:{0} and Double Value is:{1}", b, c);

            string d = "Abishek";
            Console.WriteLine($"String Value is:{d}");
            double g = 12.34;
            Console.WriteLine("Double Value is:{0}", g);
            int h = (int)g;
            Console.WriteLine("Double converted to int value:{0}", h);
            Console.WriteLine($"Convert the int value {h} to char" + Convert.ToChar(h));
            Console.WriteLine("Convert the given integer value to char" + Convert.ToChar(65));


            //Accept Traniee Details
            int TID;
            string TName;
            string TDes;
            Console.WriteLine("Enter the Trainee ID");
            TID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Trainee Name and Designation");
            TName = Console.ReadLine();
            TDes = Console.ReadLine();
            Console.WriteLine($"The Trainee ID is {TID}.\nTrainee Name is {TName}.\nTrainee Designation is {TDes}");


           
        }
    }


}