using System;
using System.Collections.Generic;
using System.Linq;

namespace DropChance
{
    public static class DropChance<Key>
    {
        private static Random random = new Random();
        public static Key GetRandomFromDictionary(Dictionary<Key, int> dictionary, int keySumm)
        {
            int randomNumber = random.Next(0, keySumm);
            int elementSum = 0;
            int index;

            for (index = 0; index < dictionary.Count; index++)
            {
                elementSum += dictionary.ElementAt(index).Value;

                if (elementSum > randomNumber)
                {
                    break;
                }

            }

            return dictionary.ElementAt(index).Key;
        }

        public static int GetRangeOfRandom(Dictionary<Key, int> dictionary)
        {
            int range = 0;

            for (int i = 0; i < dictionary.Count; i++)
            {
                if (dictionary.ElementAt(i).Value < 0)
                {
                    throw new ArgumentException("The chance of falling out cannot be a negative number", nameof(dictionary));
                }


                range += dictionary.ElementAt(i).Value;
            }

            return range;
        }

    }
}
