using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeneticDLL;
using System.Diagnostics;

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
            Gene race = new Gene(1, 1, 1);
            Gene strength = new Gene(1, 1, 1);
            Gene dexterity = new Gene(1, 1, 1);
            Gene constitution = new Gene(1, 1, 1);
            Gene intelligence = new Gene(1, 1, 1);
            Gene wisdom = new Gene(1, 1, 1);
            Gene charisma = new Gene(1, 1, 1);
            Gene arcane = new Gene(1, 1, 1);
            Gene divine = new Gene(1, 1, 1);
            Helix helix = new Helix(race, strength, dexterity, constitution, intelligence, wisdom, charisma, arcane, divine);
            Assert.AreEqual(1, helix.Race.Value);
            Assert.AreEqual(1, helix.Race.Weight);
            Assert.AreEqual(1, helix.Race.Deviation);

            Assert.AreEqual(1, helix.Strength.Value);
            Assert.AreEqual(1, helix.Strength.Weight);
            Assert.AreEqual(1, helix.Strength.Deviation);

            Assert.AreEqual(1, helix.Dexterity.Value);
            Assert.AreEqual(1, helix.Dexterity.Weight);
            Assert.AreEqual(1, helix.Dexterity.Deviation);

            Assert.AreEqual(1, helix.Constitution.Value);
            Assert.AreEqual(1, helix.Constitution.Weight);
            Assert.AreEqual(1, helix.Constitution.Deviation);

            Assert.AreEqual(1, helix.Intelligence.Value);
            Assert.AreEqual(1, helix.Intelligence.Weight);
            Assert.AreEqual(1, helix.Intelligence.Deviation);

            Assert.AreEqual(1, helix.Charisma.Value);
            Assert.AreEqual(1, helix.Charisma.Weight);
            Assert.AreEqual(1, helix.Charisma.Deviation);

            Assert.AreEqual(1, helix.Wisdom.Value);
            Assert.AreEqual(1, helix.Wisdom.Weight);
            Assert.AreEqual(1, helix.Wisdom.Deviation);

            Assert.AreEqual(1, helix.Arcane.Value);
            Assert.AreEqual(1, helix.Arcane.Weight);
            Assert.AreEqual(1, helix.Arcane.Deviation);

            Assert.AreEqual(1, helix.Divine.Value);
            Assert.AreEqual(1, helix.Divine.Weight);
            Assert.AreEqual(1, helix.Divine.Deviation);
        }

        [TestMethod]
        public void HelixToString()
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
            Helix helix = new Helix(race, strength, dexterity, constitution, intelligence, wisdom, charisma, arcane, divine);
            string check = "Race: Value 1, Weight 1, Aberration 1.\nStrength: Value 1, Weight 1, Aberration 1.\nDexterity: Value 1, Weight 1, Aberration 1.\nConstitution: Value 1, Weight 1, Aberration 1.\nIntelligence: Value 1, Weight 1, Aberration 1.\nCharisma: Value 1, Weight 1, Aberration 1.\nWisdom: Value 1, Weight 1, Aberration 1.\nArcane: Value 1, Weight 1, Aberration 1.\nDivine: Value 1, Weight 1, Aberration 1.";
            Debug.WriteLine("Helix => " + helix.ToString());
            Debug.WriteLine("Check => " + check);
            Assert.AreEqual(check, helix.ToString());
            /// Surprisingly, this test actually found the missing Charisma.ToString() argument for the Helix.ToString() arguments.
        }
    }
}