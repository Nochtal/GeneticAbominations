using System;
using System.Text;

namespace GeneticDLL
{
    public static class Utility
    {
        public static string Name()
        {
            string[] parts = new string[]
            {
                "a", "e", "u", "i", "o",
                "ka", "ke", "ku", "ki", "ko",
                "sa", "se", "su", "shi", "so",
                "ta", "te", "tsu", "ti", "to",
                "na", "ne", "nu", "ni", "no",
                "ha", "he", "hu", "hi", "ho",
                "ma", "me", "mu", "mi", "mo",
                "ya", "yu", "yo",
                "wa", "wu", "wo",
                "n",
                "ga", "ge", "gu", "gi", "go",
                "za", "ze", "zu", "ji", "zo",
                "da", "de", "du", "ji", "do",
                "ba", "be", "bu", "bi", "bo",
                "pa", "pe", "pu", "pi", "po",
                "kya", "kyu", "kyo",
                "gya", "gyu", "gyo",
                "nya", "nyu", "nyo",
                "hya", "hyu", "hyo",
                "bya", "byu", "byo",
                "pya", "pyu", "pyo",
                "ja", "ju", "jo", "je",
                "cha", "chu", "che", "cho",
                "sha", "shu", "she", "sho",
                "wi", "we", "wo", "ti", "di", "tu", "dyu", "fi", "fe", "fo","fyu"
            };
            Random roll = new Random(Guid.NewGuid().GetHashCode());
            StringBuilder sb = new StringBuilder();
            int length = roll.Next(2, 6);
            for (int i = 0; i < length; i++)
            {
                sb.Append(parts[roll.Next(0, parts.Length)]);
            }

            sb[0] = char.ToUpper(sb[0]);
            return sb.ToString();
        }

    }
}