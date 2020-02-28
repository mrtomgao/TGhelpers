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

        //Positive
        [Test]
        public void Pos_getHello()
        {
            Assert.That(Helpers.getHello("1") == "1Hello");
        }
        [Test]
        public void Pos_getBye()
        {
            Assert.That(Helpers.getBye("1") == "1Bye");
        }

        //Negative
        [Test]
        public void Neg_getHello()
        {
            Assert.That(Helpers.getHello("") != "1Hello");
        }
        [Test]
        public void Neg_getBye()
        {
            Assert.That(Helpers.getBye("") != "1Bye");
        }
    }
}