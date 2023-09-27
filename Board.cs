using System.Collections.Generic;

namespace TicTacToe
{
    internal class Board
    {
        internal readonly List<Cell> r_AvailableCells = new List<Cell>();
        public Board(int i_BoardSize)
        {
            createBoard(i_BoardSize);
        }

        internal int m_SizeOfBoard { get; private set; }
        internal Cell[,] r_MyBoardCells { get; private set; }

        private void createBoard(int io_BoardSize)
        {
            setBoardSize(io_BoardSize);
            r_MyBoardCells = new Cell[io_BoardSize, io_BoardSize];
            createCells();
        }

        private void createCells()
        {
            for (int row = 0; row < m_SizeOfBoard; row++)
            {
                for (int col = 0; col < m_SizeOfBoard; col++)
                {
                    r_MyBoardCells[row, col] = new Cell();
                    r_MyBoardCells[row, col].m_Row = row;
                    r_MyBoardCells[row, col].m_Col = col;
                    r_MyBoardCells[row, col].ReportCellStateChanged += this.removeCellFromAvailability;
                    r_AvailableCells.Add(r_MyBoardCells[row, col]);
                }
            }
        }
        private void removeCellFromAvailability(Cell i_Cell)
        {
            r_AvailableCells.Remove(i_Cell);
        }
        private void setBoardSize(int i_BoardSize)
        {
            m_SizeOfBoard = i_BoardSize;
        }

        internal void ClearLogicalBoard()
        {
            r_AvailableCells.Clear();
            createCells();
        }
    }
}