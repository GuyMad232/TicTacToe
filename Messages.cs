using System;
using System.Windows.Forms;

namespace TicTacToe
{
    internal class Messages : Form
    {
        public event Action<object> CloseGame;

        public event Action<object> NewGame;

        internal void DisplayQuestionMessage(string io_Message)
        {
            string title = "TicTacToe";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(io_Message, title, button, MessageBoxIcon.Question);
            this.Close();

            if (result == DialogResult.No)
            {
                onUserWantToQuit();
            }
            else
            {
                onUserWantAnotherRound();
            }
        }

        internal void DisplayWinner(Cell.eCellState i_PlayerSymbol)
        {
            string message = string.Format("Player {0} you are the BIG winner! \n Another Round?", i_PlayerSymbol);
            DisplayQuestionMessage(message);
        }

        internal void DisplayTeko()
        {
            string message = "It's a draw, both of you are WINNERS!";
            DisplayQuestionMessage(message);
        }

        private void onUserWantToQuit()
        {
            CloseGame?.Invoke(this);
        }

        private void onUserWantAnotherRound()
        {
            NewGame?.Invoke(this);
        }
    }
}