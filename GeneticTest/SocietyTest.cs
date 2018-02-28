using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeneticDLL;
using System.Collections.Generic;
using System;

namespace GeneticTest
{
    [TestClass]
    public class SocietyTest
    {
        [TestMethod]
        public void GenerateRandomSociety()
        {
            Society society = new Society();
            Assert.IsNotNull(society.Name);
            CollectionAssert.Contains(ExtensionMethods.SocietyType, society.Classification);
            Assert.AreEqual(4, society.Creatures.Count);
        }

        [TestMethod]
        public void GeneratePseudoRandomSociety()
        {
            Creature cOne = new Creature();
            Creature cTWo = new Creature();
            Creature cThree = new Creature();
            Creature cFour = new Creature();
            Creature cFive = new Creature();
            Society society = new Society(cOne, cTWo, cThree, cFour, cFive);
            Assert.IsNotNull(society.Name);
            CollectionAssert.Contains(ExtensionMethods.SocietyType, society.Classification);
            Assert.AreEqual(5, society.Creatures.Count);
        }

        [TestMethod]
        public void GenerateSpecifiedSociety()
        {
            Creature cOne = new Creature();
            Creature cTWo = new Creature();
            Creature cThree = new Creature();
            Creature cFour = new Creature();
            Creature cFive = new Creature();
            string NAME = "Balzeria";
            string CLASSIFICATION = "Republic";
            List<Creature> CREATURES = new List<Creature>() { cOne, cTWo, cThree, cFour, cFive };
            Society society = new Society(NAME, CLASSIFICATION, CREATURES);
            Assert.AreEqual(NAME, society.Name);
            Assert.AreEqual(CLASSIFICATION, society.Classification);
            Assert.AreEqual(5, society.Creatures.Count);
        }

        [TestMethod]
        public void TestGetCreatures()
        {
            Creature cOne = new Creature();
            Creature cTWo = new Creature();
            Creature cThree = new Creature();
            Creature cFour = new Creature();
            Creature cFive = new Creature();
            string NAME = "Balzeria";
            string CLASSIFICATION = "Republic";
            List<Creature> CREATURES = new List<Creature>() { cOne, cTWo, cThree, cFour, cFive };
            Society society = new Society(NAME, CLASSIFICATION, CREATURES);
            List<Creature> creaturesList = new List<Creature>();
            Assert.IsTrue(society.GetCreatures(out creaturesList));
            CollectionAssert.Contains(creaturesList, cOne);
            CollectionAssert.Contains(creaturesList, cTWo);
            CollectionAssert.Contains(creaturesList, cThree);
            CollectionAssert.Contains(creaturesList, cFour);
            CollectionAssert.Contains(creaturesList, cFive);
        }


        [TestMethod]
        public void TestRemoveCreature()
        {
            Creature cOne = new Creature();
            Creature cTWo = new Creature();
            Creature cThree = new Creature();
            Creature cFour = new Creature();
            Creature cFive = new Creature();
            string NAME = "Balzeria";
            string CLASSIFICATION = "Republic";      // index    0,    1,      2,     3,     4
            List<Creature> CREATURES = new List<Creature>() { cOne, cTWo, cThree, cFour, cFive };
            Society society = new Society(NAME, CLASSIFICATION, CREATURES);
            List<Creature> creaturesList = new List<Creature>();
            Assert.IsTrue(society.GetCreatures(out creaturesList));
            Assert.IsTrue(society.RemoveCreature(cTWo));
            Assert.IsTrue(society.GetCreatures(out creaturesList));
            CollectionAssert.Contains(creaturesList, cOne);
            CollectionAssert.DoesNotContain(creaturesList, cTWo);
            CollectionAssert.Contains(creaturesList, cThree);
            CollectionAssert.Contains(creaturesList, cFour);
            CollectionAssert.Contains(creaturesList, cFive);
        }

        [TestMethod]
        public void TestUpdateCreature()
        {
            Creature cOne = new Creature();
            Creature cTWo = new Creature();
            string NAME = "Balzeria";
            string CLASSIFICATION = "Republic";
            List<Creature> CREATURES = new List<Creature>() { cOne, cTWo };
            Society society = new Society(NAME, CLASSIFICATION, CREATURES);
            int cTwoAlphaRaceValue = cTWo.Genetics.Alpha.Race.Value;
            int VARIATION = ExtensionMethods.GetRandom(1, 5);
            cTWo.Genetics.Alpha.Race.Value  += VARIATION;
            Assert.IsTrue(society.UpdateCreature(cTWo));
            Creature cTwoChangeCheck;
            Assert.IsTrue(society.GetCreatures(cTWo, out cTwoChangeCheck));
            Assert.AreNotEqual(cTwoAlphaRaceValue, cTwoChangeCheck.Genetics.Alpha.Race.Value);
            Assert.AreEqual(cTwoAlphaRaceValue + VARIATION, cTwoChangeCheck.Genetics.Alpha.Race.Value);
        }
        
        [TestMethod]
        public void TestAdvanceAgeDeathAndGraveyard()
        {
            Creature cOne = new Creature();
            Creature cTWo = new Creature();
            Creature cThree = new Creature();
            Creature cFour = new Creature();
            Creature cFive = new Creature();
            string NAME = "Balzeria";
            string CLASSIFICATION = "Republic";      // index    0,    1,      2,     3,     4
            List<Creature> CREATURES = new List<Creature>() { cOne, cTWo, cThree, cFour, cFive };
            Society society = new Society(NAME, CLASSIFICATION, CREATURES);
            List<Creature> creaturesList = new List<Creature>();
            society.AdvanceAge(650);
            List<string> graveyard = new List<string>();
            Assert.IsTrue(society.GetGraveyard(out graveyard));
            Assert.IsTrue(society.GetCreatures(out creaturesList));
            /// If all creatures in the society die, 4 new random creatures should be populated
            Assert.AreEqual(4, creaturesList.Count);
            Assert.AreEqual(5, graveyard.Count);
            string DeathStringConfirmation = String.Format("{0}, Died at {1} years of age. Generation: {2}. Parents: {3} and {4}",
                cOne.Name,
                cOne.GetMaxAge(),
                cOne.Generation,
                cOne.ParentOne,
                cOne.ParentTwo);
            CollectionAssert.Contains(graveyard, DeathStringConfirmation);
        }
    }
}
