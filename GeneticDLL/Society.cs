using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace GeneticDLL
{
    public class Society
    {
        public string Name { get; set; }
        public ConcurrentDictionary<string, Creature> Creatures { get; private set; }

        public Society(string name, ConcurrentDictionary<string, Creature> creatures)
        {
            Name = name;
            Creatures = creatures;
        }

        public Dictionary<string, Creature> GetCreatures()
        {
            return null;
        }

        public bool AddCreature(Creature c)
        {
            return false;   
        }

        public bool RemoveCreature(Creature c)
        {
            Creature CreatureCheck = null;
            bool check = Creatures.TryRemove(c.Name, out CreatureCheck);
            if (check && CreatureCheck == c)
                return true;
            else return false;
        }

        public bool UpdateCreature(Creature c)
        {
            return Creatures.TryUpdate(c.Name, c, c);
        }
    }
}