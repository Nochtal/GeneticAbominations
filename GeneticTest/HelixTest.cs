using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeneticDLL;

namespace GeneticTest
{
    [TestClass]
    public class HelixTest
    {
        [TestMethod]
        public void InstantiateRandomHelix()
        {
            Helix helix = new Helix();
            Assert.AreNotEqual(null, helix.Race.Value);
            Assert.AreNotEqual(null, helix.Race.Weight);
            Assert.AreNotEqual(null, helix.Race.Deviation);
            Assert.AreNotEqual(null, helix.Strength.Value);
            Assert.AreNotEqual(null, helix.Strength.Weight);
            Assert.AreNotEqual(null, helix.Strength.Deviation);
            Assert.AreNotEqual(null, helix.Dexterity.Value);
            Assert.AreNotEqual(null, helix.Dexterity.Weight);
            Assert.AreNotEqual(null, helix.Dexterity.Deviation);
            Assert.AreNotEqual(null, helix.Constitution.Value);
            Assert.AreNotEqual(null, helix.Constitution.Weight);
            Assert.AreNotEqual(null, helix.Constitution.Deviation);
            Assert.AreNotEqual(null, helix.Intelligence.Value);
            Assert.AreNotEqual(null, helix.Intelligence.Weight);
            Assert.AreNotEqual(null, helix.Intelligence.Deviation);
            Assert.AreNotEqual(null, helix.Charisma.Value);
            Assert.AreNotEqual(null, helix.Charisma.Weight);
            Assert.AreNotEqual(null, helix.Charisma.Deviation);
            Assert.AreNotEqual(null, helix.Wisdom.Value);
            Assert.AreNotEqual(null, helix.Wisdom.Weight);
            Assert.AreNotEqual(null, helix.Wisdom.Deviation);
            Assert.AreNotEqual(null, helix.Arcane.Value);
            Assert.AreNotEqual(null, helix.Arcane.Weight);
            Assert.AreNotEqual(null, helix.Arcane.Deviation);
            Assert.AreNotEqual(null, helix.Divine.Value);
            Assert.AreNotEqual(null, helix.Divine.Weight);
            Assert.AreNotEqual(null, helix.Divine.Deviation);
        }

        [TestMethod]
        public void InstantiateSpecificHelix()
        {
            Gene race = new Gene(1, 2, 3);
            Gene strength = new Gene(2, 3, 4);
            Gene dexterity = new Gene(3, 4, 5);
            Gene constitution = new Gene(4, 5, 6);
            Gene intelligence = new Gene(5, 6, 7);
            Gene wisdom = new Gene(6, 7, 8);
            Gene charisma = new Gene(7, 8, 9);
            Gene arcane = new Gene(8, 9, 10);
            Gene divine = new Gene(9, 10, 11);
            Helix helix = new Helix(race, strength, dexterity, constitution, intelligence, wisdom, charisma, arcane, divine);
            Assert.AreEqual(1, helix.Race.Value);
            Assert.AreEqual(2, helix.Race.Weight);
            Assert.AreEqual(3, helix.Race.Deviation);

            Assert.AreEqual(2, helix.Strength.Value);
            Assert.AreEqual(3, helix.Strength.Weight);
            Assert.AreEqual(4, helix.Strength.Deviation);

            Assert.AreEqual(3, helix.Dexterity.Value);
            Assert.AreEqual(4, helix.Dexterity.Weight);
            Assert.AreEqual(5, helix.Dexterity.Deviation);

            Assert.AreEqual(4, helix.Constitution.Value);
            Assert.AreEqual(5, helix.Constitution.Weight);
            Assert.AreEqual(6, helix.Constitution.Deviation);

            Assert.AreEqual(5, helix.Intelligence.Value);
            Assert.AreEqual(6, helix.Intelligence.Weight);
            Assert.AreEqual(7, helix.Intelligence.Deviation);

            Assert.AreEqual(6, helix.Wisdom.Value);
            Assert.AreEqual(7, helix.Wisdom.Weight);
            Assert.AreEqual(8, helix.Wisdom.Deviation);

            Assert.AreEqual(7, helix.Charisma.Value);
            Assert.AreEqual(8, helix.Charisma.Weight);
            Assert.AreEqual(9, helix.Charisma.Deviation);

            Assert.AreEqual(8, helix.Arcane.Value);
            Assert.AreEqual(9, helix.Arcane.Weight);
            Assert.AreEqual(10, helix.Arcane.Deviation);

            Assert.AreEqual(9, helix.Divine.Value);
            Assert.AreEqual(10, helix.Divine.Weight);
            Assert.AreEqual(11, helix.Divine.Deviation);
        }

        [TestMethod]
        public void HelixToString()
        {
            Gene race = new Gene(1, 1, 1);
            Gene strength = new Gene(2, 1, 1);
            Gene dexterity = new Gene(3, 1, 1);
            Gene constitution = new Gene(4, 1, 1);
            Gene intelligence = new Gene(5, 1, 1);
            Gene wisdom = new Gene(6, 1, 1);
            Gene charisma = new Gene(7, 1, 1);
            Gene arcane = new Gene(8, 1, 1);
            Gene divine = new Gene(9, 1, 1);
            Helix helix = new Helix(race, strength, dexterity, constitution, intelligence, wisdom, charisma, arcane, divine);
            string check = "Race: Value 1, Weight 1, Deviation 1.\nStrength: Value 2, Weight 1, Deviation 1.\nDexterity: Value 3, Weight 1, Deviation 1.\nConstitution: Value 4, Weight 1, Deviation 1.\nIntelligence: Value 5, Weight 1, Deviation 1.\nWisdom: Value 6, Weight 1, Deviation 1.\nCharisma: Value 7, Weight 1, Deviation 1.\nArcane: Value 8, Weight 1, Deviation 1.\nDivine: Value 9, Weight 1, Deviation 1.\nDeviation Index: 9";
            Assert.AreEqual(check, helix.ToString());
        }
    }
}