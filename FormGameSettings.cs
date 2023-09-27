using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormGameSettings : Form
    {
        public readonly List<string> r_GameSettings = new List<string>();

        public FormGameSettings()
        {
            InitializeComponent();
        }

        private void numericUpDownRows_ValueChanged(object i_Sender, EventArgs e)
        {
            if (numericUpDownRows.Value > 10)
            {
                numericUpDownRows.Value = 10;
            }
            else if (numericUpDownRows.Value < 4)
            {
                numericUpDownRows.Value = 4;
            }

            matchRowValues(numericUpDownRows);
        }

        private void matchRowValues(NumericUpDown i_NumericList)
        {
            this.numericUpDownColumns.Value = i_NumericList.Value;
        }

        private void buttonStart_Click(object i_Sender, EventArgs e)
        {
            r_GameSettings.Add(this.numericUpDownRows.Text);
            r_GameSettings.Add(this.TextBoxPlayer1.Text);
            r_GameSettings.Add(this.TextBoxPlayer2.Text);
            this.Close();
        }

        private void checkBoxPlayer2_CheckedChanged(object i_Sender, EventArgs e)
        {
            this.TextBoxPlayer2.Enabled = !this.TextBoxPlayer2.Enabled;
        }
    }
}