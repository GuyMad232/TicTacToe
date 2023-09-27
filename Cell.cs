using System;

namespace TicTacToe
{
    internal class Cell
    {
        public event Action<Cell> ReportCellStateChanged;
        protected internal int m_Col = 0;
        protected internal int m_Row = 0;
        public enum eCellState
        {
            Empty,
            X,
            O
        }

        public Cell()
        {
            State = eCellState.Empty;
        }

        public eCellState State { get; set; }

        internal void ChangeState(eCellState i_State)
        {
            this.State = i_State;
            onCellStateChanged();
        }
        private void onCellStateChanged()
        {
            ReportCellStateChanged?.Invoke(this);
        }
    }
}