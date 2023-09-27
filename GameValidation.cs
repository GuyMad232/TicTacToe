namespace TicTacToe
{
    internal static class GameValidation
    {
        internal static bool HasStrike(Cell.eCellState i_Symbol, Board i_Board)
        {
            for (int row = 0; row < i_Board.m_SizeOfBoard; row++)
            {
                bool hasStrike = true;
                for (int column = 0; column < i_Board.m_SizeOfBoard; column++)
                {
                    if (i_Board.r_MyBoardCells[row, column].State != i_Symbol)
                    {
                        hasStrike = false;
                        break;
                    }
                }

                if (hasStrike)
                {
                    return true;
                }
            }

            for (int column = 0; column < i_Board.m_SizeOfBoard; column++)
            {
                bool hasStrike = true;
                for (int row = 0; row < i_Board.m_SizeOfBoard; row++)
                {
                    if (i_Board.r_MyBoardCells[row, column].State != i_Symbol)
                    {
                        hasStrike = false;
                        break;
                    }
                }

                if (hasStrike)
                {
                    return true;
                }
            }

            bool hasStrikeDiagonal1 = true;
            bool hasStrikeDiagonal2 = true;

            for (int i = 0; i < i_Board.m_SizeOfBoard; i++)
            {
                if (i_Board.r_MyBoardCells[i, i].State != i_Symbol)
                {
                    hasStrikeDiagonal1 = false;
                }

                if (i_Board.r_MyBoardCells[i, i_Board.m_SizeOfBoard - 1 - i].State != i_Symbol)
                {
                    hasStrikeDiagonal2 = false;
                }
            }

            if (hasStrikeDiagonal1 || hasStrikeDiagonal2)
            {
                return true;
            }

            return false;
        }

        internal static bool IsDraw(Board i_MyBoard)
        {
            bool draw = true;
            for (int row = 0; row < i_MyBoard.m_SizeOfBoard; row++)
            {
                for (int column = 0; column < i_MyBoard.m_SizeOfBoard; column++)
                {
                    if (i_MyBoard.r_MyBoardCells[row, column].State == Cell.eCellState.Empty)
                    {
                        draw = false;
                    }
                }
            }

            return draw;
        }
    }
}