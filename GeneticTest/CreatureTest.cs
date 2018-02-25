using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeneticDLL;

namespace GeneticTest
{
    [TestClass]
    public class CreatureTest
    {
        [TestMethod]
        public void GenerateCreature()
        {
            Creature creature = new Creature();
            Assert.IsNotNull(creature);
            Assert.AreEqual(creature.Generation, 1);
        }

        [TestMethod]
        public void Reproduction()
        {
            Creature pOne = new Creature();
            Creature pTwo = new Creature();
            Creature Gen2_One = new Creature(pOne, pTwo);
            Assert.AreEqual(2, Gen2_One.Generation);
            Creature Gen2_Two = new Creature(pOne, pTwo);
            Creature Gen3_One = new Creature(Gen2_One, Gen2_Two);
            Assert.AreEqual(3, Gen3_One.Generation);
            Creature Gen2_Three = new Creature(pOne, Gen2_One);
            Assert.AreEqual(2, Gen2_Three.Generation);
        }
    }
}
