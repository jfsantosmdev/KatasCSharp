using System;

namespace KatasCSharp.StopSpinningMyWords
{
    public class StopSpinningMyWordsKata
    {
        public static string SpingWords(string s)
        {
            var sArr = s.Split(" ");
            string strResult = string.Empty;
            for (int i = 0; i < sArr.Length; i++)
            {
                if(sArr[i].Length > 4)
                {
                    strResult += Reverse(sArr[i]) + " ";
                }
                else
                {
                    strResult += sArr[i] + " ";
                }
            }
            
            return strResult.Trim();
        }

        private static string Reverse(string s)
        {
            string newString = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
                newString += s[i];

            return newString;
        }
    }
}
