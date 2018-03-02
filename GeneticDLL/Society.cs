using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticDLL
{
    [Serializable]
    public class Society
    {
        public string Name { get; set; }
        public string Classification { get; set; }
        public ConcurrentDictionary<string, Creature> Creatures { get; private set; }
        public ConcurrentBag<string> Graveyard { get; private set; }
        public int Year { get; set; }

        public Society()
        {
            Name = ExtensionMethods.GenerateSocietyName();
            Classification = ExtensionMethods.GenerateSocietyClassifier();
            Creatures = new ConcurrentDictionary<string, Creature>();
            Graveyard = new ConcurrentBag<string>();
            Year = 1;
            Parallel.For(0, 4, i => { AddCreature(new Creature()); });
        }
        public Society(params Creature[] creatures)
        {
            Name = ExtensionMethods.GenerateSocietyName();
            Classification = ExtensionMethods.GenerateSocietyClassifier();
            Creatures = new ConcurrentDictionary<string, Creature>();
            Graveyard = new ConcurrentBag<string>();
            Year = 1;
            Parallel.ForEach(creatures, (currentCreature) => { AddCreature(currentCreature); });
        }
        public Society(string name, string classifier, params Creature[] creatures)
        {
            Name = name;
            Classification = classifier;
            Creatures = new ConcurrentDictionary<string, Creature>();
            Graveyard = new ConcurrentBag<string>();
            Year = 1;
            Parallel.ForEach(creatures, (currentCreature) => { AddCreature(currentCreature); } );
        }
        public Society(string name, string classifier, List<Creature> creatures, int year = 1)
        {
            Name = name;
            Classification = classifier;
            Creatures = new ConcurrentDictionary<string, Creature>();
            Graveyard = new ConcurrentBag<string>();
            Year = year;
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
        public void AddCreature(List<Creature> temp)
        {
            Parallel.ForEach(temp, creature => { AddCreature(creature); });
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
            Year += years;
            if (Creatures.Count == 0) Parallel.For(0, 4, i => { AddCreature(new Creature()); });
        }

        public int GetPopulation()
        {
            return Creatures.Count;
        }

        public override string ToString()
        {
            return string.Format("{0} of {1}. Population: {2}. Deceased: {3}. Highest Generation: {4}",
                Classification,
                Name,
                Creatures.Count,
                Graveyard.Count,
                GetHighestGeneartion());
        }

        private string GetHighestGeneartion()
        {
            StringBuilder sb = new StringBuilder();
            List<Creature> cl = new List<Creature>();
            if (GetCreatures(out cl))
            {
                cl.Sort((x, y) => -1 * x.Generation.CompareTo(y.Generation));
                sb.Append(cl[0].Generation);
                switch (sb[sb.Length -1])
                {
                    case '1':
                        sb.Append("st");
                        break;
                    case '2':
                        sb.Append("nd");
                        break;
                    case '3':
                        sb.Append("rd");
                        break;
                    case '0':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        sb.Append("th");
                        break;
                }
            }
            else return "0";
            return sb.ToString();
        }

        
    }
}