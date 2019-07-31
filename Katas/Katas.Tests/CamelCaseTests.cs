using Xunit;

namespace Katas.Tests
{
    public class CamelCaseTests
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal("TestCase", "test case".ToCamelCase());
            Assert.Equal("CamelCaseMethod", "camel case method".ToCamelCase());
            Assert.Equal("SayHello", "say hello".ToCamelCase());
            Assert.Equal("CamelCaseWord", " camel case word".ToCamelCase());
            Assert.Equal("", "".ToCamelCase());
        }

        [Fact]
        public void ImprovedSolution()
        {
            Assert.Equal("TestCase", "test case".ToImprovedCamelCase());
            Assert.Equal("CamelCaseMethod", "camel case method".ToImprovedCamelCase());
            Assert.Equal("SayHello", "say hello".ToImprovedCamelCase());
            Assert.Equal("CamelCaseWord", " camel case word".ToImprovedCamelCase());
            Assert.Equal("", "".ToImprovedCamelCase());
        }
    }
}
