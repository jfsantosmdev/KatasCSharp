using System;
using System.Linq;

namespace KatasCSharp.DetectPangram
{
    public class DetectPangramKata
    {
        public static bool IsPangram(string str)
        {
            return str.ToLower().Where(c => char.IsLetter(c)).GroupBy(c => c).Count() == 26;
        }
    }
}
