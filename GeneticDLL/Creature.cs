using System.Collections.Generic;

namespace GeneticDLL
{
    public class Creature
    {
        #region FIELDS
        private string _name;
        private Genes _genes;
        private int _generation;
        #endregion FIELDS
        #region PROPERTIES
        public string Name { get { return _name; } private set { _name = value; } }
        public object Genetics { get { return _genes.ToString(); } private set { _genes = (Genes)value; } }
        public Genes GeneSequence { get { return _genes; } }
        public Dictionary<string, List<double>> Zygot { get { return _genes.Zygot(); } }
        public int Generation { get { return _generation; } private set { _generation = value; } }
        public string[] GeneKeys { get { return _genes.GeneKeys; } }
        #endregion PROPERITES
        #region CONSTRUCTORS
        /// <summary>
        /// Creature Consturctors: 
        /// No parameters: new creatures starting at generation 1.
        /// Two parent creatures: produces Zygots to create new genetics.
        /// Private constructor with Partner for self contained birthing (?... ok... whatever that means...)
        /// </summary>
        /// <param name="parentOne">First parent to donate genes</param>
        /// <param name="parentOne">Second parent to donate genes</param>
        public Creature()
        {
            _name = Utility.Name();
            _generation = 1;
            _genes = new Genes();
        }
        public Creature(Creature parentOne, Creature parentTwo)
        {
            _name = Utility.Name();
            if (parentOne.Generation < parentTwo.Generation) _generation = parentOne.Generation + 1;
            else _generation = parentTwo.Generation + 1;
            _genes = new Genes(parentOne.Zygot, parentTwo.Zygot);
        }
        private Creature(Creature parentTwo)
        {
            _name = Utility.Name();
            if (this.Generation < parentTwo.Generation) _generation = this.Generation + 1;
            else _generation = parentTwo.Generation + 1;
            _genes = new Genes(this.Zygot, parentTwo.Zygot);
        }
        #endregion CONSTRUCTORS
        #region METHODS
        public override string ToString()
        {
            return string.Format("{0}\nGeneration: {1}\n\n{2}", Name, Generation, _genes.ToString());
        }
        /// <summary>
        /// Calls private Constructor, referencing self and mate.
        /// Currently not used...
        /// </summary>
        /// <param name="partner">Creature to mate with</param>
        /// <returns>returns offspring creature</returns>
        public Creature Mate(Creature partner)
        {
            return new Creature(partner);
        }
        #endregion METHODS
    }
}