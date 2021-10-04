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
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string upperCased = text.ToUpper();
            var charText = upperCased.ToCharArray();
            for (int i = 0; i < charText.Length; i++)
            {
                for (int j = 0; j < alpha.Length; j++)
                {
                    if (charText[i] != alpha[j]) continue;
                    if (j == 25) continue;
                    charText[i] = alpha[j + 1];
                    break;
                }
            }
            string returnString = new string(charText);
            return returnString;
        }
    }
}
