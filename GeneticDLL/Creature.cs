using System;
using System.Text;

namespace GeneticDLL
{
    [Serializable]
    public class Creature
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Generation { get; set; }
        public string ParentOne { get; set; }
        public string ParentTwo { get; set; }
        public DNA Genetics { get; set; }

        public Creature()
        {
            Name = ExtensionMethods.GenerateName();
            Age = ExtensionMethods.GetRandom(16, 50);
            Generation = 1;
            ParentOne = "Underlord Ada";
            ParentTwo = "Mysterious B";
            Genetics = new DNA();
        }
        public Creature(Creature pOne, Creature pTwo)
        {
            Name = ExtensionMethods.GenerateName();
            Age = 0;
            Generation = (pOne.Generation == pTwo.Generation ? pOne.Generation + 1 : (pOne.Generation > pTwo.Generation ? pOne.Generation + 1 : pTwo.Generation + 1));
            ParentOne = pOne.Name;
            ParentTwo = pTwo.Name;
            Helix pOneZygot;
            Helix pTwoZygot;
            if (pOne.Genetics.GenerateZygot(out pOneZygot) && pTwo.Genetics.GenerateZygot(out pTwoZygot))
            {
                Genetics = new DNA(pOneZygot, pTwoZygot);
            }
        }
        public Creature(int generation, string parentOne, string parentTwo, DNA genetics, string name = "RANDOM", int age = 1)
        {
            if (name == "RANDOM") Name = ExtensionMethods.GenerateName();
            else Name = name;
            Age = age;
            Generation = generation;
            ParentOne = parentOne;
            ParentTwo = parentTwo;
            Genetics = genetics;
        }
        
        public int GetMaxAge()
        {
            return (Genetics.Constitution * Genetics.Race + Genetics.Divine) + 50;
        }

        public string GetRace()
        {
            if (Genetics.Race <= 0) return "Troll";
            else if (Genetics.Race >= 1 && Genetics.Race <= 4) return "Dwarf";
            else if (Genetics.Race >= 5 && Genetics.Race <= 12) return "Human";
            else if (Genetics.Race >= 13 && Genetics.Race <= 18) return "Half-Elf";
            else return "Elf";
        }

        public string DeathString(int Year)
        {
            return String.Format("{0}, {1}, Died at {2} years of age in the Year {3}. Generation: {4}.\n\t\tParents: {5} and {6}.",
                Name,
                GetRace(),
                GetMaxAge(),
                Year,
                Generation,
                ParentOne,
                ParentTwo);
        }

        public string PrintString()
        {
            return string.Format("{0}, {1} year old {2}. {3} generation. Parents: {4} and {5}.",
                Name,
                Age,
                GetRace(),
                GetGenerationString(),
                ParentOne,
                ParentTwo);
        }

        public override string ToString()
        {
            /// Name
            /// Age year old Race
            /// Generation generation
            /// Parents: ParentOne, ParentTwo
            /// 
            /// Strength:       Result (2 tabs)
            /// Dexterity:      Result (2 tabs)
            /// Constitution:   Result (1 tab)
            /// Intelligence:   Result (1 tab)
            /// Wisdom:         Result (3 tab)
            /// Charisma:       Result (2 tab)
            /// Arcane:         Result (3 tab)
            /// Divine:         Result (3 tab)
            /// 
            /// Alpha Helix string
            /// Beta Helix string

            return String.Format("{0}\n{1} year old {2}\n{3} generation\nParents: {4} and {5}\n\nStrength:\t\t{6, 2}\nDexterity:\t\t{7, 2}\nConstitution:\t\t{8, 2}\nIntelligence:\t\t{9, 2}\nWisdom:\t\t{10, 2}\nCharisma:\t\t{11, 2}\nArcane:\t\t{12, 2}\nDivine:\t\t\t{13, 2}\n\nAlpha Helix:\n{14}\n\nBeta Helix:\n{15}",
                Name,
                Age,
                GetRace(),
                GetGenerationString(),
                ParentOne,
                ParentTwo,
                Genetics.Strength,
                Genetics.Dexterity,
                Genetics.Constitution,
                Genetics.Intelligence,
                Genetics.Wisdom,
                Genetics.Charisma,
                Genetics.Arcane,
                Genetics.Divine,
                Genetics.Alpha.ToString(),
                Genetics.Beta.ToString()
                );

        }

        private string GetGenerationString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Generation);
            switch (sb[sb.Length -1])
            {
                case '1':
                    sb.Append("st");
                    break;
                case '2':
                    sb.Append("nd");
                    break;
                case '3':
                    sb.Append("rd");
                    break;
                case '0':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    sb.Append("th");
                    break;
            }
            return sb.ToString();
        }
    }
}