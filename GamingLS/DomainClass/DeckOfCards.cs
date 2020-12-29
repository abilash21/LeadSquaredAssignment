using Gaming.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming
{
    public class DeckOfCards
    {
        #region Properties
        public List<Card> Cards { get; set; }

        #endregion

        #region Constructor
        public DeckOfCards()
        {
            Cards = new List<Card>();


            for (int i = (int)CardType.CLUBS; i <= (int)CardType.DIAMOND; i++)
            {
                for (int j = (int)Rank.ACE; j <= (int)Rank.KING; j++)
                {
                    Cards.Add(new Card((CardType)i, (Rank)j));
                }
            }
        }

        #endregion

        #region Methods
        public void DisplayAllCards()
        {
            foreach (var card in Cards)
            {
                Console.WriteLine(card.CardType + " " + card.Rank);
            }

            Console.WriteLine("Total No. Of Cards:" + Cards.Count);
        }
        #endregion
    }
}
