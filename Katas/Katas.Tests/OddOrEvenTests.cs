using System;
using System.Linq;
using Xunit;

namespace Katas.Tests
{
    public class OddOrEvenTests
    {
        [Fact]
        public void EdgeTests()
        {
            Assert.Equal("even", OddOrEven.ResolveWithoutLinq(new int[] { 0 }));
            Assert.Equal("odd", OddOrEven.ResolveWithoutLinq(new int[] { 1 }));
            Assert.Equal("even", OddOrEven.ResolveWithoutLinq(new int[] { }));
        }

        [Fact]
        public void EvenTests()
        {
            Assert.Equal("even", OddOrEven.ResolveWithoutLinq(new int[] { 0, 1, 5 }));
            Assert.Equal("even", OddOrEven.ResolveWithoutLinq(new int[] { 0, 1, 3 }));
            Assert.Equal("even", OddOrEven.ResolveWithoutLinq(new int[] { 1023, 1, 2 }));
        }

        [Fact]
        public void NegativeEvenTests()
        {
            Assert.Equal("even", OddOrEven.ResolveWithoutLinq(new int[] { 0, -1, -5 }));
            Assert.Equal("even", OddOrEven.ResolveWithoutLinq(new int[] { 0, -1, -3 }));
            Assert.Equal("even", OddOrEven.ResolveWithoutLinq(new int[] { -1023, 1, -2 }));
        }

        [Fact]
        public void OddTests()
        {
            Assert.Equal("odd", OddOrEven.ResolveWithoutLinq(new int[] { 0, 1, 2 }));
            Assert.Equal("odd", OddOrEven.ResolveWithoutLinq(new int[] { 0, 1, 4 }));
            Assert.Equal("odd", OddOrEven.ResolveWithoutLinq(new int[] { 1023, 1, 3 }));
        }

        [Fact]
        public void NegativeOddTests()
        {
            Assert.Equal("odd", OddOrEven.ResolveWithoutLinq(new int[] { 0, -1, 2 }));
            Assert.Equal("odd", OddOrEven.ResolveWithoutLinq(new int[] { 0, 1, -4 }));
            Assert.Equal("odd", OddOrEven.ResolveWithoutLinq(new int[] { -1023, -1, 3 }));
        }

        [Fact]
        public void RandomTests()
        {
            for (int i = 0; i < 400; ++i)
            {
                int[] array = RandomArray();
                string expected = Solution(array);
                string actual = Solution(array);
                Assert.Equal(expected, actual);
            }
        }

        private static readonly Random RandomGenerator = new Random();

        private static string Solution(int[] array) =>
          (array.Aggregate(0, (p, c) => p + c) & 1) == 1 ? "odd" : "even";

        private static int[] RandomArray()
        {
            int[] array = new int[RandomGenerator.Next(0, 40)];

            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = RandomGenerator.Next(-1000, 1001);
            }

            return array;
        }
    }
}
