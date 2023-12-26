using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EnglishWord
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<string> wordlist = EnglishWordIO.Read();

            labelWord.Text = wordlist[0].Split(',')[0]; // EnglishWord.csvの先頭の英単語を表示
        }

        private void buttonGood_Click(object sender, EventArgs e)
        {
            // forループを回して各行にたいして上書きを行う
            List<string> wordlist = EnglishWordIO.Read();
            string[] word = wordlist[0].Split(',');
            word[2] = "○";
            word[3] = Today();
            string result = string.Join(",", word);
            EnglishWordIO.OverwriteCsvFileRow(0, result);
        }
        
        // 今日の日付を string 型で取得するメソッド
        private string Today()
        {
            DateTime today = DateTime.Today;
            string year = today.Year.ToString();
            string month = today.Month.ToString();
            string day = today.Day.ToString();
            return year + "/" + month + "/" + day;
        }

        
    }
}
