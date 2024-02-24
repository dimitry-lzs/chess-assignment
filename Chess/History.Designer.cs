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
            this.historyTitle = new System.Windows.Forms.Label();
            this.gamesHistoryTable = new System.Windows.Forms.DataGridView();
            this.gameStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whitePlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blackPlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gamesHistoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // historyTitle
            // 
            this.historyTitle.AutoSize = true;
            this.historyTitle.BackColor = System.Drawing.Color.Transparent;
            this.historyTitle.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyTitle.ForeColor = System.Drawing.Color.Moccasin;
            this.historyTitle.Location = new System.Drawing.Point(103, 62);
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
            this.gameStart,
            this.gameEnd,
            this.whitePlayerName,
            this.blackPlayerName,
            this.resultText});
            this.gamesHistoryTable.EnableHeadersVisualStyles = false;
            this.gamesHistoryTable.GridColor = System.Drawing.Color.Moccasin;
            this.gamesHistoryTable.Location = new System.Drawing.Point(112, 237);
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
            this.gamesHistoryTable.Size = new System.Drawing.Size(505, 174);
            this.gamesHistoryTable.TabIndex = 2;
            // 
            // gameStart
            // 
            this.gameStart.HeaderText = "Started";
            this.gameStart.Name = "gameStart";
            this.gameStart.Width = 91;
            // 
            // gameEnd
            // 
            this.gameEnd.HeaderText = "Ended";
            this.gameEnd.Name = "gameEnd";
            this.gameEnd.Width = 77;
            // 
            // whitePlayerName
            // 
            this.whitePlayerName.HeaderText = "White Player";
            this.whitePlayerName.Name = "whitePlayerName";
            this.whitePlayerName.Width = 129;
            // 
            // blackPlayerName
            // 
            this.blackPlayerName.HeaderText = "Black Player";
            this.blackPlayerName.Name = "blackPlayerName";
            this.blackPlayerName.Width = 124;
            // 
            // resultText
            // 
            this.resultText.HeaderText = "Result";
            this.resultText.Name = "resultText";
            this.resultText.Width = 79;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.BackgroundImage = global::Chess.Properties.Resources.historyBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 622);
            this.Controls.Add(this.gamesHistoryTable);
            this.Controls.Add(this.historyTitle);
            this.Name = "History";
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.gamesHistoryTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label historyTitle;
        private System.Windows.Forms.DataGridView gamesHistoryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn whitePlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn blackPlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultText;
    }
}