using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeneticDLL;

namespace GeneticTest
{
    [TestClass]
    public class GeneTest
    {
        [TestMethod]
        public void GeneInstantiation()
        {
            Gene gene = new Gene();
            Assert.IsTrue(gene.Value >= 1 && gene.Value <= 10);
            Assert.IsTrue(gene.Weight >= 0 && gene.Weight <= 1);
            Assert.IsTrue(gene.Deviation >= -2 && gene.Deviation <= 2);
        }

        [TestMethod]
        public void GeneMutation()
        {
            Gene gene = new Gene(10, 1, 3);
            Gene check = new Gene(10, 1, 3);
            gene.Deviation = gene.Mutate();
            Assert.AreNotEqual(check.Deviation, gene.Deviation);
        }

        [TestMethod]
        public void GeneToString()
        {
            Gene gene = new Gene(10, 1, 2);
            Assert.AreEqual("Value 10. Weight 1. Aberration 2.", gene.ToString());
        }
    }
}
