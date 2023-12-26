using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWord
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> Wordlist = EnglishWordIO.Read();

            dataGridView1.Columns[3].ReadOnly = false; // 暗記列を編集可能にする
            dataGridView1.Columns[4].ReadOnly = false; // 最後に学習した日付列を編集可能にする

            // カンマ(,)があればカンマで分割してDataGridViewに追加
            foreach(string s in Wordlist)
            {
                if (s.IndexOf(',') != -1)
                {
                    string[] c = s.Split(',');
                    dataGridView1.Rows.Add("削除", c[0], c[1], c[2], c[3]);
                }
            }

            dataGridView1.Columns[3].ReadOnly = true; // 暗記列を編集不可能にする
            dataGridView1.Columns[4].ReadOnly = true; // 最後に学習した日付列を編集不可能にする
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            List<string> wordList = new List<string>();

            // 各列の値をカンマ区切りで連結しListに追加
            for(int i = 0; i < count - 1; i++)
            {
                string c1 = (string)dataGridView1[1, i].Value; // 英単語
                string c2 = (string)dataGridView1[2, i].Value; // 日本語
                string c3 = (string)dataGridView1[3, i].Value; // 暗記
                string c4 = (string)dataGridView1[4, i].Value; // 最後に勉強した日付
                wordList.Add(c1 + ',' + c2 + ',' + c3 + ',' + c4 + Environment.NewLine);
            }

            // DataGridViewの内容をファイルに保存
            EnglishWordIO.Write(wordList);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 削除ボタンの確認
            if (e.ColumnIndex ==
                dataGridView1.Columns["Delete"].Index)
            {
                if (DialogResult.Yes == MessageBox.Show("本当に削除してもよろしいですか",
                    "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    // 削除
                    try
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "エラー",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
