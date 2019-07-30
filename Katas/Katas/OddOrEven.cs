using System.Linq;
using Katas.Extensions;

namespace Katas
{
    /// <summary>
    /// Given an array of numbers (a list in groovy), determine whether the sum of all of the numbers is odd or even.
    /// Give your answer in string format as 'odd' or 'even'.
    /// If the input array is empty consider it as: [0] (array with a zero).
    /// </summary>
    public static class OddOrEven
    {
        private const string Even = "even";
        private const string Odd = "odd";

        public static string ResolveWithoutLinq(int[] array)
        {
            if (array.IsNullOrEmpty())
                return Even;

            var sum = 0;
            foreach (var item in array)
                sum += item;

            return sum % 2 == 0 ? Even : Odd;
        }

        public static string ResolveWithLinq(int[] array)
        {
            if (array.IsNullOrEmpty())
                return Even;

            var sum = array.Sum();

            return sum % 2 == 0 ? Even : Odd;
        }
    }
}
