using System;
using System.Collections.Generic;
using System.Threading;
using static TicTacToe.Player;

namespace TicTacToe
{
    internal class GameControls
    {
        private Player m_currentPlayer;
        private readonly FormGame r_formGame = new FormGame();
        private bool m_gameOn = true;
        private readonly List<int> r_inputMove = new List<int>();
        private readonly Messages r_messages = new Messages();
        private Board m_myBoard;
        private Player m_playerOne;
        private Player m_playerTwo;
        public event Action<Player> ReportCurrentPlayerChanged;

        internal void SetGame()
        {
            int rivalType = 1;
            m_myBoard = new Board(FormGame.s_BoardSize);
            if (r_formGame.m_Opponent == "Computer")
            {
                rivalType = 2;
            }

            ReportCurrentPlayerChanged += r_formGame.ChangeCurrentPlayerName;
            ReportCurrentPlayerChanged += this.playComputerMove;
            setPlayers(setRival(rivalType));
            m_currentPlayer = m_playerOne;
            onCurrentPlayerChange();
            registerToButtonClickedEvent();
            signForMassagesAlerts();
            r_formGame.ShowDialog();
        }

        private void registerToButtonClickedEvent()
        {
            foreach (CellButton cellButton in r_formGame.m_Cells)
            {
                cellButton.ReportCellButtonClicked += cellButtonClicked;
            }
        }

        private void cellButtonClicked(CellButton i_CellButton)
        {
            int row = i_CellButton.m_Row;
            int col = i_CellButton.m_Col;
            r_inputMove.Add(row);
            r_inputMove.Add(col);
            humanTurn();
        }

        private Player.ePlayerTypes setRival(int i_Opponent)
        {
            Player.ePlayerTypes playerType = Player.ePlayerTypes.Computer;

            if (i_Opponent == 1)
            {
                playerType = Player.ePlayerTypes.Human;
            }

            return playerType;
        }

        private void setPlayers(Player.ePlayerTypes i_PlayerType)
        {
            m_playerOne = new Player(Cell.eCellState.X, Player.ePlayerTypes.Human);
            m_playerTwo = new Player(Cell.eCellState.O, i_PlayerType);
        }

        private int generateRandomNumber(int i_MaxValue)
        {
            Random random = new Random();
            return random.Next(0, i_MaxValue);
        }

        private Cell chooseRandomCell()
        {
            int maxValue = m_myBoard.r_AvailableCells.Count - 1;
            int index = generateRandomNumber(maxValue);
            return m_myBoard.r_AvailableCells[index];
        }
        private List<int> generateComputerMove()
        {
            List<int> computerMoves = new List<int>();
            Cell chosenCell = chooseRandomCell();
            computerMoves.Add(chosenCell.m_Row);
            computerMoves.Add(chosenCell.m_Col);
            return computerMoves;
        }

        private void computerTurn()
        {
            if (m_gameOn)
            {
                List<int> computerMoves = generateComputerMove();
                makeMove(computerMoves[0], computerMoves[1]);
                r_formGame.m_Cells[computerMoves[0], computerMoves[1]].Enabled= false;
                r_formGame.Refresh();
                r_formGame.Show();
                changeCurrentPlayer();
            }
        }

        private void humanTurn()
        {
            if (m_gameOn)
            {
                makeMove(r_inputMove[0], r_inputMove[1]);
                r_formGame.Refresh();
                r_formGame.Show();
                r_inputMove.Clear();
                changeCurrentPlayer();
            }
        }

        private void makeMove(int io_Row, int io_Col)
        {
            Cell.eCellState playerSymbol = m_currentPlayer.m_PlayerSymbol;
            m_myBoard.r_MyBoardCells[io_Row, io_Col].ChangeState(playerSymbol);
            r_formGame.ApplyButtonChanges(io_Row, io_Col, playerSymbol.ToString());

            if (GameValidation.HasStrike(playerSymbol, m_myBoard))
            {
                m_gameOn = false;
                changeCurrentPlayer();
                updateScore();
                announceWinner();
            }
            else if (GameValidation.IsDraw(m_myBoard))
            {
                m_gameOn = false;
                teko();
            }
        }

        private void changeCurrentPlayer()
        {
            m_currentPlayer = m_currentPlayer == m_playerOne ? m_playerTwo : m_playerOne;
            onCurrentPlayerChange();
        }
        private void playComputerMove(Player i_CurrentPlayer)
        {
            if (i_CurrentPlayer.m_PlayerType == Player.ePlayerTypes.Computer)
            {
                this.r_formGame.Refresh();
                Thread.Sleep(1000);
                computerTurn();
            }
        }

        private void signForMassagesAlerts()
        {
            r_messages.CloseGame += this.closeGame;
            r_messages.NewGame += this.newGame;
        }

        private void updateScore()
        {
            if (m_currentPlayer.m_PlayerSymbol == m_playerOne.m_PlayerSymbol)
            {
                m_playerOne.m_NumberOfScores = m_playerOne.m_NumberOfScores + 1;
            }
            else if (m_currentPlayer.m_PlayerSymbol == m_playerTwo.m_PlayerSymbol)
            {
                m_playerTwo.m_NumberOfScores = m_playerTwo.m_NumberOfScores + 1;
            }

            r_formGame.UpdateScore(m_playerOne, m_playerTwo);
        }

        private void onCurrentPlayerChange()
        {
            ReportCurrentPlayerChanged?.Invoke(m_currentPlayer);
        }

        private void announceWinner()
        {
            r_messages.DisplayWinner(m_currentPlayer.m_PlayerSymbol);
        }

        private void teko()
        {
            r_messages.DisplayTeko();
        }

        private void closeGame(object i_Sender)
        {
            r_formGame.Close();
        }

        private void newGame(object i_Sender)
        {
            m_myBoard.ClearLogicalBoard();
            r_formGame.ClearVisualBoard();
            m_currentPlayer = m_playerOne;
            onCurrentPlayerChange();
            m_gameOn = true;
        }
    }
}