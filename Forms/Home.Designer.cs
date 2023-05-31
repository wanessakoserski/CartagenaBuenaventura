namespace CartagenaBuenaventura
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnPlayCartagena = new CartagenaBuenaventura.Classes.RoundButton();
            this.btnExit = new CartagenaBuenaventura.Classes.RoundButton();
            this.btnHowToPlay = new CartagenaBuenaventura.Classes.RoundButton();
            this.Title = new System.Windows.Forms.Label();
            this.Caption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayCartagena
            // 
            this.btnPlayCartagena.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnPlayCartagena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayCartagena.AutoEllipsis = true;
            this.btnPlayCartagena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(145)))), ((int)(((byte)(202)))));
            this.btnPlayCartagena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayCartagena.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayCartagena.ForeColor = System.Drawing.Color.White;
            this.btnPlayCartagena.Location = new System.Drawing.Point(336, 416);
            this.btnPlayCartagena.Name = "btnPlayCartagena";
            this.btnPlayCartagena.Size = new System.Drawing.Size(109, 23);
            this.btnPlayCartagena.TabIndex = 0;
            this.btnPlayCartagena.Text = "Jogar Cartagena";
            this.btnPlayCartagena.UseVisualStyleBackColor = false;
            this.btnPlayCartagena.Click += new System.EventHandler(this.btnPlayCartagena_Click);
            this.btnPlayCartagena.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnPlayCartagena.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(145)))), ((int)(((byte)(202)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.btnExit.FlatAppearance.BorderSize = 40;
            this.btnExit.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(336, 495);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnHowToPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHowToPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(145)))), ((int)(((byte)(202)))));
            this.btnHowToPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHowToPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.btnHowToPlay.FlatAppearance.BorderSize = 40;
            this.btnHowToPlay.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowToPlay.ForeColor = System.Drawing.Color.White;
            this.btnHowToPlay.Location = new System.Drawing.Point(336, 455);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(109, 23);
            this.btnHowToPlay.TabIndex = 2;
            this.btnHowToPlay.Text = "Como funciona";
            this.btnHowToPlay.UseVisualStyleBackColor = false;
            this.btnHowToPlay.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnHowToPlay.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // Title
            // 
            this.Title.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Harlow Solid Italic", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(106)))), ((int)(((byte)(157)))));
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Location = new System.Drawing.Point(201, 37);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(438, 121);
            this.Title.TabIndex = 3;
            this.Title.Text = "Cartagena";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Caption
            // 
            this.Caption.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.Caption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Caption.AutoSize = true;
            this.Caption.BackColor = System.Drawing.Color.Transparent;
            this.Caption.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.Caption.Location = new System.Drawing.Point(229, 132);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(378, 40);
            this.Caption.TabIndex = 4;
            this.Caption.Text = "Buenaventura entrou no jogo";
            this.Caption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 569);
            this.Controls.Add(this.Caption);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayCartagena);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Caption;
        private Classes.RoundButton btnPlayCartagena;
        private Classes.RoundButton btnExit;
        private Classes.RoundButton btnHowToPlay;
    }
}