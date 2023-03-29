namespace CartagenaBuenaventura.Forms
{
    partial class Board
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
            this.lstTiles = new System.Windows.Forms.ListView();
            this.btnRefreshBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTiles
            // 
            this.lstTiles.HideSelection = false;
            this.lstTiles.Location = new System.Drawing.Point(12, 12);
            this.lstTiles.Name = "lstTiles";
            this.lstTiles.Size = new System.Drawing.Size(308, 204);
            this.lstTiles.TabIndex = 0;
            this.lstTiles.UseCompatibleStateImageBehavior = false;
            // 
            // btnRefreshBoard
            // 
            this.btnRefreshBoard.Location = new System.Drawing.Point(74, 222);
            this.btnRefreshBoard.Name = "btnRefreshBoard";
            this.btnRefreshBoard.Size = new System.Drawing.Size(149, 23);
            this.btnRefreshBoard.TabIndex = 1;
            this.btnRefreshBoard.Text = "Atualizar Tabuleiro";
            this.btnRefreshBoard.UseVisualStyleBackColor = true;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 400);
            this.Controls.Add(this.btnRefreshBoard);
            this.Controls.Add(this.lstTiles);
            this.Name = "Board";
            this.Text = "Board";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstTiles;
        private System.Windows.Forms.Button btnRefreshBoard;
    }
}