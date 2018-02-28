using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneticDLL
{
    public class Society
    {
        public string Name { get; set; }
        public string Classification { get; set; }
        public ConcurrentDictionary<string, Creature> Creatures { get; private set; }
        public ConcurrentBag<string> Graveyard { get; private set; }

        public Society()
        {
            Name = ExtensionMethods.GenerateSocietyName();
            Classification = ExtensionMethods.GenerateSocietyClassifier();
            Creatures = new ConcurrentDictionary<string, Creature>();
            Graveyard = new ConcurrentBag<string>();
            bool check = false;
            Parallel.For(0, 4, i => { AddCreature(new Creature()); });
        }
        public Society(params Creature[] creatures)
        {
            Name = ExtensionMethods.GenerateSocietyName();
            Classification = ExtensionMethods.GenerateSocietyClassifier();
            Creatures = new ConcurrentDictionary<string, Creature>();
            Graveyard = new ConcurrentBag<string>();
            Parallel.ForEach(creatures, (currentCreature) => { AddCreature(currentCreature); });
        }
        public Society(string name, string classifier, params Creature[] creatures)
        {
            Name = name;
            Classification = classifier;
            Creatures = new ConcurrentDictionary<string, Creature>();
            Graveyard = new ConcurrentBag<string>();
            Parallel.ForEach(creatures, (currentCreature) => { AddCreature(currentCreature); } );
        }
        public Society(string name, string classifier, List<Creature> creatures)
        {
            Name = name;
            Classification = classifier;
            Creatures = new ConcurrentDictionary<string, Creature>();
            Graveyard = new ConcurrentBag<string>();
            Parallel.ForEach(creatures, (currentCreature) => { AddCreature(currentCreature); });
        }

        public bool GetCreatures(out List<Creature> CreaturesList)
        {
            CreaturesList = new List<Creature>(Creatures.Values.ToList());
            if (CreaturesList.Count > 0) return true;
            else return false;
        }

        public bool GetCreatures(Creature c, out Creature creature)
        {
            return Creatures.TryGetValue(c.Name, out creature);
        }

        public bool GetGraveyard(out List<string> graveyard)
        {
            graveyard = Graveyard.ToList();
            if (graveyard.Count == Graveyard.Count) return true;
            else return false;
        }

        public bool AddCreature(Creature c)
        {
            return Creatures.TryAdd(c.Name, c);
        }

        public bool RemoveCreature(Creature c)
        {
            Creature CreatureCheck;
            return Creatures.TryRemove(c.Name, out CreatureCheck);

        }

        public bool UpdateCreature(Creature c)
        {
            Creature CreatureCheck;
            bool cc = GetCreatures(c, out CreatureCheck);
            if (!cc) return false;
            return Creatures.TryUpdate(c.Name, c, CreatureCheck);
        }

        public void AdvanceAge(int years)
        {
            Parallel.ForEach(Creatures, (currentCreature) =>
            {
                currentCreature.Value.Age += years;
                if (currentCreature.Value.Age > currentCreature.Value.GetMaxAge())
                {
                    RemoveCreature(currentCreature.Value);
                    Graveyard.Add(currentCreature.Value.DeathString());
                }
            });
            if (Creatures.Count == 0) Parallel.For(0, 4, i => { AddCreature(new Creature()); });
        }
    }
}