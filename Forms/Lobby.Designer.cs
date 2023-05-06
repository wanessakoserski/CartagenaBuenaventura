namespace CartagenaBuenaventura.Forms
{
    partial class Lobby
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEnterTheMatch = new System.Windows.Forms.Button();
            this.pnlGoBackMatches = new System.Windows.Forms.Panel();
            this.pnlRefreshListPlayers = new System.Windows.Forms.Panel();
            this.pnlGoToBoard = new System.Windows.Forms.Panel();
            this.pnlStartMatch = new System.Windows.Forms.Panel();
            this.dgdPlayers = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgdPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterTheMatch
            // 
            this.btnEnterTheMatch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEnterTheMatch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnterTheMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterTheMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterTheMatch.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterTheMatch.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEnterTheMatch.Location = new System.Drawing.Point(174, 422);
            this.btnEnterTheMatch.Name = "btnEnterTheMatch";
            this.btnEnterTheMatch.Size = new System.Drawing.Size(313, 41);
            this.btnEnterTheMatch.TabIndex = 5;
            this.btnEnterTheMatch.Text = "Participar da Batalha";
            this.btnEnterTheMatch.UseVisualStyleBackColor = false;
            this.btnEnterTheMatch.Click += new System.EventHandler(this.btnEnterTheMatch_Click);
            // 
            // pnlGoBackMatches
            // 
            this.pnlGoBackMatches.BackColor = System.Drawing.Color.Transparent;
            this.pnlGoBackMatches.BackgroundImage = global::CartagenaBuenaventura.Properties.Resources.go_back_arrow;
            this.pnlGoBackMatches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGoBackMatches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlGoBackMatches.Location = new System.Drawing.Point(20, 20);
            this.pnlGoBackMatches.Name = "pnlGoBackMatches";
            this.pnlGoBackMatches.Size = new System.Drawing.Size(46, 37);
            this.pnlGoBackMatches.TabIndex = 6;
            this.pnlGoBackMatches.Click += new System.EventHandler(this.pnlGoBackMatches_Click);
            this.pnlGoBackMatches.MouseEnter += new System.EventHandler(this.pnlGoBackMatches_MouseEnter);
            this.pnlGoBackMatches.MouseLeave += new System.EventHandler(this.pnlGoBackMatches_MouseLeave);
            // 
            // pnlRefreshListPlayers
            // 
            this.pnlRefreshListPlayers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnlRefreshListPlayers.BackColor = System.Drawing.Color.Transparent;
            this.pnlRefreshListPlayers.BackgroundImage = global::CartagenaBuenaventura.Properties.Resources.refresh;
            this.pnlRefreshListPlayers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRefreshListPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlRefreshListPlayers.Location = new System.Drawing.Point(143, 371);
            this.pnlRefreshListPlayers.Name = "pnlRefreshListPlayers";
            this.pnlRefreshListPlayers.Size = new System.Drawing.Size(25, 20);
            this.pnlRefreshListPlayers.TabIndex = 7;
            this.pnlRefreshListPlayers.Click += new System.EventHandler(this.pnlRefreshListPlayers_Click);
            // 
            // pnlGoToBoard
            // 
            this.pnlGoToBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGoToBoard.BackColor = System.Drawing.Color.Transparent;
            this.pnlGoToBoard.BackgroundImage = global::CartagenaBuenaventura.Properties.Resources.eye;
            this.pnlGoToBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGoToBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlGoToBoard.Location = new System.Drawing.Point(559, 20);
            this.pnlGoToBoard.Name = "pnlGoToBoard";
            this.pnlGoToBoard.Size = new System.Drawing.Size(67, 45);
            this.pnlGoToBoard.TabIndex = 8;
            this.pnlGoToBoard.Click += new System.EventHandler(this.pnlGoToBoard_Click);
            // 
            // pnlStartMatch
            // 
            this.pnlStartMatch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlStartMatch.BackColor = System.Drawing.Color.Transparent;
            this.pnlStartMatch.BackgroundImage = global::CartagenaBuenaventura.Properties.Resources.play;
            this.pnlStartMatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlStartMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlStartMatch.Location = new System.Drawing.Point(278, 124);
            this.pnlStartMatch.Name = "pnlStartMatch";
            this.pnlStartMatch.Size = new System.Drawing.Size(105, 75);
            this.pnlStartMatch.TabIndex = 9;
            this.pnlStartMatch.Click += new System.EventHandler(this.pnlStartMatch_Click);
            // 
            // dgdPlayers
            // 
            this.dgdPlayers.AllowUserToAddRows = false;
            this.dgdPlayers.AllowUserToDeleteRows = false;
            this.dgdPlayers.AllowUserToResizeColumns = false;
            this.dgdPlayers.AllowUserToResizeRows = false;
            this.dgdPlayers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgdPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdPlayers.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgdPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgdPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdPlayers.ColumnHeadersVisible = false;
            this.dgdPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgdPlayers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgdPlayers.GridColor = System.Drawing.Color.RosyBrown;
            this.dgdPlayers.Location = new System.Drawing.Point(174, 339);
            this.dgdPlayers.Name = "dgdPlayers";
            this.dgdPlayers.ReadOnly = true;
            this.dgdPlayers.RowHeadersVisible = false;
            this.dgdPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdPlayers.Size = new System.Drawing.Size(313, 77);
            this.dgdPlayers.TabIndex = 10;
            // 
            // name
            // 
            this.name.HeaderText = "Jogador";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CartagenaBuenaventura.Properties.Resources.ships_duel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 468);
            this.Controls.Add(this.dgdPlayers);
            this.Controls.Add(this.pnlStartMatch);
            this.Controls.Add(this.pnlGoToBoard);
            this.Controls.Add(this.pnlRefreshListPlayers);
            this.Controls.Add(this.pnlGoBackMatches);
            this.Controls.Add(this.btnEnterTheMatch);
            this.DoubleBuffered = true;
            this.Name = "Lobby";
            this.Text = "MatchLobby";
            ((System.ComponentModel.ISupportInitialize)(this.dgdPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEnterTheMatch;
        private System.Windows.Forms.Panel pnlGoBackMatches;
        private System.Windows.Forms.Panel pnlRefreshListPlayers;
        private System.Windows.Forms.Panel pnlGoToBoard;
        private System.Windows.Forms.Panel pnlStartMatch;
        private System.Windows.Forms.DataGridView dgdPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}