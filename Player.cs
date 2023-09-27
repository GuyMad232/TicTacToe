namespace TicTacToe
{
    internal class Player
    {
        internal int m_NumberOfScores;
        internal Cell.eCellState m_PlayerSymbol;
        internal ePlayerTypes m_PlayerType;

        public Player(Cell.eCellState i_Symbol, ePlayerTypes i_Type)
        {
            m_PlayerSymbol = i_Symbol;
            m_NumberOfScores = 0;
            m_PlayerType = i_Type;
        }

        internal enum ePlayerTypes
        {
            Human,
            Computer
        }
    }
}