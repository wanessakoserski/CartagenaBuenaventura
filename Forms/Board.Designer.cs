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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnMoveBack = new System.Windows.Forms.Button();
            this.btnMoveForward = new System.Windows.Forms.Button();
            this.numChoosePawn = new System.Windows.Forms.NumericUpDown();
            this.lstHandCards = new System.Windows.Forms.ListView();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numChoosePawn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(488, 296);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(112, 23);
            this.btnSkip.TabIndex = 2;
            this.btnSkip.Text = "Pular vez";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnMoveBack
            // 
            this.btnMoveBack.Location = new System.Drawing.Point(488, 325);
            this.btnMoveBack.Name = "btnMoveBack";
            this.btnMoveBack.Size = new System.Drawing.Size(112, 23);
            this.btnMoveBack.TabIndex = 3;
            this.btnMoveBack.Text = "Mover para trás";
            this.btnMoveBack.UseVisualStyleBackColor = true;
            this.btnMoveBack.Click += new System.EventHandler(this.btnMoveBack_Click);
            // 
            // btnMoveForward
            // 
            this.btnMoveForward.Location = new System.Drawing.Point(488, 354);
            this.btnMoveForward.Name = "btnMoveForward";
            this.btnMoveForward.Size = new System.Drawing.Size(112, 23);
            this.btnMoveForward.TabIndex = 4;
            this.btnMoveForward.Text = "Mover para frente";
            this.btnMoveForward.UseVisualStyleBackColor = true;
            this.btnMoveForward.Click += new System.EventHandler(this.btnMoveForward_Click);
            // 
            // numChoosePawn
            // 
            this.numChoosePawn.Location = new System.Drawing.Point(488, 383);
            this.numChoosePawn.Name = "numChoosePawn";
            this.numChoosePawn.Size = new System.Drawing.Size(112, 20);
            this.numChoosePawn.TabIndex = 5;
            // 
            // lstHandCards
            // 
            this.lstHandCards.BackColor = System.Drawing.SystemColors.Control;
            this.lstHandCards.HideSelection = false;
            this.lstHandCards.Location = new System.Drawing.Point(1, 271);
            this.lstHandCards.Name = "lstHandCards";
            this.lstHandCards.Size = new System.Drawing.Size(408, 247);
            this.lstHandCards.TabIndex = 8;
            this.lstHandCards.UseCompatibleStateImageBehavior = false;
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(9, 9);
            this.pnlBoard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(400, 250);
            this.pnlBoard.TabIndex = 9;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 684);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.lstHandCards);
            this.Controls.Add(this.numChoosePawn);
            this.Controls.Add(this.btnMoveForward);
            this.Controls.Add(this.btnMoveBack);
            this.Controls.Add(this.btnSkip);
            this.Name = "Board";
            this.Text = "Board";
            ((System.ComponentModel.ISupportInitialize)(this.numChoosePawn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnMoveBack;
        private System.Windows.Forms.Button btnMoveForward;
        private System.Windows.Forms.NumericUpDown numChoosePawn;
        private System.Windows.Forms.ListView lstHandCards;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.ImageList imageList;
    }
}