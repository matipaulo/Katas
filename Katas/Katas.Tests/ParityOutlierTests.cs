using Xunit;

namespace Katas.Tests
{
    public class ParityOutlierTests
    {
        [Fact]
        public static void Test1()
        {
            int[] exampleTest1 = { 2, 6, 8, -10, 3 };
            Assert.Equal(3, ParityOutlier.Find(exampleTest1));
        }

        [Fact]
        public static void Test2()
        {
            int[] exampleTest2 = { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
            Assert.Equal(206847684, ParityOutlier.Find(exampleTest2));
        }

        [Fact]
        public static void Test3()
        {
            int[] exampleTest3 = { int.MaxValue, 0, 1 };
            Assert.Equal(0, ParityOutlier.Find(exampleTest3));
        }
    }
}
