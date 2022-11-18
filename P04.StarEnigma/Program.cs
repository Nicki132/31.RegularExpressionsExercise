using System;
using System.Text;
using System.Text.RegularExpressions;

namespace P04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = DecryptMessage(encryptedMessage);
            }
        }

        static DecryptMessage(string encryptedMessage)
        {
            StringBuilder decryptedMessage = new StringBuilder();
            int decryptionKey = GetDecryptionKey(encryptedMessage);

            foreach (char currCh in encryptedMessage)
            {
                char decryptedCh = (char)(currCh - decryptionKey);
                decryptedMessage.Append(decryptedCh);
            }

            return decryptedMessage.ToString();
        }

        static int GetDecryptionKey(string encryptedMessage)
        {
            string decryptPattern = "[star]{1}";
            MatchCollection matches =
                Regex.Matches(encryptedMessage, decryptPattern, RegexOptions.IgnoreCase);
            return matches.Count;
        }
    }
}
