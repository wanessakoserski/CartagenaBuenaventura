namespace CartagenaBuenaventura.Forms
{
    partial class EnterMatchDialog
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblMatchPassword = new System.Windows.Forms.Label();
            this.txtMatchPassword = new System.Windows.Forms.TextBox();
            this.btnMatchEnter = new System.Windows.Forms.Button();
            this.lblWarnig = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(13, 47);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(91, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Nome do Jogador";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(111, 47);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(225, 20);
            this.txtPlayerName.TabIndex = 1;
            // 
            // lblMatchPassword
            // 
            this.lblMatchPassword.AutoSize = true;
            this.lblMatchPassword.Location = new System.Drawing.Point(16, 86);
            this.lblMatchPassword.Name = "lblMatchPassword";
            this.lblMatchPassword.Size = new System.Drawing.Size(89, 13);
            this.lblMatchPassword.TabIndex = 2;
            this.lblMatchPassword.Text = "Senha da Partida";
            // 
            // txtMatchPassword
            // 
            this.txtMatchPassword.Location = new System.Drawing.Point(111, 86);
            this.txtMatchPassword.Name = "txtMatchPassword";
            this.txtMatchPassword.PasswordChar = '*';
            this.txtMatchPassword.Size = new System.Drawing.Size(225, 20);
            this.txtMatchPassword.TabIndex = 3;
            // 
            // btnMatchEnter
            // 
            this.btnMatchEnter.Location = new System.Drawing.Point(19, 222);
            this.btnMatchEnter.Name = "btnMatchEnter";
            this.btnMatchEnter.Size = new System.Drawing.Size(75, 23);
            this.btnMatchEnter.TabIndex = 4;
            this.btnMatchEnter.Text = "Entrar";
            this.btnMatchEnter.UseVisualStyleBackColor = true;
            this.btnMatchEnter.Click += new System.EventHandler(this.btnMatchEnter_Click);
            // 
            // lblWarnig
            // 
            this.lblWarnig.AutoSize = true;
            this.lblWarnig.ForeColor = System.Drawing.Color.Red;
            this.lblWarnig.Location = new System.Drawing.Point(19, 161);
            this.lblWarnig.Name = "lblWarnig";
            this.lblWarnig.Size = new System.Drawing.Size(0, 13);
            this.lblWarnig.TabIndex = 5;
            // 
            // EnterMatchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 317);
            this.Controls.Add(this.lblWarnig);
            this.Controls.Add(this.btnMatchEnter);
            this.Controls.Add(this.txtMatchPassword);
            this.Controls.Add(this.lblMatchPassword);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "EnterMatchDialog";
            this.Text = "EnterMatchDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblMatchPassword;
        private System.Windows.Forms.TextBox txtMatchPassword;
        private System.Windows.Forms.Button btnMatchEnter;
        private System.Windows.Forms.Label lblWarnig;
    }
}