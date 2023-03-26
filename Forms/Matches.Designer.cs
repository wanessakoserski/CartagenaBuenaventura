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
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.Location = new System.Drawing.Point(620, 338);
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
            // Matches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 581);
            this.Controls.Add(this.btnCreateMatch);
            this.Name = "Matches";
            this.Text = "Matches";
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource matchBindingSource;
        private System.Windows.Forms.Button btnCreateMatch;
    }
}