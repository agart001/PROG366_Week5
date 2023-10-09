using System.Collections.ObjectModel;

namespace VS22_ConsoleApp.Utility
{

    public static class U_Shuffle
    {

        public static ICollection<T> FYShuffle<T>(ICollection<T> unshuffled)
        {
            Random rand = new Random();

            ICollection<T> shuffled = new Collection<T>();
            while(unshuffled.Count() > 0)
            {
                int rIndex = rand.Next(0, unshuffled.Count());
                shuffled.Append(unshuffled.ElementAt(rIndex));
                unshuffled.Remove(unshuffled.ElementAt(rIndex));
            }

            return shuffled;
        }

    }
    
}