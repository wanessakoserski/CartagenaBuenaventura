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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateMatchDialog));
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
            this.lblMatchName.BackColor = System.Drawing.Color.Transparent;
            this.lblMatchName.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchName.ForeColor = System.Drawing.Color.Maroon;
            this.lblMatchName.Location = new System.Drawing.Point(225, 29);
            this.lblMatchName.Name = "lblMatchName";
            this.lblMatchName.Size = new System.Drawing.Size(47, 18);
            this.lblMatchName.TabIndex = 0;
            this.lblMatchName.Text = "Nome";
            // 
            // txtMatchName
            // 
            this.txtMatchName.Location = new System.Drawing.Point(158, 50);
            this.txtMatchName.MaxLength = 20;
            this.txtMatchName.Name = "txtMatchName";
            this.txtMatchName.Size = new System.Drawing.Size(198, 20);
            this.txtMatchName.TabIndex = 1;
            // 
            // lblMatchPassword
            // 
            this.lblMatchPassword.AutoSize = true;
            this.lblMatchPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblMatchPassword.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchPassword.ForeColor = System.Drawing.Color.Maroon;
            this.lblMatchPassword.Location = new System.Drawing.Point(225, 114);
            this.lblMatchPassword.Name = "lblMatchPassword";
            this.lblMatchPassword.Size = new System.Drawing.Size(51, 18);
            this.lblMatchPassword.TabIndex = 2;
            this.lblMatchPassword.Text = "Senha";
            // 
            // txtMatchPassword
            // 
            this.txtMatchPassword.Location = new System.Drawing.Point(158, 135);
            this.txtMatchPassword.MaxLength = 10;
            this.txtMatchPassword.Name = "txtMatchPassword";
            this.txtMatchPassword.PasswordChar = '*';
            this.txtMatchPassword.Size = new System.Drawing.Size(198, 20);
            this.txtMatchPassword.TabIndex = 3;
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCreateMatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateMatch.Font = new System.Drawing.Font("Bauhaus 93", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMatch.ForeColor = System.Drawing.Color.Maroon;
            this.btnCreateMatch.Location = new System.Drawing.Point(245, 272);
            this.btnCreateMatch.Name = "btnCreateMatch";
            this.btnCreateMatch.Size = new System.Drawing.Size(107, 27);
            this.btnCreateMatch.TabIndex = 4;
            this.btnCreateMatch.Text = "Criar";
            this.btnCreateMatch.UseVisualStyleBackColor = false;
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(364, 311);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnCreateMatch);
            this.Controls.Add(this.txtMatchPassword);
            this.Controls.Add(this.lblMatchPassword);
            this.Controls.Add(this.txtMatchName);
            this.Controls.Add(this.lblMatchName);
            this.Name = "CreateMatchDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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