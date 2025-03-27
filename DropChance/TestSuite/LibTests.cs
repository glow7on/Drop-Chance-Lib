using DropChance;

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
    }
}
