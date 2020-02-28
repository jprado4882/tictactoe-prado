namespace JPradoAssignment3
{
    partial class TicTacToeForm
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
            this.pnlTile = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlTile
            // 
            this.pnlTile.BackColor = System.Drawing.Color.Lavender;
            this.pnlTile.Location = new System.Drawing.Point(0, 0);
            this.pnlTile.Name = "pnlTile";
            this.pnlTile.Size = new System.Drawing.Size(325, 325);
            this.pnlTile.TabIndex = 0;
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 301);
            this.Controls.Add(this.pnlTile);
            this.Name = "TicTacToeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.TicTacToeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTile;
    }
}

