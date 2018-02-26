using System.Reflection;

namespace GeneticDLL
{
    public class DNA
    {
        public Helix Alpha { get; set; }
        public Helix Beta { get; set; }

        public DNA()
        {
            Alpha = new Helix();
            Beta = new Helix();
        }
        public DNA(Helix alpha, Helix beta)
        {
            Alpha = alpha;
            Beta = beta;
        }

        public int Race { get { return CalculateGeneResult(Alpha.Race, Beta.Race); } }
        public int Strength { get { return CalculateGeneResult(Alpha.Strength, Beta.Strength); } }
        public int Dexterity { get { return CalculateGeneResult(Alpha.Dexterity, Beta.Dexterity); } }
        public int Constitution { get { return CalculateGeneResult(Alpha.Constitution, Beta.Constitution); } }
        public int Intelligence { get { return CalculateGeneResult(Alpha.Intelligence, Beta.Intelligence); } }
        public int Wisdom { get { return CalculateGeneResult(Alpha.Wisdom, Beta.Wisdom); } }
        public int Charisma { get { return CalculateGeneResult(Alpha.Charisma, Beta.Charisma); } }
        public int Arcane { get { return CalculateGeneResult(Alpha.Arcane, Beta.Arcane); } }
        public int Divine { get { return CalculateGeneResult(Alpha.Divine, Beta.Divine); } }

        private int CalculateGeneResult(Gene alphaGene, Gene betaGene)
        {
            if (alphaGene.Weight == 1 || betaGene.Weight == 1)
                return (alphaGene.Value * alphaGene.Weight) + (betaGene.Value * betaGene.Weight) + (alphaGene.Deviation + betaGene.Deviation);
            else return (alphaGene.Value > betaGene.Value ? alphaGene.Value : betaGene.Value) + (alphaGene.Deviation + betaGene.Deviation);
           
        }

        public bool GenerateZygot(out Helix zygot)
        {
            zygot = Alpha;
            if (ExtensionMethods.GetChance() < 51) zygot.Race = Beta.Race;
            if (ExtensionMethods.GetChance() < 51) zygot.Strength = Beta.Strength;
            if (ExtensionMethods.GetChance() < 51) zygot.Dexterity = Beta.Dexterity;
            if (ExtensionMethods.GetChance() < 51) zygot.Constitution = Beta.Constitution;
            if (ExtensionMethods.GetChance() < 51) zygot.Intelligence = Beta.Intelligence;
            if (ExtensionMethods.GetChance() < 51) zygot.Wisdom = Beta.Wisdom;
            if (ExtensionMethods.GetChance() < 51) zygot.Charisma = Beta.Charisma;
            if (ExtensionMethods.GetChance() < 51) zygot.Arcane = Beta.Arcane;
            if (ExtensionMethods.GetChance() < 51) zygot.Divine = Beta.Divine;
            if (zygot != Alpha && zygot != Beta) return true;
            else return false;
        }
    }
}