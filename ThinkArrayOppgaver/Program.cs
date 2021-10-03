using System;
using System.Reflection.Metadata.Ecma335;

namespace ThinkArrayOppgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSorted());
        }

        private static bool IsSorted()
        {
            int[] intArray = new[] { 4, 5, 9, 12, -4, 0, -57, 30987, -287, 1 };
            Array.Sort(intArray);
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] < intArray[i - 1]) return false;
            }

            return true;
        }
    }
}
