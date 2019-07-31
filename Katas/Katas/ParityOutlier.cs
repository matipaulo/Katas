using System.Linq;

namespace Katas
{
    /// <summary>
    /// You are given an array (which will have a length of at least 3, but could be very large) containing integers.
    /// The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N.
    /// Write a method that takes the array as an argument and returns this "outlier" N.
    /// </summary>
    public static class ParityOutlier
    {
        public static int Find(int[] integers)
        {
            if (integers == null || integers.Length < 3)
                return -1;

            var isOdd = integers.Count(x => x % 2 != 0) > 1;
            return isOdd ? integers.FirstOrDefault(x => x % 2 == 0) : integers.FirstOrDefault(x => x % 2 != 0);
        }
    }
}
