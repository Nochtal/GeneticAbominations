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
            Genes g = new Genes();
            Assert.IsTrue(g.Enforcement());
        }

        [TestMethod]
        public void GenerateZygot()
        {
            Genes g = new Genes();
            Assert.IsTrue(g.Enforcement(g.Zygot()));
        }

        [TestMethod]
        public void Reproduce()
        {
            Genes male = new Genes();
            Genes female = new Genes();
            Genes offspring = new Genes(male.Zygot(), female.Zygot());
            Assert.IsTrue(offspring.Enforcement());
        }
    }
}
