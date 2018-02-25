using System.Collections.Generic;

namespace GeneticDLL
{
    public class Population
    {
        #region FIELDS
        private List<Creature> _creatures;
        #endregion FIELDS
        #region PROPERITES
        public List<Creature> Populace { get { return _creatures; } private set { _creatures = value; } }
        //public string[] GeneKeys { get { return _creatures[0].GeneKeys; } }
        public int Count { get { return _creatures.Count; } }
        #endregion PROPERTIES
        #region CONSTRUCTORS
        /// <summary>
        /// Construct with no params initiates with four randomly
        /// generated creatures in Population. Or may construct
        /// with a pre-generated Population List<t>.
        /// </summary>
        public Population()
        {
            _creatures = new List<Creature>();
            //_creatures.Add(new Creature());
            //_creatures.Add(new Creature());
            //_creatures.Add(new Creature());
            //_creatures.Add(new Creature());
            foreach (Creature c in _creatures)
            {
                c.Age = 25;
            }
        }
        public Population(List<Creature> creatures)
        {
            _creatures = creatures;
        }
        #endregion CONSTRUCTORS
        #region METHODS
        /// <summary>
        /// Add creature to population List<t>
        /// this.Add(Populace[i].Mate(Populace[i]));
        /// </summary>
        /// <param name="nc">Creature to be added</param>
        //public void Add(Creature nc)
        //{
        //    /// Make thread safe.
        //    foreach (Creature c in _creatures)
        //    {
        //        c.AdvanceAge();
        //    }
        //    for (int i = 0; i < _creatures.Count; i++)
        //    {
        //        if (_creatures[i].Age > _creatures[i].MaxAge() + 1) _creatures.Remove(_creatures[i]);
        //    }
        //    _creatures.Add(nc);
        //}
        /// <summary>
        /// Sort Population by generation, descending.
        /// </summary>
        //public void SortByGeneration()
        //{
        //    _creatures.Sort((x, y) => -1 * x.Generation.CompareTo(y.Generation));
        //}
        /// <summary>
        /// Sort Population by name, alphabetically.
        /// </summary>
        public void SortByName()
        {
            _creatures.Sort((x, y) => x.Name.CompareTo(y.Name));
        }
        /// <summary>
        /// Sort Population by specified Gene Value, descending.
        /// </summary>
        /// <param name="geneKey">Gene-Key value to sort by</param>
        //public void SortByGene(string geneKey)
        //{
        //    _creatures.Sort((x, y) => -1 * x.GeneSequence.Result(geneKey).CompareTo(y.GeneSequence.Result(geneKey)));
        //}
        /// <summary>
        /// Sort by Aberration Index, absolute value of total
        /// aberrations within creature, descending.
        /// </summary>
        //public void SortByAberration()
        //{
        //    _creatures.Sort((x, y) => -1 * x.AberrationIndex().CompareTo(y.AberrationIndex()));
        //}
        #endregion METHODS
    }
}