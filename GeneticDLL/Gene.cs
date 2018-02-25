using System;

namespace GeneticDLL
{
    public class Gene
    {
        public int Value { get; set; }
        public int Weight { get; set; }
        public int Deviation { get; set; }

        public Gene()
        {
            Value = Utility.GetRandom(1, 10);
            Weight = Utility.GetRandom(0, 1);
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

        private int Mutate()
        {
            if (Utility.GetRandom(1, 100) < 51)
                return Utility.GetRandom(-2, 2);
            else
                return 0;
        }

        public override string ToString()
        {
            return String.Format("Value {0}. Weight {1}. Aberration {2}.", Value, Weight, Deviation);
        }
    }
}