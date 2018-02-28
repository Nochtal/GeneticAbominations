using System;
using System.Text;

namespace GeneticDLL
{
    public static class ExtensionMethods
    {
        private static Random roll = new Random(Guid.NewGuid().GetHashCode());
        private static string[] nameParts = new string[]
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
            "wi", "we", "wo", "ti", "di",
            "tu", "dyu", "fi", "fe", "fo","fyu"
        };

        public static string[] SocietyType = new string[]
        {
            "Republic",
            "Kingdom",
            "Empire",
            "Commonwealth",
            "Federation",
            "Colony",
            "Principality",
            "Protectorate",
            "United States",
            "United Kingdom",
            "People's Republic",
            "Democratic Republic",
            "Confederacy",
            "Dominion",
            "Sultanate",
            "Holy Empire",
            "Theocracy",
            "Most Serene Republic",
            "United Socialist States",
            "Democratic States",
            "Allied States",
            "Queendom",
            "Fiefdom",
            "Constitutional Monarchy",
            "Dictatorship",
            "Matriarchy",
            "Emirate",
            "Grand Duchy",
            "Free Land",
            "Community",
            "Disputed Territories",
            "Jingoistic States",
            "Armed Republic",
            "Nomadic Peoples",
            "Oppressed Peoples",
            "Borderlands",
            "Rogue Nation",
            "Incorporated States",
            "Federal Republic"
        };

        public static string GenerateSocietyName()
        {
            return GenerateName() + (GetChance() < 51 ? (" " + GenerateName()) : GenerateName() );
        }

        public static string GenerateSocietyClassifier()
        {
            return SocietyType[GetRandom(0, SocietyType.Length)];
        }

        public static string GenerateName()
        {
            StringBuilder sb = new StringBuilder();
            int length = roll.Next(2, 5);
            for (int i = 0; i < length; i++)
            {
                sb.Append(nameParts[roll.Next(0, nameParts.Length)]);
            }

            sb[0] = char.ToUpper(sb[0]);
            return sb.ToString();
        }

        public static int GetRandom(int min, int max) { return roll.Next(min, max + 1); }

        public static int GetChance() { return GetRandom(1, 100); }
    }
}