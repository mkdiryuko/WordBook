
namespace EnglishWord
{
    partial class Form3
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
            this.labelWord = new System.Windows.Forms.Label();
            this.buttonGood = new System.Windows.Forms.Button();
            this.buttonBad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelWord.Location = new System.Drawing.Point(149, 65);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(73, 24);
            this.labelWord.TabIndex = 0;
            this.labelWord.Text = "label1";
            // 
            // buttonGood
            // 
            this.buttonGood.BackColor = System.Drawing.Color.White;
            this.buttonGood.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonGood.ForeColor = System.Drawing.Color.Red;
            this.buttonGood.Location = new System.Drawing.Point(76, 138);
            this.buttonGood.Name = "buttonGood";
            this.buttonGood.Size = new System.Drawing.Size(75, 35);
            this.buttonGood.TabIndex = 1;
            this.buttonGood.Text = "○";
            this.buttonGood.UseVisualStyleBackColor = false;
            this.buttonGood.Click += new System.EventHandler(this.buttonGood_Click);
            // 
            // buttonBad
            // 
            this.buttonBad.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBad.Location = new System.Drawing.Point(224, 138);
            this.buttonBad.Name = "buttonBad";
            this.buttonBad.Size = new System.Drawing.Size(75, 35);
            this.buttonBad.TabIndex = 2;
            this.buttonBad.Text = "×";
            this.buttonBad.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(383, 236);
            this.Controls.Add(this.buttonBad);
            this.Controls.Add(this.buttonGood);
            this.Controls.Add(this.labelWord);
            this.Name = "Form3";
            this.Text = "暗記モード";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Button buttonGood;
        private System.Windows.Forms.Button buttonBad;
    }
}