using System;
using System.Collections.Generic; 

namespace sum8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = {1 ,2, 4, 4};
            Console.WriteLine(HasPairWithSum(new List<int>(array1), 8));
        }

        private static bool HasPairWithSum(List<int> data, int sum)
        {
            List<int> comp = new List<int>();
            foreach (int value in data) {
                if (comp.Contains(value))
                    return true;
                comp.Add(sum - value);
            }
            return false;
        }
    }
}
