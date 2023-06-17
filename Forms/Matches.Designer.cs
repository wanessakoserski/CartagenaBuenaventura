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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEnterMatch = new System.Windows.Forms.Button();
            this.btnViewMatch = new System.Windows.Forms.Button();
            this.btnRefreshListMatches = new System.Windows.Forms.Button();
            this.btnCreateMatch = new System.Windows.Forms.Button();
            this.gbxListMatches = new System.Windows.Forms.GroupBox();
            this.dgdMatches = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlGoBackHome = new System.Windows.Forms.Panel();
            this.gbxListMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterMatch
            // 
            this.btnEnterMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterMatch.BackColor = System.Drawing.Color.Teal;
            this.btnEnterMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterMatch.Enabled = false;
            this.btnEnterMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterMatch.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterMatch.ForeColor = System.Drawing.Color.LightBlue;
            this.btnEnterMatch.Location = new System.Drawing.Point(881, 445);
            this.btnEnterMatch.Name = "btnEnterMatch";
            this.btnEnterMatch.Size = new System.Drawing.Size(156, 57);
            this.btnEnterMatch.TabIndex = 4;
            this.btnEnterMatch.Text = "Entrar na Partida";
            this.btnEnterMatch.UseVisualStyleBackColor = false;
            this.btnEnterMatch.Click += new System.EventHandler(this.btnEnterMatch_Click);
            this.btnEnterMatch.MouseEnter += new System.EventHandler(this.btnEnterMatch_MouseEnter);
            this.btnEnterMatch.MouseLeave += new System.EventHandler(this.btnEnterMatch_MouseLeave);
            // 
            // btnViewMatch
            // 
            this.btnViewMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewMatch.BackColor = System.Drawing.Color.Teal;
            this.btnViewMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewMatch.Enabled = false;
            this.btnViewMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMatch.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMatch.ForeColor = System.Drawing.Color.LightBlue;
            this.btnViewMatch.Location = new System.Drawing.Point(304, 445);
            this.btnViewMatch.Name = "btnViewMatch";
            this.btnViewMatch.Size = new System.Drawing.Size(156, 57);
            this.btnViewMatch.TabIndex = 4;
            this.btnViewMatch.Text = "Visualizar Partida";
            this.btnViewMatch.UseVisualStyleBackColor = false;
            this.btnViewMatch.Click += new System.EventHandler(this.btnViewMatch_Click);
            this.btnViewMatch.MouseEnter += new System.EventHandler(this.btnViewMatch_MouseEnter);
            this.btnViewMatch.MouseLeave += new System.EventHandler(this.btnViewMatch_MouseLeave);
            // 
            // btnRefreshListMatches
            // 
            this.btnRefreshListMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshListMatches.BackColor = System.Drawing.Color.Teal;
            this.btnRefreshListMatches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshListMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshListMatches.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshListMatches.ForeColor = System.Drawing.Color.LightBlue;
            this.btnRefreshListMatches.Location = new System.Drawing.Point(119, 445);
            this.btnRefreshListMatches.Name = "btnRefreshListMatches";
            this.btnRefreshListMatches.Size = new System.Drawing.Size(156, 57);
            this.btnRefreshListMatches.TabIndex = 2;
            this.btnRefreshListMatches.Text = "Atualizar Lista de Partidas";
            this.btnRefreshListMatches.UseVisualStyleBackColor = false;
            this.btnRefreshListMatches.Click += new System.EventHandler(this.btnRefreshListMatches_Click);
            this.btnRefreshListMatches.MouseEnter += new System.EventHandler(this.btnRefreshListMatches_MouseEnter);
            this.btnRefreshListMatches.MouseLeave += new System.EventHandler(this.btnRefreshListMatches_MouseLeave);
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateMatch.BackColor = System.Drawing.Color.Teal;
            this.btnCreateMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMatch.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMatch.ForeColor = System.Drawing.Color.LightBlue;
            this.btnCreateMatch.Location = new System.Drawing.Point(695, 445);
            this.btnCreateMatch.Name = "btnCreateMatch";
            this.btnCreateMatch.Size = new System.Drawing.Size(156, 57);
            this.btnCreateMatch.TabIndex = 0;
            this.btnCreateMatch.Text = "Criar Partida";
            this.btnCreateMatch.UseVisualStyleBackColor = false;
            this.btnCreateMatch.Click += new System.EventHandler(this.btnCreateMatch_Click);
            this.btnCreateMatch.MouseEnter += new System.EventHandler(this.btnCreateMatch_MouseEnter);
            this.btnCreateMatch.MouseLeave += new System.EventHandler(this.btnCreateMatch_MouseLeave);
            // 
            // gbxListMatches
            // 
            this.gbxListMatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxListMatches.BackColor = System.Drawing.Color.Transparent;
            this.gbxListMatches.Controls.Add(this.dgdMatches);
            this.gbxListMatches.ForeColor = System.Drawing.Color.White;
            this.gbxListMatches.Location = new System.Drawing.Point(119, 54);
            this.gbxListMatches.Name = "gbxListMatches";
            this.gbxListMatches.Size = new System.Drawing.Size(918, 247);
            this.gbxListMatches.TabIndex = 6;
            this.gbxListMatches.TabStop = false;
            this.gbxListMatches.Text = "Lista de Partidas";
            // 
            // dgdMatches
            // 
            this.dgdMatches.AllowUserToAddRows = false;
            this.dgdMatches.AllowUserToDeleteRows = false;
            this.dgdMatches.AllowUserToResizeColumns = false;
            this.dgdMatches.AllowUserToResizeRows = false;
            this.dgdMatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdMatches.BackgroundColor = System.Drawing.Color.Azure;
            this.dgdMatches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdMatches.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgdMatches.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdMatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdMatches.ColumnHeadersVisible = false;
            this.dgdMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.date,
            this.status});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdMatches.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgdMatches.GridColor = System.Drawing.Color.Azure;
            this.dgdMatches.Location = new System.Drawing.Point(6, 19);
            this.dgdMatches.MultiSelect = false;
            this.dgdMatches.Name = "dgdMatches";
            this.dgdMatches.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdMatches.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgdMatches.RowHeadersVisible = false;
            this.dgdMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdMatches.Size = new System.Drawing.Size(906, 222);
            this.dgdMatches.TabIndex = 7;
            this.dgdMatches.SelectionChanged += new System.EventHandler(this.dgdMatches_SelectionChanged);
            // 
            // id
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.FillWeight = 37.22156F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.DefaultCellStyle = dataGridViewCellStyle3;
            this.name.FillWeight = 182.7412F;
            this.name.HeaderText = "Nome da Partida";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // date
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.DefaultCellStyle = dataGridViewCellStyle4;
            this.date.FillWeight = 69.16135F;
            this.date.HeaderText = "Data de Criação";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // status
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.DefaultCellStyle = dataGridViewCellStyle5;
            this.status.FillWeight = 110.8761F;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // pnlGoBackHome
            // 
            this.pnlGoBackHome.BackColor = System.Drawing.Color.Transparent;
            this.pnlGoBackHome.BackgroundImage = global::CartagenaBuenaventura.Properties.Resources.go_back_arrow;
            this.pnlGoBackHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGoBackHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlGoBackHome.Location = new System.Drawing.Point(20, 20);
            this.pnlGoBackHome.Name = "pnlGoBackHome";
            this.pnlGoBackHome.Size = new System.Drawing.Size(46, 37);
            this.pnlGoBackHome.TabIndex = 7;
            this.pnlGoBackHome.Click += new System.EventHandler(this.pnlGoBackHome_Click);
            this.pnlGoBackHome.MouseEnter += new System.EventHandler(this.pnlGoBackHome_MouseEnter);
            this.pnlGoBackHome.MouseLeave += new System.EventHandler(this.pnlGoBackHome_MouseLeave);
            // 
            // Matches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CartagenaBuenaventura.Properties.Resources.fleet_fo_ships;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1154, 535);
            this.Controls.Add(this.pnlGoBackHome);
            this.Controls.Add(this.gbxListMatches);
            this.Controls.Add(this.btnEnterMatch);
            this.Controls.Add(this.btnViewMatch);
            this.Controls.Add(this.btnRefreshListMatches);
            this.Controls.Add(this.btnCreateMatch);
            this.Name = "Matches";
            this.Text = "Matches";
            this.gbxListMatches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdMatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateMatch;
        private System.Windows.Forms.Button btnRefreshListMatches;
        private System.Windows.Forms.Button btnEnterMatch;
        private System.Windows.Forms.Button btnViewMatch;
        private System.Windows.Forms.GroupBox gbxListMatches;
        private System.Windows.Forms.DataGridView dgdMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Panel pnlGoBackHome;
    }
}