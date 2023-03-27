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
            this.btnGoBack.Location = new System.Drawing.Point(50, 312);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 2;
            this.btnGoBack.Text = "Voltar";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnStartMatch
            // 
            this.btnStartMatch.Location = new System.Drawing.Point(277, 264);
            this.btnStartMatch.Name = "btnStartMatch";
            this.btnStartMatch.Size = new System.Drawing.Size(121, 23);
            this.btnStartMatch.TabIndex = 3;
            this.btnStartMatch.Text = "Começar Partida";
            this.btnStartMatch.UseVisualStyleBackColor = true;
            this.btnStartMatch.Click += new System.EventHandler(this.btnStartMatch_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 684);
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
    }
}