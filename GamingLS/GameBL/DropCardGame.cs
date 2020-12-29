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
    /// DropCardGame class implements CardGame Base Class, hence has common functionality from Base class
    /// This Class has Single resposibility of only DropCardGame
    /// </summary>
    public class DropCardGame : CardGame
    {
        #region Fields
        private DeckOfCards deckOfCards;
        #endregion

        #region Constructor
        public DropCardGame()
        {
            deckOfCards = new DeckOfCards();
            ShuffleCards(deckOfCards);
        }
        #endregion

        #region Methods
        public override void QuitGame()
        {
            try
            {
                LogHandler.Instance.WriteTraceLog("DropCardGame.QuitGame Started", TraceEventType.Information);

                Console.WriteLine("Quiting Game! Good Bye!!");
            }

            catch (Exception ex)
            {

                string errorMsg = "Exception  - DropCardGame.QuitGame! ERROR:" + ex.ToString();
                LogHandler.Instance.WriteTraceLog(errorMsg, TraceEventType.Error);
                throw;
            }
            finally
            {
                LogHandler.Instance.WriteTraceLog("DropCardGame.QuitGame Ended", TraceEventType.Information);
            }
        }

        public override void RestartGame()
        {
            try
            {
                LogHandler.Instance.WriteTraceLog("DropCardGame.RestartGame Started", TraceEventType.Information);

                deckOfCards = new DeckOfCards();
                Console.WriteLine("Restarted Game - Total Cards Remaining: " + deckOfCards.Cards.Count);
                ShuffleCards(deckOfCards);
            }
            catch (Exception ex)
            {

                string errorMsg = "Exception  - DropCardGame.RestartGame! ERROR:" + ex.ToString();
                LogHandler.Instance.WriteTraceLog(errorMsg, TraceEventType.Error);
                throw;
            }
            finally
            {
                LogHandler.Instance.WriteTraceLog("DropCardGame.RestartGame Ended", TraceEventType.Information);
            }

        }

        public override void PlayGame()
        {

            try
            {

                LogHandler.Instance.WriteTraceLog("DropCardGame.PlayGame Started", TraceEventType.Information);

                Console.WriteLine("Droping Card: " + deckOfCards.Cards[0].CardType + "-" + deckOfCards.Cards[0].Rank);
                deckOfCards.Cards.RemoveAt(0);
                Console.WriteLine("Total Cards Remaining: " + deckOfCards.Cards.Count);
            }
            catch (Exception ex)
            {

                string errorMsg = "Exception  - DropCardGame.PlayGame! ERROR:" + ex.ToString();
                LogHandler.Instance.WriteTraceLog(errorMsg, TraceEventType.Error);
                throw;
            }
            finally
            {
                LogHandler.Instance.WriteTraceLog("DropCardGame.PlayGame Ended", TraceEventType.Information);
            }


        }
        public override void StartGame()
        {

            try
            {
                LogHandler.Instance.WriteTraceLog("DropCardGame Started", TraceEventType.Information);

                string key;
                do
                {
                    Console.WriteLine("Enter 'P' for Play, 'S' for Shuffle, 'R' for Restart, 'Q' for Quit");
                    key = Console.ReadLine().ToUpper();
                    switch (key)
                    {
                        case "P":
                            PlayGame();
                            break;
                        case "S":
                            ShuffleCards(deckOfCards);
                            break;
                        case "R":
                            RestartGame();

                            break;

                        case "Q":
                            QuitGame();
                            break;
                        default:
                            Console.WriteLine("Invalid Key! Enter a valid Key..");
                            break;
                    }

                } while (key != "Q");
            }
            catch (Exception ex)
            {
                string errorMsg = "Exception  - DropCardGame.StartGame! ERROR:" + ex.ToString();
                LogHandler.Instance.WriteTraceLog(errorMsg, TraceEventType.Error);
                Console.WriteLine(errorMsg);
            }
            finally
            {
                LogHandler.Instance.WriteTraceLog("DropCardGame Ended", TraceEventType.Information);
            }

        }
        #endregion

    }
}
