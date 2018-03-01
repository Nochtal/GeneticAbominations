using System;

namespace GeneticDLL
{
    [Serializable]
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

        public int DeviationIndex { get {
                return Alpha.DeviationIndex + Beta.DeviationIndex;
            } }

        private int CalculateGeneResult(Gene alphaGene, Gene betaGene)
        {
            if (alphaGene.Weight == 1 || betaGene.Weight == 1)
                return (alphaGene.Value * alphaGene.Weight) + (betaGene.Value * betaGene.Weight) + (alphaGene.Deviation + betaGene.Deviation);
            else return (alphaGene.Value > betaGene.Value ? alphaGene.Value : betaGene.Value) + (alphaGene.Deviation + betaGene.Deviation);
        }

        public bool GenerateZygot(out Helix zygot)
        {
            zygot = new Helix(
                ((ExtensionMethods.GetChance() < 51) ? new Gene((Alpha.Race.Value + Alpha.Race.Deviation), Alpha.Race.Weight) : new Gene((Beta.Race.Value + Beta.Race.Deviation), Beta.Race.Weight)),
                ((ExtensionMethods.GetChance() < 51) ? new Gene((Alpha.Strength.Value + Alpha.Strength.Deviation), Alpha.Strength.Weight) : new Gene((Beta.Strength.Value + Beta.Strength.Deviation), Beta.Strength.Weight)),
                ((ExtensionMethods.GetChance() < 51) ? new Gene((Alpha.Dexterity.Value + Alpha.Dexterity.Deviation), Alpha.Dexterity.Weight) : new Gene((Beta.Dexterity.Value + Beta.Dexterity.Deviation), Beta.Dexterity.Weight)),
                ((ExtensionMethods.GetChance() < 51) ? new Gene((Alpha.Constitution.Value + Alpha.Constitution.Deviation), Alpha.Constitution.Weight) : new Gene((Beta.Constitution.Value + Beta.Constitution.Deviation), Beta.Constitution.Weight)),
                ((ExtensionMethods.GetChance() < 51) ? new Gene((Alpha.Intelligence.Value + Alpha.Intelligence.Deviation), Alpha.Intelligence.Weight) : new Gene((Beta.Intelligence.Value + Beta.Intelligence.Deviation), Beta.Intelligence.Weight)),
                ((ExtensionMethods.GetChance() < 51) ? new Gene((Alpha.Wisdom.Value + Alpha.Wisdom.Deviation), Alpha.Wisdom.Weight) : new Gene((Beta.Wisdom.Value + Beta.Wisdom.Deviation), Beta.Wisdom.Weight)),
                ((ExtensionMethods.GetChance() < 51) ? new Gene((Alpha.Charisma.Value + Alpha.Charisma.Deviation), Alpha.Charisma.Weight) : new Gene((Beta.Charisma.Value + Beta.Charisma.Deviation), Beta.Charisma.Weight)),
                ((ExtensionMethods.GetChance() < 51) ? new Gene((Alpha.Arcane.Value + Alpha.Arcane.Deviation), Alpha.Arcane.Weight) : new Gene((Beta.Arcane.Value + Beta.Arcane.Deviation), Beta.Arcane.Weight)),
                ((ExtensionMethods.GetChance() < 51) ? new Gene((Alpha.Divine.Value + Alpha.Divine.Deviation), Alpha.Divine.Weight) : new Gene((Beta.Divine.Value + Beta.Divine.Deviation), Beta.Divine.Weight)));
            if (zygot != Alpha && zygot != Beta) return true;
            else return false;
        }
    }
}