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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.lstTiles = new System.Windows.Forms.ListView();
            this.btnRefreshBoard = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnMoveBack = new System.Windows.Forms.Button();
            this.btnMoveForward = new System.Windows.Forms.Button();
            this.numChoosePawn = new System.Windows.Forms.NumericUpDown();
            this.lstHandCards = new System.Windows.Forms.ListView();
            this.pnlBoard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numChoosePawn)).BeginInit();
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
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(208, 270);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(112, 23);
            this.btnSkip.TabIndex = 2;
            this.btnSkip.Text = "Pular vez";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnMoveBack
            // 
            this.btnMoveBack.Location = new System.Drawing.Point(208, 299);
            this.btnMoveBack.Name = "btnMoveBack";
            this.btnMoveBack.Size = new System.Drawing.Size(112, 23);
            this.btnMoveBack.TabIndex = 3;
            this.btnMoveBack.Text = "Mover para trás";
            this.btnMoveBack.UseVisualStyleBackColor = true;
            this.btnMoveBack.Click += new System.EventHandler(this.btnMoveBack_Click);
            // 
            // btnMoveForward
            // 
            this.btnMoveForward.Location = new System.Drawing.Point(208, 328);
            this.btnMoveForward.Name = "btnMoveForward";
            this.btnMoveForward.Size = new System.Drawing.Size(112, 23);
            this.btnMoveForward.TabIndex = 4;
            this.btnMoveForward.Text = "Mover para frente";
            this.btnMoveForward.UseVisualStyleBackColor = true;
            this.btnMoveForward.Click += new System.EventHandler(this.btnMoveForward_Click);
            // 
            // numChoosePawn
            // 
            this.numChoosePawn.Location = new System.Drawing.Point(208, 357);
            this.numChoosePawn.Name = "numChoosePawn";
            this.numChoosePawn.Size = new System.Drawing.Size(112, 20);
            this.numChoosePawn.TabIndex = 5;
            // 
            // lstHandCards
            // 
            this.lstHandCards.HideSelection = false;
            this.lstHandCards.Location = new System.Drawing.Point(12, 270);
            this.lstHandCards.Name = "lstHandCards";
            this.lstHandCards.Size = new System.Drawing.Size(190, 107);
            this.lstHandCards.TabIndex = 8;
            this.lstHandCards.UseCompatibleStateImageBehavior = false;
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(351, 12);
            this.pnlBoard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(250, 440);
            this.pnlBoard.TabIndex = 9;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1571, 649);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.lstHandCards);
            this.Controls.Add(this.numChoosePawn);
            this.Controls.Add(this.btnMoveForward);
            this.Controls.Add(this.btnMoveBack);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnRefreshBoard);
            this.Controls.Add(this.lstTiles);
            this.Name = "Board";
            this.Text = "Board";
            ((System.ComponentModel.ISupportInitialize)(this.numChoosePawn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstTiles;
        private System.Windows.Forms.Button btnRefreshBoard;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnMoveBack;
        private System.Windows.Forms.Button btnMoveForward;
        private System.Windows.Forms.NumericUpDown numChoosePawn;
        private System.Windows.Forms.ListView lstHandCards;
        private System.Windows.Forms.Panel pnlBoard;
    }
}