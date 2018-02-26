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
            foreach (string geneName in ExtensionMethods.GetGeneNames())
            {
                // zygot = GetRandomGene(geneName);
            }
            if (zygot != Alpha && zygot != Beta) return true;
            else return false;
        }

        private Gene GetRandomGene(string input)
        {
            if (ExtensionMethods.GetChance() < 51) return GetProperty(input, Alpha);
            else return GetProperty(input, Beta);
        }

        private Gene GetProperty(string name, Helix helix)
        {
            switch (name)
            {
                case "Race": return helix.Race;
                case "Strength": return helix.Strength;
                case "Dexterity": return helix.Dexterity;
                case "Constitution": return helix.Constitution;
                case "Intelligence": return helix.Intelligence;
                case "Wisdom": return helix.Wisdom;
                case "Charisma": return helix.Charisma;
                case "Arcane": return helix.Arcane;
                case "Divine": return helix.Divine;
                default: return new Gene();
            }
        }
    }
}