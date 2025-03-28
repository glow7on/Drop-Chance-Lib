using DropChance;
using System.Collections.Specialized;

namespace TestSuite
{
    [TestClass]
    public class LibTests
    {
        [TestMethod]
        public void GetRandomFromDictionary_StandartDictionary_ReturnsRandomKey()
        {
            string firstTestKey = "";
            Dictionary<string, int> firstDictionary = new Dictionary<string, int>()
            {
                { "First", 10 },
                { "Second", 30 },
                { "Third", 60 }
            };
            Assert.IsInstanceOfType(firstTestKey, DropChance<string>.GetRandomFromDictionary(firstDictionary, 100).GetType());

            Object secondTestKey = new object();
            Dictionary<object, int> secondDictionary = new Dictionary<object, int>()
            {
                { new object(), 10 },
                { new object(), 30 },
                { new object(), 60 },
            };
            Assert.IsInstanceOfType(secondTestKey, DropChance<object>.GetRandomFromDictionary(secondDictionary, 100).GetType());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetRandomFromDictionary_NullInput_ThrowsArgumentException()
        {
            DropChance<object>.GetRandomFromDictionary(null, new int());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetRandomFromDictionary_EmpptyDictionary_ThrowsArgumentException()
        {
            DropChance<object>.GetRandomFromDictionary(new Dictionary<object, int>(), new int());
        }


        [TestMethod]
        public void GetRangeOfRandom_StandartDictionary_ReturnsCorrectRange()
        {
            Dictionary<string, int> firstDictionary = new Dictionary<string, int>()
            {
                { "First", 10 },
                { "Second", 30 },
                { "Third", 60 }
            };
            Assert.AreEqual(100, DropChance<string>.GetRangeOfRandom(firstDictionary));

            Dictionary<object, int> secondDictionary = new Dictionary<object, int>()
            {
                { new object(), 50 },
                { new object(), 50 },
                { new object(), 40 },
            };
            Assert.AreEqual(140, DropChance<object>.GetRangeOfRandom(secondDictionary));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetRangeOfRandom_NullInput_ThrowsArgumentException()
        {
            DropChance<object>.GetRangeOfRandom(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetRangeOfRandom_EmpptyDictionary_ThrowsArgumentException()
        {
            DropChance<object>.GetRangeOfRandom(new Dictionary<object, int>());
        }
    }
}
