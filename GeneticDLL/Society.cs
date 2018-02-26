using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneticDLL
{
    public class Society
    {
        public string Name { get; set; }
        public ConcurrentDictionary<string, Creature> Creatures { get; private set; }

        public Society(string name, ConcurrentDictionary<string, Creature> creatures)
        {
            Name = name;
            if (Creatures.Count > 0) Creatures = creatures;
            else Creatures = new ConcurrentDictionary<string, Creature>();
        }

        public bool GetCreatures(out IList<Creature> CreaturesList)
        {
            /// Get full List of Creatures
            CreaturesList = new List<Creature>(); /// currently here to remove error
            CreaturesList = new List<Creature>(Creatures.Values.ToList());
            if (CreaturesList.Count > 0) return true;
            else return false;
        }

        public bool GetCreatures(Creature c, out Creature creature)
        {
            /// Get single specific Creature
            return Creatures.TryGetValue(c.Name, out creature);
        }

        public bool AddCreature(Creature c)
        {
            return Creatures.TryAdd(c.Name, c);
        }

        public bool RemoveCreature(Creature c, Creature CreatureCheck = null)
        {
            return Creatures.TryRemove(c.Name, out CreatureCheck);
        }

        public bool UpdateCreature(Creature c, Creature CreatureCheck = null)
        {
            bool cc = GetCreatures(c, out CreatureCheck);
            if (!cc) return AddCreature(c);
            return Creatures.TryUpdate(c.Name, c, CreatureCheck);
        }
    }
}