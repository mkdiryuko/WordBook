
namespace EnglishWord
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EnglishWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JapaneseWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memorize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalStudyDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.EnglishWord,
            this.JapaneseWord,
            this.Memorize,
            this.FinalStudyDay});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(264, 168);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(110, 31);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(408, 168);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(114, 31);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "削除";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "削除";
            this.Delete.Width = 125;
            // 
            // EnglishWord
            // 
            this.EnglishWord.HeaderText = "英単語";
            this.EnglishWord.MinimumWidth = 6;
            this.EnglishWord.Name = "EnglishWord";
            this.EnglishWord.Width = 150;
            // 
            // JapaneseWord
            // 
            this.JapaneseWord.HeaderText = "日本語";
            this.JapaneseWord.MinimumWidth = 6;
            this.JapaneseWord.Name = "JapaneseWord";
            this.JapaneseWord.Width = 150;
            // 
            // Memorize
            // 
            this.Memorize.HeaderText = "暗記";
            this.Memorize.MinimumWidth = 6;
            this.Memorize.Name = "Memorize";
            this.Memorize.Width = 125;
            // 
            // FinalStudyDay
            // 
            this.FinalStudyDay.HeaderText = "最後に勉強した日";
            this.FinalStudyDay.MinimumWidth = 6;
            this.FinalStudyDay.Name = "FinalStudyDay";
            this.FinalStudyDay.Width = 200;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 211);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "英単語入力";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnglishWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn JapaneseWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memorize;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalStudyDay;
    }
}