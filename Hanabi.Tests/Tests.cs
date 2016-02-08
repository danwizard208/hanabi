using NUnit.Framework;
using Should;
using Hanabi;
using Hanabi.Model;

namespace Hanabi.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Should_be_true()
        {
            true.ShouldBeTrue();
        }

        [Test]
        public void Should_Make_50_Card_Deck()
        {
            Deck.CreateDeck().CardsRemaining.ShouldEqual(50);
        }
    }
}
