namespace TicTacToe
{
    partial class FormGameSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownColumns = new System.Windows.Forms.NumericUpDown();
            this.labelCols = new System.Windows.Forms.Label();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelBoardSize = new System.Windows.Forms.Label();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.TextBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.TextBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.Player1 = new System.Windows.Forms.Label();
            this.CheckBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownColumns
            // 
            this.numericUpDownColumns.Location = new System.Drawing.Point(211, 159);
            this.numericUpDownColumns.Name = "numericUpDownColumns";
            this.numericUpDownColumns.Size = new System.Drawing.Size(44, 22);
            this.numericUpDownColumns.TabIndex = 21;
            this.numericUpDownColumns.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // labelCols
            // 
            this.labelCols.AutoSize = true;
            this.labelCols.Location = new System.Drawing.Point(161, 161);
            this.labelCols.Name = "labelCols";
            this.labelCols.Size = new System.Drawing.Size(37, 16);
            this.labelCols.TabIndex = 20;
            this.labelCols.Text = "Cols:";
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(92, 159);
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(44, 22);
            this.numericUpDownRows.TabIndex = 19;
            this.numericUpDownRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownRows.ValueChanged += new System.EventHandler(this.numericUpDownRows_ValueChanged);
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(42, 161);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(44, 16);
            this.labelRows.TabIndex = 18;
            this.labelRows.Text = "Rows:";
            // 
            // labelBoardSize
            // 
            this.labelBoardSize.AutoSize = true;
            this.labelBoardSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelBoardSize.Location = new System.Drawing.Point(23, 125);
            this.labelBoardSize.Name = "labelBoardSize";
            this.labelBoardSize.Size = new System.Drawing.Size(102, 20);
            this.labelBoardSize.TabIndex = 17;
            this.labelBoardSize.Text = "BoardSize:";
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelPlayers.Location = new System.Drawing.Point(23, 20);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(78, 20);
            this.labelPlayers.TabIndex = 16;
            this.labelPlayers.Text = "Players:";
            // 
            // TextBoxPlayer1
            // 
            this.TextBoxPlayer1.Location = new System.Drawing.Point(148, 54);
            this.TextBoxPlayer1.Name = "TextBoxPlayer1";
            this.TextBoxPlayer1.Size = new System.Drawing.Size(144, 22);
            this.TextBoxPlayer1.TabIndex = 15;
            // 
            // TextBoxPlayer2
            // 
            this.TextBoxPlayer2.Enabled = false;
            this.TextBoxPlayer2.Location = new System.Drawing.Point(148, 90);
            this.TextBoxPlayer2.Name = "TextBoxPlayer2";
            this.TextBoxPlayer2.Size = new System.Drawing.Size(144, 22);
            this.TextBoxPlayer2.TabIndex = 14;
            this.TextBoxPlayer2.Text = "Computer";
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(42, 57);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(59, 16);
            this.Player1.TabIndex = 13;
            this.Player1.Text = "Player 1:";
            // 
            // CheckBoxPlayer2
            // 
            this.CheckBoxPlayer2.AutoSize = true;
            this.CheckBoxPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxPlayer2.Location = new System.Drawing.Point(39, 90);
            this.CheckBoxPlayer2.Name = "CheckBoxPlayer2";
            this.CheckBoxPlayer2.Size = new System.Drawing.Size(81, 20);
            this.CheckBoxPlayer2.TabIndex = 12;
            this.CheckBoxPlayer2.Text = "Player 2:";
            this.CheckBoxPlayer2.UseVisualStyleBackColor = false;
            this.CheckBoxPlayer2.CheckedChanged += new System.EventHandler(this.checkBoxPlayer2_CheckedChanged);
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.ButtonStart.ForeColor = System.Drawing.Color.Black;
            this.ButtonStart.Location = new System.Drawing.Point(39, 201);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(253, 41);
            this.ButtonStart.TabIndex = 11;
            this.ButtonStart.Text = "Start!";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // FormGameSettings
            // 
            this.AcceptButton = this.ButtonStart;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(324, 266);
            this.Controls.Add(this.numericUpDownColumns);
            this.Controls.Add(this.labelCols);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.labelBoardSize);
            this.Controls.Add(this.labelPlayers);
            this.Controls.Add(this.TextBoxPlayer1);
            this.Controls.Add(this.TextBoxPlayer2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.CheckBoxPlayer2);
            this.Controls.Add(this.ButtonStart);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGameSettings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownColumns;
        private System.Windows.Forms.Label labelCols;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Label labelBoardSize;
        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.TextBox TextBoxPlayer1;
        private System.Windows.Forms.TextBox TextBoxPlayer2;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.CheckBox CheckBoxPlayer2;
        private System.Windows.Forms.Button ButtonStart;
    }
}