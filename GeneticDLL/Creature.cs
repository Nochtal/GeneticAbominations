namespace GeneticDLL
{
    public class Creature
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Generation { get; set; }
        public string ParentOne { get; set; }
        public string ParentTwo { get; set; }
        public DNA Genetics { get; set; }

        public Creature(string name, int age, int generation, string parentOne, string parentTwo, DNA genetics)
        {
            Name = name;
            Age = age;
            Generation = generation;
            ParentOne = parentOne;
            ParentTwo = parentTwo;
            Genetics = genetics;
        }       
    }
}