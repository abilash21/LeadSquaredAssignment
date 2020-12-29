using Gaming.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming
{
    /// <summary>
    /// CardGame Class which extends from IGame Interface which implements all the methods from the interface
    /// Any Type of CardGame can extend from this class as this have common methods specific to Cards
    /// Class is Open for extension, closed for modification
    /// </summary>
    public abstract class CardGame : IGame
    {
     
        public abstract void PlayGame();
        public abstract void QuitGame();
        public abstract void RestartGame();
        public abstract void StartGame();

        public void ShuffleCards(DeckOfCards deckOfCards)
        {
            try
            {
                LogHandler.Instance.WriteTraceLog("CardGame.ShuffleCards Started", TraceEventType.Information);

                Random rand = new Random();
                int length = deckOfCards.Cards.Count;
                for (int i = 0; i < length; i++)
                {
                    int randIndex = i + rand.Next(length - i);

                    Card temp = deckOfCards.Cards[randIndex];
                    deckOfCards.Cards[randIndex] = deckOfCards.Cards[i];
                    deckOfCards.Cards[i] = temp;
                }

                Console.WriteLine("Deck of Cards Shuffled!! Total Cards Available: " + deckOfCards.Cards.Count);

            }
            catch (Exception ex)
            {
                string errorMsg = "Exception  - CardGame.ShuffleCards! ERROR:" + ex.ToString();
                LogHandler.Instance.WriteTraceLog(errorMsg, TraceEventType.Error);
                Console.WriteLine(errorMsg);
            }
            finally
            {
                LogHandler.Instance.WriteTraceLog("CardGame.ShuffleCards Ended", TraceEventType.Information);
            }
        }



    }
}
