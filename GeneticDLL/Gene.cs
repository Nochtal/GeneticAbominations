using System;

namespace GeneticDLL
{
    [Serializable]
    public class Gene
    {
        public int Value { get; set; }
        public int Weight { get; set; }
        public int Deviation { get; set; }

        public Gene()
        {
            Value = ExtensionMethods.GetRandom(1, 10);
            Weight = ExtensionMethods.GetRandom(0, 1);
            Deviation = Mutate();
        }
        public Gene(int value, int weight)
        {
            Value = value;
            Weight = weight;
            Deviation = Mutate();
        }
        public Gene(int value, int weight, int deviation)
        {
            Value = value;
            Weight = weight;
            Deviation = deviation;
        }

        public int Mutate()
        {
            if (ExtensionMethods.GetRandom(1, 100) < 51)
                return ExtensionMethods.GetRandom(-2, 2);
            else
                return 0;
        }

        public override string ToString()
        {
            return String.Format("Value {0}, Weight {1}, Deviation {2}.", Value, Weight, Deviation);
        }
    }
}