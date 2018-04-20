using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeneticDLL;

namespace GeneticTest
{
    [TestClass]
    public class CreatureTest
    {
        [TestMethod]
        public void GenerateRandomCreature()
        {
            Creature creature = new Creature();
            Assert.IsNotNull(creature);
            Assert.AreEqual(1, creature.Generation);
            Assert.AreEqual("Underlord Ada", creature.ParentOne);
            Assert.AreEqual("Mysterious B", creature.ParentTwo);
            Assert.IsNotNull(creature.Genetics.Alpha);
            Assert.IsNotNull(creature.Genetics.Beta);
        }

        [TestMethod]
        public void GenerateOffspringCreature()
        {
            Creature parentOne = new Creature();
            Creature parentTwo = new Creature();
            Creature offspring = new Creature(parentOne, parentTwo);
            Assert.IsNotNull(offspring);
            Assert.AreEqual(parentOne.Name, offspring.ParentOne);
            Assert.AreEqual(parentTwo.Name, offspring.ParentTwo);
            Assert.AreEqual(2, offspring.Generation);
            Assert.AreEqual(0, offspring.Age);
        }

        [TestMethod]
        public void GenerateSpecificCreature()
        {
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
            string NAME = "Mysterious B";
            string pONE = "Noch";
            string pTWO = "Dennis";
            string RACE = "Dwarf";
            int GENERATION = 2;
            int AGE = 10;
            int MAXAGE = 110; // Constitution * Race + Divine + 50 => 10 * 4 + 20 + 50 = 110
            Creature creature = new Creature(
                GENERATION,
                pONE,
                pTWO,
                dna,
                NAME,
                AGE);
            Assert.AreEqual(pONE, creature.ParentOne);
            Assert.AreEqual(pTWO, creature.ParentTwo);
            Assert.AreEqual(dna, creature.Genetics);
            Assert.AreEqual(RACE, creature.GetRace());
            Assert.AreEqual(GENERATION, creature.Generation);
            Assert.AreEqual(AGE, creature.Age);
            Assert.AreEqual(MAXAGE, creature.GetMaxAge());
        }
    }
}
