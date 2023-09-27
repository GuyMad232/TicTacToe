using System;
using System.Drawing;
using System.Windows.Forms;
using static TicTacToe.Cell;

namespace TicTacToe
{
    public partial class FormGame : Form
    {
        internal static int s_BoardSize = 4;
        private readonly FormGameSettings r_formGameSettings = new FormGameSettings();
        private readonly Timer r_timer = new Timer();
        internal string m_Opponent = "Computer";
        public FormGame()
        {
            InitializeComponent();
            r_formGameSettings.ShowDialog();
            setBoard();
            setPlayersName();
        }

        internal CellButton[,] m_Cells { get; set; }


        private void createBoardButtons()
        {
            m_Cells = new CellButton[s_BoardSize, s_BoardSize];
            for (int row = 0; row < s_BoardSize; row++)
            {
                for (int col = 0; col < s_BoardSize; col++)
                {
                    m_Cells[row, col] = new CellButton(row * 70, col * 70);
                    m_Cells[row, col].Name = $"{row},{col}";
                    m_Cells[row, col].m_Row = row;
                    m_Cells[row, col].m_Col = col;
                    this.Controls.Add(m_Cells[row, col]);
                }
            }
        }

        private void setBoard()
        {
            s_BoardSize = int.Parse(r_formGameSettings.r_GameSettings[0]);
            this.Size = new Size(s_BoardSize * 70, s_BoardSize * 85);
            this.ClientSize = new Size(s_BoardSize * 70, s_BoardSize * 85);
            createBoardButtons();
        }

        private void setPlayersName()
        {
            labelPlayer1Name.Text = r_formGameSettings.r_GameSettings[1];
            labelPlayer2Name.Text = r_formGameSettings.r_GameSettings[2];
            m_Opponent = labelPlayer2Name.Text;
        }

        private void formGame_Load(object i_Sender, EventArgs e)
        {
            r_timer.Interval = 10000;
            r_timer.Tick += timer_Tick;
            r_timer.Start();
        }

        private void timer_Tick(object i_Sender, EventArgs e)
        {
            Refresh();
        }

        internal void UpdateScore(Player i_Player1, Player i_Player2)
        {
            labelScore1.Text = i_Player1.m_NumberOfScores.ToString();
            labelScore2.Text = i_Player2.m_NumberOfScores.ToString();
        }

        internal void ApplyButtonChanges(int io_Row, int io_Col, string i_Symbol)
        {
            m_Cells[io_Row, io_Col].ChangeText(m_Cells[io_Row, io_Col], i_Symbol);
        }

        internal void ClearVisualBoard()
        {
            foreach (CellButton button in m_Cells)
            {
                button.Text = "";
                button.Enabled = true;
            }
        }

        internal void ChangeCurrentPlayerName(Player i_CurrentPlayer)
        {
            if (i_CurrentPlayer.m_PlayerSymbol == Cell.eCellState.X)
            {
                labelCurrentPlayer.Text = string.Format("{0}'s Turn", labelPlayer1Name.Text);
            }
            else
            {
                labelCurrentPlayer.Text = string.Format("{0}'s Turn", labelPlayer2Name.Text);
            }
        }
    }
}