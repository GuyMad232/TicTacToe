using System;

namespace TicTacToe
{
    internal class Program
    {
        [STAThread]
        public static void Main()
        {
            GameControls gameControls = new GameControls();
            gameControls.SetGame();
        }
    }
}