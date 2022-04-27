using System;
using System.Text.RegularExpressions;

namespace csharpconcepts
{
    internal class RegExp
    {
        public static void Main()
        {
            MobileValidation();
            Console.ReadLine();
        }

        public static void MobileValidation()
        {
            string[] mobile = { "+91974451479", "9988675435" };
            foreach (string m in mobile)
            {
                Console.WriteLine(m);
                Console.WriteLine(checkMobile(m));
            }
        }
        public static bool checkMobile(string mobile)
        {
            string mregexp = @"^([\+]?91[-]?|[0])?[1-9][0-9]{8}$";
            Regex r = new Regex(mregexp);
            if (r.IsMatch(mobile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}