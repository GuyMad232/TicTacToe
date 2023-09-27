namespace TicTacToe
{
    partial class FormGame
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
            this.labelPlayer1Name = new System.Windows.Forms.Label();
            this.labelPlayer2Name = new System.Windows.Forms.Label();
            this.labelScore2 = new System.Windows.Forms.Label();
            this.labelScore1 = new System.Windows.Forms.Label();
            this.labelCurrentPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPlayer1Name
            // 
            this.labelPlayer1Name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPlayer1Name.AutoSize = true;
            this.labelPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1Name.Location = new System.Drawing.Point(55, 378);
            this.labelPlayer1Name.Name = "labelPlayer1Name";
            this.labelPlayer1Name.Size = new System.Drawing.Size(78, 20);
            this.labelPlayer1Name.TabIndex = 17;
            this.labelPlayer1Name.Text = "Players:";
            // 
            // labelPlayer2Name
            // 
            this.labelPlayer2Name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPlayer2Name.AutoSize = true;
            this.labelPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2Name.Location = new System.Drawing.Point(255, 378);
            this.labelPlayer2Name.Name = "labelPlayer2Name";
            this.labelPlayer2Name.Size = new System.Drawing.Size(96, 20);
            this.labelPlayer2Name.TabIndex = 18;
            this.labelPlayer2Name.Text = "Computer:";
            // 
            // labelScore2
            // 
            this.labelScore2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelScore2.AutoSize = true;
            this.labelScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore2.Location = new System.Drawing.Point(354, 378);
            this.labelScore2.Name = "labelScore2";
            this.labelScore2.Size = new System.Drawing.Size(19, 20);
            this.labelScore2.TabIndex = 19;
            this.labelScore2.Text = "0";
            // 
            // labelScore1
            // 
            this.labelScore1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelScore1.AutoSize = true;
            this.labelScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore1.Location = new System.Drawing.Point(136, 378);
            this.labelScore1.Name = "labelScore1";
            this.labelScore1.Size = new System.Drawing.Size(19, 20);
            this.labelScore1.TabIndex = 20;
            this.labelScore1.Text = "0";
            // 
            // labelCurrentPlayer
            // 
            this.labelCurrentPlayer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCurrentPlayer.AutoSize = true;
            this.labelCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPlayer.Location = new System.Drawing.Point(55, 345);
            this.labelCurrentPlayer.Name = "labelCurrentPlayer";
            this.labelCurrentPlayer.Size = new System.Drawing.Size(47, 20);
            this.labelCurrentPlayer.TabIndex = 21;
            this.labelCurrentPlayer.Text = "Turn";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 407);
            this.Controls.Add(this.labelCurrentPlayer);
            this.Controls.Add(this.labelScore1);
            this.Controls.Add(this.labelScore2);
            this.Controls.Add(this.labelPlayer2Name);
            this.Controls.Add(this.labelPlayer1Name);
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToeMisere";
            this.Load += new System.EventHandler(this.formGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayer1Name;
        private System.Windows.Forms.Label labelPlayer2Name;
        private System.Windows.Forms.Label labelScore2;
        private System.Windows.Forms.Label labelScore1;
        private System.Windows.Forms.Label labelCurrentPlayer;
    }
}