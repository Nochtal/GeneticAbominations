using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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