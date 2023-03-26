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
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 822);
            this.Controls.Add(this.lstPlayers);
            this.Name = "Lobby";
            this.Text = "MatchLobby";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstPlayers;
    }
}