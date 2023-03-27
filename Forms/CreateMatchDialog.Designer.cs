namespace CartagenaBuenaventura.Forms
{
    partial class CreateMatchDialog
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
            this.lblMatchName = new System.Windows.Forms.Label();
            this.txtMatchName = new System.Windows.Forms.TextBox();
            this.lblMatchPassword = new System.Windows.Forms.Label();
            this.txtMatchPassword = new System.Windows.Forms.TextBox();
            this.btnCreateMatch = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMatchName
            // 
            this.lblMatchName.AutoSize = true;
            this.lblMatchName.Location = new System.Drawing.Point(16, 46);
            this.lblMatchName.Name = "lblMatchName";
            this.lblMatchName.Size = new System.Drawing.Size(35, 13);
            this.lblMatchName.TabIndex = 0;
            this.lblMatchName.Text = "Nome";
            // 
            // txtMatchName
            // 
            this.txtMatchName.Location = new System.Drawing.Point(57, 43);
            this.txtMatchName.MaxLength = 20;
            this.txtMatchName.Name = "txtMatchName";
            this.txtMatchName.Size = new System.Drawing.Size(198, 20);
            this.txtMatchName.TabIndex = 1;
            // 
            // lblMatchPassword
            // 
            this.lblMatchPassword.AutoSize = true;
            this.lblMatchPassword.Location = new System.Drawing.Point(16, 92);
            this.lblMatchPassword.Name = "lblMatchPassword";
            this.lblMatchPassword.Size = new System.Drawing.Size(38, 13);
            this.lblMatchPassword.TabIndex = 2;
            this.lblMatchPassword.Text = "Senha";
            // 
            // txtMatchPassword
            // 
            this.txtMatchPassword.Location = new System.Drawing.Point(57, 89);
            this.txtMatchPassword.MaxLength = 10;
            this.txtMatchPassword.Name = "txtMatchPassword";
            this.txtMatchPassword.PasswordChar = '*';
            this.txtMatchPassword.Size = new System.Drawing.Size(198, 20);
            this.txtMatchPassword.TabIndex = 3;
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.Location = new System.Drawing.Point(57, 222);
            this.btnCreateMatch.Name = "btnCreateMatch";
            this.btnCreateMatch.Size = new System.Drawing.Size(75, 23);
            this.btnCreateMatch.TabIndex = 4;
            this.btnCreateMatch.Text = "Criar";
            this.btnCreateMatch.UseVisualStyleBackColor = true;
            this.btnCreateMatch.Click += new System.EventHandler(this.btnCreateMatch_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(57, 142);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 5;
            // 
            // CreateMatchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 289);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnCreateMatch);
            this.Controls.Add(this.txtMatchPassword);
            this.Controls.Add(this.lblMatchPassword);
            this.Controls.Add(this.txtMatchName);
            this.Controls.Add(this.lblMatchName);
            this.Name = "CreateMatchDialog";
            this.Text = "CreateMatchDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatchName;
        private System.Windows.Forms.TextBox txtMatchName;
        private System.Windows.Forms.Label lblMatchPassword;
        private System.Windows.Forms.TextBox txtMatchPassword;
        private System.Windows.Forms.Button btnCreateMatch;
        private System.Windows.Forms.Label lblWarning;
    }
}