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
            this.lstHandCards = new System.Windows.Forms.ListView();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pnlBackgroundListHandCards = new System.Windows.Forms.Panel();
            this.lblPirateName = new System.Windows.Forms.Label();
            this.pnlGoBackHome = new System.Windows.Forms.Panel();
            this.pnlPirateImage = new System.Windows.Forms.Panel();
            this.pnlBackgroundListHandCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstHandCards
            // 
            this.lstHandCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHandCards.BackColor = System.Drawing.SystemColors.Control;
            this.lstHandCards.BackgroundImage = global::CartagenaBuenaventura.Properties.Resources.wood2;
            this.lstHandCards.BackgroundImageTiled = true;
            this.lstHandCards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstHandCards.HideSelection = false;
            this.lstHandCards.Location = new System.Drawing.Point(0, 10);
            this.lstHandCards.Name = "lstHandCards";
            this.lstHandCards.Size = new System.Drawing.Size(282, 324);
            this.lstHandCards.TabIndex = 8;
            this.lstHandCards.UseCompatibleStateImageBehavior = false;
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackColor = System.Drawing.Color.Transparent;
            this.pnlBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBoard.Location = new System.Drawing.Point(21, 24);
            this.pnlBoard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(600, 375);
            this.pnlBoard.TabIndex = 9;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlBackgroundListHandCards
            // 
            this.pnlBackgroundListHandCards.BackgroundImage = global::CartagenaBuenaventura.Properties.Resources.wood2;
            this.pnlBackgroundListHandCards.Controls.Add(this.lstHandCards);
            this.pnlBackgroundListHandCards.Location = new System.Drawing.Point(672, 106);
            this.pnlBackgroundListHandCards.Name = "pnlBackgroundListHandCards";
            this.pnlBackgroundListHandCards.Size = new System.Drawing.Size(282, 334);
            this.pnlBackgroundListHandCards.TabIndex = 10;
            // 
            // lblPirateName
            // 
            this.lblPirateName.AutoSize = true;
            this.lblPirateName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPirateName.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPirateName.ForeColor = System.Drawing.Color.Silver;
            this.lblPirateName.Location = new System.Drawing.Point(142, 406);
            this.lblPirateName.Name = "lblPirateName";
            this.lblPirateName.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.lblPirateName.Size = new System.Drawing.Size(107, 49);
            this.lblPirateName.TabIndex = 0;
            this.lblPirateName.Text = "Pirate";
            // 
            // pnlGoBackHome
            // 
            this.pnlGoBackHome.BackColor = System.Drawing.Color.Transparent;
            this.pnlGoBackHome.BackgroundImage = global::CartagenaBuenaventura.Properties.Resources.home_icon;
            this.pnlGoBackHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGoBackHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlGoBackHome.Location = new System.Drawing.Point(895, 15);
            this.pnlGoBackHome.Name = "pnlGoBackHome";
            this.pnlGoBackHome.Size = new System.Drawing.Size(59, 42);
            this.pnlGoBackHome.TabIndex = 11;
            this.pnlGoBackHome.Click += new System.EventHandler(this.pnlGoBackHome_Click);
            // 
            // pnlPirateImage
            // 
            this.pnlPirateImage.BackColor = System.Drawing.Color.Transparent;
            this.pnlPirateImage.BackgroundImage = global::CartagenaBuenaventura.Properties.Resources.PirateRed;
            this.pnlPirateImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPirateImage.Location = new System.Drawing.Point(21, 364);
            this.pnlPirateImage.Name = "pnlPirateImage";
            this.pnlPirateImage.Size = new System.Drawing.Size(106, 84);
            this.pnlPirateImage.TabIndex = 12;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CartagenaBuenaventura.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1154, 507);
            this.Controls.Add(this.pnlPirateImage);
            this.Controls.Add(this.pnlGoBackHome);
            this.Controls.Add(this.lblPirateName);
            this.Controls.Add(this.pnlBackgroundListHandCards);
            this.Controls.Add(this.pnlBoard);
            this.Name = "Board";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "Board";
            this.pnlBackgroundListHandCards.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstHandCards;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel pnlBackgroundListHandCards;
        private System.Windows.Forms.Label lblPirateName;
        private System.Windows.Forms.Panel pnlGoBackHome;
        private System.Windows.Forms.Panel pnlPirateImage;
    }
}