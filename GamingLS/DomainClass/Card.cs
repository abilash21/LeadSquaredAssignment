using Gaming.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming
{
    public class Card
    {
        #region Fields
        private CardType cardType;
        private Rank rank;
        #endregion

        #region Properties
        public Card(CardType cardType, Rank rank)
        {
            this.cardType = cardType;
            this.rank = rank;
        }



        public CardType CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }



        public Rank Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        #endregion

    }
}
