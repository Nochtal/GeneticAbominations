using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeneticDLL;

namespace GeneticTest
{
    [TestClass]
    public class DNATest
    {
        [TestMethod]
        public void InstantiateRandomDNA()
        {
            DNA dna = new DNA();
            Assert.IsNotNull(dna);
            Assert.IsNotNull(dna.Alpha);
            Assert.IsNotNull(dna.Alpha.Race);
            Assert.IsNotNull(dna.Alpha.Strength);
            Assert.IsNotNull(dna.Alpha.Dexterity);
            Assert.IsNotNull(dna.Alpha.Constitution);
            Assert.IsNotNull(dna.Alpha.Intelligence);
            Assert.IsNotNull(dna.Alpha.Wisdom);
            Assert.IsNotNull(dna.Alpha.Charisma);
            Assert.IsNotNull(dna.Alpha.Arcane);
            Assert.IsNotNull(dna.Alpha.Divine);
            Assert.IsNotNull(dna.Beta);
            Assert.IsNotNull(dna.Beta);
            Assert.IsNotNull(dna.Beta.Race);
            Assert.IsNotNull(dna.Beta.Strength);
            Assert.IsNotNull(dna.Beta.Dexterity);
            Assert.IsNotNull(dna.Beta.Constitution);
            Assert.IsNotNull(dna.Beta.Intelligence);
            Assert.IsNotNull(dna.Beta.Wisdom);
            Assert.IsNotNull(dna.Beta.Charisma);
            Assert.IsNotNull(dna.Beta.Arcane);
            Assert.IsNotNull(dna.Beta.Divine);
        }

        [TestMethod]
        public void InstatiateSpecifedDNA()
        {
            Gene race = new Gene(1, 1, 1);
            Gene strength = new Gene(1, 1, 1);
            Gene dexterity = new Gene(1, 1, 1);
            Gene constitution = new Gene(1, 1, 1);
            Gene intelligence = new Gene(1, 1, 1);
            Gene wisdom = new Gene(1, 1, 1);
            Gene charisma = new Gene(1, 1, 1);
            Gene arcane = new Gene(1, 1, 1);
            Gene divine = new Gene(1, 1, 1);
            Helix alpha = new Helix(race, strength, dexterity, constitution, intelligence, wisdom, charisma, arcane, divine);
            Helix beta = new Helix(race, strength, dexterity, constitution, intelligence, wisdom, charisma, arcane, divine);
            DNA dna = new DNA(alpha, beta);
            Assert.AreSame(race, dna.Alpha.Race);
            Assert.AreSame(race, dna.Beta.Race);
            Assert.AreSame(strength, dna.Alpha.Strength);
            Assert.AreSame(strength, dna.Beta.Strength);
            Assert.AreSame(dexterity, dna.Alpha.Dexterity);
            Assert.AreSame(dexterity, dna.Beta.Dexterity);
            Assert.AreSame(constitution, dna.Alpha.Constitution);
            Assert.AreSame(constitution, dna.Beta.Constitution);
            Assert.AreSame(intelligence, dna.Alpha.Intelligence);
            Assert.AreSame(intelligence, dna.Beta.Intelligence);
            Assert.AreSame(wisdom, dna.Alpha.Wisdom);
            Assert.AreSame(wisdom, dna.Beta.Wisdom);
            Assert.AreSame(charisma, dna.Alpha.Charisma);
            Assert.AreSame(charisma, dna.Beta.Charisma);
            Assert.AreSame(arcane, dna.Alpha.Arcane);
            Assert.AreSame(arcane, dna.Beta.Arcane);
            Assert.AreSame(divine, dna.Alpha.Divine);
            Assert.AreSame(divine, dna.Beta.Divine);
        }

        [TestMethod]
        public void TestGeneResultCalculation()
        {
            // Result should be (Value * 2 + 2)
            // Gene(Value, Weight, Deviation)
            Gene race = new Gene(1, 1, 1); // 4
            Gene strength = new Gene(2, 1, 1); // 6
            Gene dexterity = new Gene(3, 1, 1); // 8
            Gene constitution = new Gene(4, 1, 1); // 10
            Gene intelligence = new Gene(5, 1, 1); // 12
            Gene wisdom = new Gene(6, 1, 1); // 14
            Gene charisma = new Gene(7, 1, 1); // 16
            Gene arcane = new Gene(8, 1, 1); // 18
            Gene divine = new Gene(9, 1, 1); // 20
            Helix alpha = new Helix(race, strength, dexterity, constitution, intelligence, wisdom, charisma, arcane, divine);
            Helix beta = new Helix(race, strength, dexterity, constitution, intelligence, wisdom, charisma, arcane, divine);
            DNA dna = new DNA(alpha, beta);
            Assert.AreEqual(4, dna.Race);
            Assert.AreEqual(6, dna.Strength);
            Assert.AreEqual(8, dna.Dexterity);
            Assert.AreEqual(10, dna.Constitution);
            Assert.AreEqual(12, dna.Intelligence);
            Assert.AreEqual(14, dna.Wisdom);
            Assert.AreEqual(16, dna.Charisma);
            Assert.AreEqual(18, dna.Arcane);
            Assert.AreEqual(20, dna.Divine);
        }

        [TestMethod]
        public void ZygotGenerationTest()
        {
            DNA dna = new DNA();
            Helix zygot = null;
            Assert.IsTrue(dna.GenerateZygot(out zygot));
            Assert.IsNotNull(zygot);
        }
    }
}
