using Xunit;

namespace Katas.Tests
{
    public class TowerTests
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal(string.Join(",", new[] { "*" }), string.Join(",", Tower.TowerBuilder(1)));
            Assert.Equal(string.Join(",", new[] { " * ", "***" }), string.Join(",", Tower.TowerBuilder(2)));
            Assert.Equal(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", Tower.TowerBuilder(3)));
        }
    }
}
