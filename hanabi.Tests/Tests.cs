using NUnit.Framework;
using Should;

namespace hanabi.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Should_be_true()
        {
            true.ShouldBeTrue();
        }
    }
}
