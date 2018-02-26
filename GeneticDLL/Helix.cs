using System;

namespace GeneticDLL
{
    public class Helix
    {
        public Gene Race { get; set; }
        public Gene Strength { get; set; }
        public Gene Dexterity { get; set; }
        public Gene Constitution { get; set; }
        public Gene Intelligence { get; set; }
        public Gene Charisma { get; set; }
        public Gene Wisdom { get; set; }
        public Gene Arcane { get; set; }
        public Gene Divine { get; set; }

        public Helix(Gene race, 
                     Gene strength, 
                     Gene dexterity, 
                     Gene constitution, 
                     Gene intelligence, 
                     Gene charisma, 
                     Gene wisdom, 
                     Gene arcane, 
                     Gene divine)
        {
            Race = race;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Charisma = charisma;
            Wisdom = wisdom;
            Arcane = arcane;
            Divine = divine;
        }

        public override string ToString()
        {
            return String.Format("Race: {0}\nStrength: {1}\nDexterity: {2}\nConstitution: {3}\nIntelligence: {4}\nCharisma: {5}\nWisdom: {6}\nArcane {7}\nDivine: {8}.",
                Race.ToString(),
                Strength.ToString(),
                Dexterity.ToString(),
                Constitution.ToString(),
                Intelligence.ToString(),
                Wisdom.ToString(),
                Arcane.ToString(),
                Divine.ToString());
        }
    }
}