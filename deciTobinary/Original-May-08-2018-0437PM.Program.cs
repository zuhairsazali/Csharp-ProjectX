using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deciTobinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            string result;
            string idName = "zozo";

            Console.WriteLine("Password?");
            idName = Console.ReadLine();

            if (idName == "zozo")
            {
                Console.WriteLine("yes you right!");
            }
            else
            {
                Console.WriteLine("wrong!");
            }

            ////////////////////////////////// password ////////////////////////////////////////////////////////

            Console.Write("Input a Number : ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";

            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);

            /////////////////////////////////// change binary to deci ////////////////////////////////////////

            
        }
    }
}