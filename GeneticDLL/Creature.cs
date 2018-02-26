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

        public Creature(int generation, string parentOne, string parentTwo, DNA genetics, string name = null, int age = 1)
        {
            if (Name == null) Name = ExtensionMethods.GenerateName();
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
    }
}