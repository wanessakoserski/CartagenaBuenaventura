﻿namespace CartagenaBuenaventura
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
            this.btnPlayCartagena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayCartagena
            // 
            this.btnPlayCartagena.Location = new System.Drawing.Point(286, 299);
            this.btnPlayCartagena.Name = "btnPlayCartagena";
            this.btnPlayCartagena.Size = new System.Drawing.Size(120, 23);
            this.btnPlayCartagena.TabIndex = 0;
            this.btnPlayCartagena.Text = "Jogar Cartagena";
            this.btnPlayCartagena.UseVisualStyleBackColor = true;
            this.btnPlayCartagena.Click += new System.EventHandler(this.btnPlayCartagena_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 456);
            this.Controls.Add(this.btnPlayCartagena);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayCartagena;
    }
}