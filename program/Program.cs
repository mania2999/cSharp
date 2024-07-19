using System;

namespace Yield
{
    class Program
    {
        public static IEnumerable<int> GetData()  // funkcja mniej optymalna zwraca cała liste naraz
        {
            Console.WriteLine("start");
            var result = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"function:{i}");     
                result.Add(i);
            }
            Console.WriteLine("stop");
            return result;
        }

        public static IEnumerable<int> GetYield() // funkcja bardziej optymalna yield sprawia ze nie zwracamy calej kolecji naraz tylko tyle ile potrzebujemy 
        {
            Console.WriteLine("start");
            for(int i=0; i < 10; i++)
            {
                if (i == 7)
                {
                    yield break;     // yield brake przerwie cala kolekcje i tym samym zokonczy funkcje 
                }
                Console.WriteLine($"function:{i}");
                yield return i;

            }
            Console.WriteLine("end");
        }


        static void Main(string[] args)
        {
            var Data = GetYield();
            foreach(int element in Data)
            {
                Console.WriteLine($"main : {element}");
            }
        }
    }
}
