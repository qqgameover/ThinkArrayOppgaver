using System;

namespace ThinkArrayOppgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSorted());
            Console.WriteLine(CipherText("Hei hvordan har du det"));
        }

        private static bool IsSorted()
        {
            int[] intArray = { 4, 5, 9, 12, -4, 0, -57, 30987, -287, 1 };
            Array.Sort(intArray);
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] < intArray[i - 1]) return false;
            }
            return true;
        }

        private static string CipherText(string text)
        {
            var charText = new char[text.Length];
            for (int i = 0; i < charText.Length; i++)
            {
                charText[i] = Convert.ToChar(text[i] + 1);
            }
            string returnString = new string(charText);
            return returnString;
        }
    }
}
