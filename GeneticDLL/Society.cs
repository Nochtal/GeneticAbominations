using System.Collections.Concurrent;

namespace GeneticDLL
{
    public class Society
    {
        public string Name { get; set; }
        public ConcurrentBag<Creature> Creatures { get; set; }

        public Society(string name, ConcurrentBag<Creature> creatures)
        {
            Name = name;
            Creatures = creatures;
        }
    }
}