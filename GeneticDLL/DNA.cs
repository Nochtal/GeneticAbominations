namespace GeneticDLL
{
    public class DNA
    {
        public Helix Alpha { get; set; }
        public Helix Beta { get; set; }

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
        public int Arcane { get { return CalculateGeneResult(Alpha.Arcane, Beta.Arcane); } }
        public int Divine { get { return CalculateGeneResult(Alpha.Divine, Beta.Divine); } }

        private int CalculateGeneResult(Gene alphaGene, Gene betaGene)
        {
            if (alphaGene.Weight == 1 || betaGene.Weight == 1)
                return (alphaGene.Value * alphaGene.Weight) + (betaGene.Value * betaGene.Weight) + (alphaGene.Deviation + betaGene.Deviation);
            else return (alphaGene.Value > betaGene.Value ? alphaGene.Value : betaGene.Value) + (alphaGene.Deviation + betaGene.Deviation);
           
        }
    }
}
