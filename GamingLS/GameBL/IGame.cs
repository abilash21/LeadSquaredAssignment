using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming
{
    /// <summary>
    /// Any New Game can Extend from this interface which has methods
    /// It can be Card Game, Block Game, Snake Game etc..
    /// </summary>
    public interface IGame
    {
        void StartGame();

        void PlayGame();
        void QuitGame();
        void RestartGame();
    }
}
