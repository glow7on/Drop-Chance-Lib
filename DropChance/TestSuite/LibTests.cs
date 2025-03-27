using DropChance;

namespace TestSuite
{
    [TestClass]
    public class LibTests
    {
        [TestMethod]
        public void GetRandomFromDictionary_StandartDictionary_ReturnsRandomKey()
        {
            string firstKey = "";
            Dictionary<string, int> firstDictionary = new Dictionary<string, int>()
            {
                { "First", 10 },
                { "Second", 30 },
                { "Third", 60 }
            };

            Assert.IsInstanceOfType(firstKey, DropChance<string>.GetRandomFromDictionary(firstDictionary, 100).GetType());
        }
    }
}
