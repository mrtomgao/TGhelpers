using NUnit.Framework;
using TGhelpers;

namespace TGhelpers.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.That(Helpers.getHello("1") == "1Hello");
        }
    }
}