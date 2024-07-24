using System;

namespace zadanie2
{
    class Program
    {   
        static public bool TryParseToNegative(string value,out int result)
        {
            if (int.TryParse(value,out result))
            {
                if (result < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        static  public bool methods(string value,out int result) 
        {
            return int.TryParse(value, out result);
        }
        static void Main(string[] args) 
        {
            int result;

            Console.WriteLine("input negative value");

            if (methods(Console.ReadLine(), out result))
            {
                Console.WriteLine($" your value {result}");
            }
            else
            {
                Console.WriteLine("invalid value");
            }
        }
    }
}