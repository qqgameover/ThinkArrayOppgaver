using System;
using System.Linq;

namespace ThinkArrayOppgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSorted());
            Console.WriteLine(CipherText("Hei hvordan har du det"));
            Console.WriteLine(SuperCipher("Hei hvordan har du det"));
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
            Console.WriteLine(charText);
            string fixedText = ReturnCypherToPlain(charText);
            string returnString = new string(charText);
            return returnString;
        }

        private static string ReturnCypherToPlain(char[] cypherText)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i < cypherText.Length; i++)
            {
                for (int j = 0; j < alpha.Length; j++)
                {
                    if(j == 0) continue;
                    if(cypherText[i] != alpha[j]) continue;
                    cypherText[i] = alpha[j - 1];
                    break;
                }
            }
            string returnString = new string(cypherText);
            return returnString;
        }

        private static string SuperCipher(string cipherText)
        {
            Random rnd = new Random();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] shuffled = alpha.OrderBy(x => rnd.Next()).ToArray();
            string upperCased = cipherText.ToUpper();
            char[] charText = upperCased.ToCharArray();

            for (int i = 0; i < charText.Length; i++)
            {
                for (int j = 0; j < shuffled.Length; j++)
                {
                    if (j == 0) continue;
                    if (charText[i] != shuffled[j]) continue;
                    charText[i] = shuffled[j - 1];
                    break;
                }
            }

            string toStringValue = new string(charText);
            Console.WriteLine(toStringValue);
            return toStringValue;
        }
    }
}
