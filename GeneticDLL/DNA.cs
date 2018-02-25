using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticDLL
{
    public class DNA
    {
        public Helix Alpha { get; set; }
        public Helix Beta { get; set; }

        public DNA(Helix alpha, Helix beta)
        {
            Alpha = alpha;
            Beta = beta;
        }
    }
}
