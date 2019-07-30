using Xunit;

namespace Katas.Tests
{
    public class SmileysTests
    {
        [Fact]
        public void BasicTest()
        {
            Assert.Equal(4, Smileys.CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" }));
            Assert.Equal(2, Smileys.CountSmileys(new string[] { ":)", ":(", ":D", ":O", ":;" }));
            Assert.Equal(1, Smileys.CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }));
            Assert.Equal(0, Smileys.CountSmileys(new string[] { ";", ")", ";*", ":$", "8-D" }));
        }
    }
}
