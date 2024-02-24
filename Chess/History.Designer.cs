namespace Chess
{
    partial class History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.historyTitle = new System.Windows.Forms.Label();
            this.gamesHistoryTable = new System.Windows.Forms.DataGridView();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationSeconds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WhitePlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlackPlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WinnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gamesHistoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // historyTitle
            // 
            this.historyTitle.AutoSize = true;
            this.historyTitle.BackColor = System.Drawing.Color.Transparent;
            this.historyTitle.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyTitle.ForeColor = System.Drawing.Color.Moccasin;
            this.historyTitle.Location = new System.Drawing.Point(62, 67);
            this.historyTitle.Name = "historyTitle";
            this.historyTitle.Size = new System.Drawing.Size(252, 49);
            this.historyTitle.TabIndex = 0;
            this.historyTitle.Text = "Games history";
            // 
            // gamesHistoryTable
            // 
            this.gamesHistoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gamesHistoryTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.gamesHistoryTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gamesHistoryTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gamesHistoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gamesHistoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamesHistoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartTime,
            this.EndTime,
            this.DurationSeconds,
            this.WhitePlayerName,
            this.BlackPlayerName,
            this.WinnerName,
            this.Result});
            this.gamesHistoryTable.EnableHeadersVisualStyles = false;
            this.gamesHistoryTable.GridColor = System.Drawing.Color.Moccasin;
            this.gamesHistoryTable.Location = new System.Drawing.Point(71, 235);
            this.gamesHistoryTable.Name = "gamesHistoryTable";
            this.gamesHistoryTable.RowHeadersVisible = false;
            this.gamesHistoryTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gamesHistoryTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gamesHistoryTable.Size = new System.Drawing.Size(868, 174);
            this.gamesHistoryTable.TabIndex = 2;
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "Started";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 91;
            // 
            // EndTime
            // 
            this.EndTime.DataPropertyName = "EndTime";
            this.EndTime.HeaderText = "Ended";
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 77;
            // 
            // DurationSeconds
            // 
            this.DurationSeconds.DataPropertyName = "DurationSeconds";
            this.DurationSeconds.HeaderText = "Duration";
            this.DurationSeconds.Name = "DurationSeconds";
            this.DurationSeconds.ReadOnly = true;
            this.DurationSeconds.Width = 97;
            // 
            // WhitePlayerName
            // 
            this.WhitePlayerName.DataPropertyName = "WhitePlayerName";
            this.WhitePlayerName.HeaderText = "White Player";
            this.WhitePlayerName.Name = "WhitePlayerName";
            this.WhitePlayerName.ReadOnly = true;
            this.WhitePlayerName.Width = 129;
            // 
            // BlackPlayerName
            // 
            this.BlackPlayerName.DataPropertyName = "BlackPlayerName";
            this.BlackPlayerName.HeaderText = "Black Player";
            this.BlackPlayerName.Name = "BlackPlayerName";
            this.BlackPlayerName.ReadOnly = true;
            this.BlackPlayerName.Width = 124;
            // 
            // WinnerName
            // 
            this.WinnerName.DataPropertyName = "WinnerName";
            this.WinnerName.HeaderText = "Winner";
            this.WinnerName.Name = "WinnerName";
            this.WinnerName.ReadOnly = true;
            this.WinnerName.Width = 87;
            // 
            // Result
            // 
            this.Result.DataPropertyName = "Result";
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 79;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.BackgroundImage = global::Chess.Properties.Resources.historyBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 621);
            this.Controls.Add(this.gamesHistoryTable);
            this.Controls.Add(this.historyTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1020, 660);
            this.MinimumSize = new System.Drawing.Size(1020, 660);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gamesHistoryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label historyTitle;
        private System.Windows.Forms.DataGridView gamesHistoryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationSeconds;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhitePlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlackPlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}