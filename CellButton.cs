using System;
using System.Windows.Forms;

namespace TicTacToe
{
    internal class CellButton : Button
    {
        protected internal int m_Col = 0;
        protected internal int m_Row = 0;
        public event Action<CellButton> ReportCellButtonClicked;

        public CellButton(int i_Length, int i_Width)
        {
            this.Location = new System.Drawing.Point(i_Width, i_Length);
            this.BackColor = System.Drawing.Color.Linen;
            this.MaximumSize = new System.Drawing.Size(70, 70);
            this.MinimumSize = new System.Drawing.Size(70, 70);
            this.Enabled = true;
            this.Visible = true;
            this.Text = "";
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Click += new System.EventHandler(this.cellButton_Click);
        }

        internal void ChangeText(CellButton i_CellButton, string i_Symbol)
        {
            i_CellButton.Text = i_Symbol;
            i_CellButton.ForeColor = System.Drawing.Color.Black;
        }

        private void onCellButtonClick()
        {
            ReportCellButtonClicked?.Invoke(this);
        }

        private void cellButton_Click(object i_Sender, EventArgs e)
        {
            this.Enabled = false;
            onCellButtonClick();
        }
    }
}