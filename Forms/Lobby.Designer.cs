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
            this.lstPlayers = new System.Windows.Forms.ListView();
            this.btnRefreshListPlayers = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnStartMatch = new System.Windows.Forms.Button();
            this.btnGoToBoard = new System.Windows.Forms.Button();
            this.btnEnterTheMatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPlayers
            // 
            this.lstPlayers.HideSelection = false;
            this.lstPlayers.Location = new System.Drawing.Point(50, 48);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(348, 198);
            this.lstPlayers.TabIndex = 0;
            this.lstPlayers.UseCompatibleStateImageBehavior = false;
            // 
            // btnRefreshListPlayers
            // 
            this.btnRefreshListPlayers.Location = new System.Drawing.Point(50, 264);
            this.btnRefreshListPlayers.Name = "btnRefreshListPlayers";
            this.btnRefreshListPlayers.Size = new System.Drawing.Size(173, 23);
            this.btnRefreshListPlayers.TabIndex = 1;
            this.btnRefreshListPlayers.Text = "Atualizar Lista de Jogadores";
            this.btnRefreshListPlayers.UseVisualStyleBackColor = true;
            this.btnRefreshListPlayers.Click += new System.EventHandler(this.btnRefreshListPlayers_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(183, 303);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 2;
            this.btnGoBack.Text = "Voltar";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnStartMatch
            // 
            this.btnStartMatch.Location = new System.Drawing.Point(242, 264);
            this.btnStartMatch.Name = "btnStartMatch";
            this.btnStartMatch.Size = new System.Drawing.Size(156, 23);
            this.btnStartMatch.TabIndex = 3;
            this.btnStartMatch.Text = "Começar a Partida";
            this.btnStartMatch.UseVisualStyleBackColor = true;
            this.btnStartMatch.Click += new System.EventHandler(this.btnStartMatch_Click);
            // 
            // btnGoToBoard
            // 
            this.btnGoToBoard.Location = new System.Drawing.Point(277, 303);
            this.btnGoToBoard.Name = "btnGoToBoard";
            this.btnGoToBoard.Size = new System.Drawing.Size(121, 23);
            this.btnGoToBoard.TabIndex = 4;
            this.btnGoToBoard.Text = "Ver o Tabuleiro";
            this.btnGoToBoard.UseVisualStyleBackColor = true;
            this.btnGoToBoard.Click += new System.EventHandler(this.btnGoToBoard_Click);
            // 
            // btnEnterTheMatch
            // 
            this.btnEnterTheMatch.Location = new System.Drawing.Point(50, 303);
            this.btnEnterTheMatch.Name = "btnEnterTheMatch";
            this.btnEnterTheMatch.Size = new System.Drawing.Size(114, 23);
            this.btnEnterTheMatch.TabIndex = 5;
            this.btnEnterTheMatch.Text = "Entrar na Partida";
            this.btnEnterTheMatch.UseVisualStyleBackColor = true;
            this.btnEnterTheMatch.Click += new System.EventHandler(this.btnEnterTheMatch_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 569);
            this.Controls.Add(this.btnEnterTheMatch);
            this.Controls.Add(this.btnGoToBoard);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnStartMatch);
            this.Controls.Add(this.btnRefreshListPlayers);
            this.Controls.Add(this.lstPlayers);
            this.Name = "Lobby";
            this.Text = "MatchLobby";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstPlayers;
        private System.Windows.Forms.Button btnRefreshListPlayers;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnStartMatch;
        private System.Windows.Forms.Button btnGoToBoard;
        private System.Windows.Forms.Button btnEnterTheMatch;
    }
}