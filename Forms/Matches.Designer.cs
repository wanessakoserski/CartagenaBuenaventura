namespace CartagenaBuenaventura.Forms
{
    partial class Matches
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
            this.btnCreateMatch = new System.Windows.Forms.Button();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefreshListMatches = new System.Windows.Forms.Button();
            this.lstMatches = new System.Windows.Forms.ListView();
            this.btnViewMatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.Location = new System.Drawing.Point(541, 343);
            this.btnCreateMatch.Name = "btnCreateMatch";
            this.btnCreateMatch.Size = new System.Drawing.Size(75, 23);
            this.btnCreateMatch.TabIndex = 0;
            this.btnCreateMatch.Text = "Criar Partida";
            this.btnCreateMatch.UseVisualStyleBackColor = true;
            this.btnCreateMatch.Click += new System.EventHandler(this.btnCreateMatch_Click);
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataSource = typeof(CartagenaBuenaventura.Classes.Match);
            // 
            // btnRefreshListMatches
            // 
            this.btnRefreshListMatches.Location = new System.Drawing.Point(244, 267);
            this.btnRefreshListMatches.Name = "btnRefreshListMatches";
            this.btnRefreshListMatches.Size = new System.Drawing.Size(150, 23);
            this.btnRefreshListMatches.TabIndex = 2;
            this.btnRefreshListMatches.Text = "Atualizar Lista de Partidas";
            this.btnRefreshListMatches.UseVisualStyleBackColor = true;
            this.btnRefreshListMatches.Click += new System.EventHandler(this.btnRefreshListMatches_Click);
            // 
            // lstMatches
            // 
            this.lstMatches.HideSelection = false;
            this.lstMatches.Location = new System.Drawing.Point(60, 49);
            this.lstMatches.Name = "lstMatches";
            this.lstMatches.Size = new System.Drawing.Size(620, 196);
            this.lstMatches.TabIndex = 3;
            this.lstMatches.UseCompatibleStateImageBehavior = false;
            // 
            // btnViewMatch
            // 
            this.btnViewMatch.Location = new System.Drawing.Point(154, 343);
            this.btnViewMatch.Name = "btnViewMatch";
            this.btnViewMatch.Size = new System.Drawing.Size(138, 23);
            this.btnViewMatch.TabIndex = 4;
            this.btnViewMatch.Text = "Visualizar Partida";
            this.btnViewMatch.UseVisualStyleBackColor = true;
            this.btnViewMatch.Click += new System.EventHandler(this.btnViewMatch_Click);
            // 
            // Matches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 739);
            this.Controls.Add(this.btnViewMatch);
            this.Controls.Add(this.lstMatches);
            this.Controls.Add(this.btnRefreshListMatches);
            this.Controls.Add(this.btnCreateMatch);
            this.Name = "Matches";
            this.Text = "Matches";
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource matchBindingSource;
        private System.Windows.Forms.Button btnCreateMatch;
        private System.Windows.Forms.Button btnRefreshListMatches;
        private System.Windows.Forms.ListView lstMatches;
        private System.Windows.Forms.Button btnViewMatch;
    }
}