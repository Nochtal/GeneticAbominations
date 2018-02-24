using System;
using System.Collections.Generic;
using System.Text;

namespace GeneticDLL
{
    /// <summary>
    /// Primary class object, Genes, is the foundation of the entire "game."
    /// </summary>
    public class Genes
    {
        #region FIELDS
        /// <summary>
        /// KEY String: Gene name
        /// VALUES List<double>: index 0: value of gene  (1 through 10)
        ///                      index 1: weight of gene (1 - dominate; 0 - recessive)
        ///                      index 2: aberration (0 - no abberation, -2 to 2)
        /// Alpha-Beta Compromise Formula:
        ///     Alpha[(Value + Aberration) * Weight)] + Beta[(Value + Aberration) * Weight]
        ///     Recesive genes will be overridden by dominate genes, two dominate genes will
        ///     compound each other.
        /// _alpha is Helix 1, or Alpha Helix
        /// _beta is Helix 2, or Beta Helix 
        /// </summary>
        
        /// <summary>
        /// Alpha Helix
        /// </summary>
        private Dictionary<string, List<double>> _alpha = new Dictionary<string, List<double>>();
        /// <summary>
        /// Beta Helix
        /// </summary>
        private Dictionary<string, List<double>> _beta = new Dictionary<string, List<double>>();
        /// <summary>
        /// Enforcement of Gene-Keys for randomly generated genetics.
        /// </summary>
        private string[] _geneKeys = new string[]
        {
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Height",
            "Eyes",
            "Arcane",
            "Divine"
        };
        #endregion FIELDS
        #region PROPERTIES
        /// <summary>
        /// Returns readout of entire genetic code.
        /// </summary>
        /// <returns>
        ///     Returns a large string, each gene-key will have its own section matching the following:
        ///     {Gene Key}: Alpha: Value #; Weight #; Aberration #.
        ///                 Beta: Value #; Weight #; Aberration #.
        ///                 Result: #.
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, List<double>> kvp in _alpha)
            {
                sb.Append(String.Format("{0}: \n\tAlpha: Value {1}; Weight {2}; Aberration {3}. \n\tBeta: Value {4}; Weight {5}; Aberration {6}. \n\tResult: Value {7}.\n",
                    kvp.Key.ToString(),
                    kvp.Value[0],
                    kvp.Value[1],
                    kvp.Value[2],
                    _beta[kvp.Key][0],
                    _beta[kvp.Key][1],
                    _beta[kvp.Key][2],
                    Result(kvp.Key)
                    ));
            }
            return sb.ToString();
        }
        /// <summary>
        /// Gets the result from the two helix for a specified gene
        /// </summary>
        /// <param name="key">string gene-key (i.e.: eyes, skin, height, etc.)</param>
        /// <returns>Returns a double resulting from the Alpha-Beta compromise formula.</returns>
        public double Result(string key)
        {
            if (_alpha[key][1] == 1 || _beta[key][1] == 1)
                return ((_alpha[key][0] * _alpha[key][1]) + (_beta[key][0]  * _beta[key][1]) + _alpha[key][2] + _beta[key][2]);
            else
            {
                if (_alpha[key][0] > _beta[key][0])
                {
                    return _alpha[key][0] + _alpha[key][2] + _beta[key][2];
                }
                else return _beta[key][0] + _beta[key][2] + _alpha[key][2];
            }
        }
        #endregion PROPERTIES
        #region CONSTRUCTORS
        /// <summary>
        /// Outright creation of Genes with full Helix dictionaries.
        /// Using no parameters will generate random genes for each gene-key.
        /// Inputing two dictionaries of genes will result in a new cell.
        /// </summary>
        /// <param name="alpha">Alpha Helix full data, intended for use with Zygot()</param>
        /// <param name="beta">Beta Helix full data, intended for use with Zygot()</param>
        public Genes()
        {
            _alpha = RandomGenes();
            _beta = RandomGenes();
            bool check = Enforcement();
        }
        public Genes(Dictionary<string, List<double>> alpha, Dictionary<string, List<double>> beta)
        {
            _alpha = alpha;
            _beta = beta;
            bool check = Enforcement();
        }
        public string[] GeneKeys { get { return _geneKeys; } private set { _geneKeys = value; } }
        #endregion CONSTRUCTORS
        #region METHODS
        /// <summary>
        /// Enforces each individual Gene, in both Alpha Helix and Beta Helix are within
        /// parameter limits for Value, Weight, and Aberration.
        /// The override of Enforcement with no parameters will run through all gene-keys.
        /// Should be accessible for testing purposes.
        /// </summary>
        /// <param name="gd">Send in a full Dictionary<string, List<double>> to be enforced.</param>
        /// <param name="key">string gene-key (i.e.: eyes, skin, height, etc.)</param>
        /// <returns>returns true if within limits, or enforces limits then returns true. Returns false on error.</returns>
        public bool Enforcement(Dictionary<string, List<double>> gd)
        {
            try
            {
                bool check = false;
                foreach (string key in _geneKeys)
                {
                    if ((gd[key][0] >= 1 && gd[key][0] <= 10) &&
                        (gd[key][1] == 0 || gd[key][1] == 1) &&
                        (gd[key][2] >= -2 && gd[key][2] <= 2)
                        ) check = true;
                    else // ENFORCE VALUES IN BOTH ALPHA HELIX AND BETA HELIX
                    {
                        // ENFORCE VALUE BETWEEN 1 THRU 10. Value is index 0
                        // Amount deviance outside limits put as aberration.
                        if (gd[key][0] < 1)
                        {
                            gd[key][2] = (gd[key][0]);
                            gd[key][0] = 1;
                        }
                        else if (gd[key][0] > 10)
                        {
                            gd[key][2] = (gd[key][0] - 10);
                            gd[key][0] = 10;
                        }
                        // ENFORCE WEIGHT 0 OR 1. Weight is index 1
                        if (gd[key][1] < 1)
                        {
                            gd[key][0] = 1;
                        }
                        else if (gd[key][1] > 1)
                        {
                            gd[key][1] = 1;
                        }
                        // ENFORCE ABERRATION -2 THRU 2. Aberration is index 2
                        if (gd[key][2] < -2)
                        {
                            gd[key][2] = -2;
                        }
                        else if (gd[key][2] > 2)
                        {
                            gd[key][2] = 2;
                        }
                        check = true;
                    }
                }
                return check;
            }
            catch
            {
                return false;
            }
        }
        public bool Enforcement(string key)
        {
            try
            {
                if ((_alpha[key][0] >= 1 && _alpha[key][0] <= 10) &&
                    (_alpha[key][1] == 0 || _alpha[key][1] == 1) &&
                    (_alpha[key][2] >= -2 && _alpha[key][2] <= 2) &&
                    (_beta[key][0] >= 1 && _beta[key][0] <= 10) &&
                    (_beta[key][1] == 0 || _beta[key][1] == 1) &&
                    (_beta[key][2] >= -2 && _beta[key][2] <= 2)
                    ) return true;
                else // ENFORCE VALUES IN BOTH ALPHA HELIX AND BETA HELIX
                {
                    // ENFORCE VALUE BETWEEN 1 THRU 10. Value is index 0
                    // Amount deviance outside limits put as aberration.
                    if (_alpha[key][0] < 1)
                    {
                        _alpha[key][2] = (_alpha[key][0]);
                        _alpha[key][0] = 1;
                    }
                    else if (_alpha[key][0] > 10)
                    {
                        _alpha[key][2] = (_alpha[key][0] - 10);
                        _alpha[key][0] = 10;
                    }
                    if (_beta[key][0] < 1)
                    {
                        _beta[key][2] = (_beta[key][0]);
                        _beta[key][0] = 1;
                    }
                    else if (_beta[key][0] > 10)
                    {
                        _beta[key][2] = _beta[key][0] - 10;
                        _beta[key][0] = 10;
                    }
                    // ENFORCE WEIGHT 0 OR 1. Weight is index 1
                    if (_alpha[key][1] < 1)
                    {
                        _alpha[key][0] = 1;
                    }
                    else if (_alpha[key][1] > 1)
                    {
                        _alpha[key][1] = 1;
                    }
                    if (_beta[key][1] < 1)
                    {
                        _beta[key][1] = 0;
                    }
                    else if (_beta[key][1] > 1)
                    {
                        _beta[key][1] = 1;
                    }
                    // ENFORCE ABERRATION -2 THRU 2. Aberration is index 2
                    if (_alpha[key][2] < -2)
                    {
                        _alpha[key][2] = -2;
                    }
                    else if (_alpha[key][2] > 2)
                    {
                        _alpha[key][2] = 2;
                    }
                    if (_beta[key][2] < -2)
                    {
                        _beta[key][2] = -2;
                    }
                    else if (_beta[key][2] > 2)
                    {
                        _beta[key][2] = 2;
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool Enforcement()
        {
            bool check = false;
            foreach (KeyValuePair<string, List<double>> kvp in _alpha)
            {
                check = Enforcement(kvp.Key);
            }
            return check;
        }
        /// <summary>
        /// Generates random genes based on the master list of gene-keys based on
        /// _geneKeys array. Only generates one, so must be called for both Alpha
        /// and Beta if both neeed to be randomly generated. Should not be callable
        /// outside of Genes class.
        /// </summary>
        /// <returns>Returns a full Dictionary<string, List<double>) of genes</returns>
        private Dictionary<string, List<double>> RandomGenes()
        {
            Random roll = new Random(Guid.NewGuid().GetHashCode());
            Dictionary<string, List<double>> temp = new Dictionary<string, List<double>>();
            foreach (string gk in _geneKeys)
            {
                temp.Add(gk, new List<double> { roll.Next(1, 11), roll.Next(0, 2), roll.Next(-2, 3) });
            }
            return temp;
        }
        /// <summary>
        /// Generates a new set of genes, randomly selecting from Alpha or Beta for 
        /// each gene-key.
        /// </summary>
        /// <returns>returning one set of genes to be combined with into a new Genes Object</returns>
        public Dictionary<string, List<double>> Zygot()
        {
            Dictionary<string, List<double>> temp = new Dictionary<string, List<double>>();
            foreach(string gk in _geneKeys)
            {
                Random roll = new Random(Guid.NewGuid().GetHashCode());
                if (roll.Next(1, 101) < 51)
                {
                    temp.Add(gk, new List<double> { _alpha[gk][0] + _alpha[gk][2], _alpha[gk][1], Mutation(gk) });
                }
                else
                {
                    temp.Add(gk, new List<double> { _beta[gk][0] + _beta[gk][2], _beta[gk][1], Mutation(gk) });
                }
            }
            Enforcement(temp);
            return temp;
        }
        /// <summary>
        /// Random 10% chance for mutation to happen.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private double Mutation(string key)
        {
            Random roll = new Random(Guid.NewGuid().GetHashCode());
            if (roll.Next(1, 101) < 6)
            {
                return roll.Next(-2, 3);
            }
            else return 0;
        }
        #endregion METHODS
    }
}