using KataKlondike;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KataKlondikeTests
{
    public class FoundationPileTests
    {
        [Fact]
        public void Should_Push_An_Ace_In_An_Empty_Pile()
        {
            IPile pile = new FoundationPile();

            var card = new Card(1, CardType.Spade);

            Assert.True(pile.Push(card));
        }

        [Fact]
        public void Should_Not_Push_An_Ace_In_An_Not_Empty_Pile()
        {
            IPile pile = new FoundationPile();

            var card = new Card(1, CardType.Spade);

            pile.Push(card);
            Assert.False(pile.Push(card));
        }

        [Fact]
        public void Should_Not_Push_An_3_In_An_Empty_Pile()
        {
            IPile pile = new FoundationPile();

            var card3 = new Card(3, CardType.Spade);

            Assert.False(pile.Push(card3));
        }

        [Fact]
        public void Should_Push_An_3_In_An_Pile_Witn_2()
        {
            IPile pile = new FoundationPile();

            var cardACE = new Card(1, CardType.Spade);
            var card2 = new Card(2, CardType.Spade);
            var card3 = new Card(3, CardType.Spade);

            pile.Push(cardACE);
            pile.Push(card2);
            Assert.True(pile.Push(card3));
        }

        //TO DO
        [Fact(Skip ="TO DO")]
        public void Should_Push_A_CArd_With_The_SAme_Color()
        {

        }

        //TO DO
        [Fact(Skip = "TO DO")]
        public void Should_Not_Push_A_CArd_With_Different_Color()
        {

        }

        [Fact]
        public void Should_Not_Pop_If_Target_Is_Stock()
        {
            IPile pile = new FoundationPile();

            var cardACE = new Card(1, CardType.Spade);

            pile.Push(cardACE);

            IPile target = new StockPile();

            Assert.False(pile.PopRefactor(target));
        }

        [Fact]
        public void Should_Pop_If_Target_Is_Not_Stock()
        {
            IPile pile = new FoundationPile();

            var cardACE = new Card(1, CardType.Spade);

            pile.Push(cardACE);

            Mock<IPile> mockPile = new Mock<IPile>();

            IPile target = new TableauPile();

            Assert.True(pile.PopRefactor(target));
        }
    }
}
