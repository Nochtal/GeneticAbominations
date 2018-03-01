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
        public Gene Wisdom { get; set; }
        public Gene Charisma { get; set; }
        public Gene Arcane { get; set; }
        public Gene Divine { get; set; }

        public int DeviationIndex { get; set; }

        private int calculateDeviationIndex()
        {
            return Math.Abs(Race.Deviation) + Math.Abs(Strength.Deviation) + Math.Abs(Dexterity.Deviation) + Math.Abs(Constitution.Deviation) + Math.Abs(Intelligence.Deviation) + Math.Abs(Wisdom.Deviation) + Math.Abs(Charisma.Deviation) + Math.Abs(Arcane.Deviation) + Math.Abs(Divine.Deviation);
        }

        public Helix()
        {
            Race = new Gene();
            Strength = new Gene();
            Dexterity = new Gene();
            Constitution = new Gene();
            Intelligence = new Gene();
            Charisma = new Gene();
            Wisdom = new Gene();
            Arcane = new Gene();
            Divine = new Gene();
            DeviationIndex = calculateDeviationIndex();
        }
        public Helix(Gene race, 
                     Gene strength, 
                     Gene dexterity, 
                     Gene constitution, 
                     Gene intelligence, 
                     Gene wisdom, 
                     Gene charisma, 
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
            DeviationIndex = calculateDeviationIndex();
        }

        public override string ToString()
        {
            return String.Format("Race: {0}\nStrength: {1}\nDexterity: {2}\nConstitution: {3}\nIntelligence: {4}\nWisdom: {5}\nCharisma: {6}\nArcane: {7}\nDivine: {8}\nDeviation Index: {9}",
                Race.ToString(),
                Strength.ToString(),
                Dexterity.ToString(),
                Constitution.ToString(),
                Intelligence.ToString(),
                Wisdom.ToString(),
                Charisma.ToString(),
                Arcane.ToString(),
                Divine.ToString(),
                DeviationIndex);
        }
    }
}