using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EnglishWord
{
    // EnglishWord.csvファイルの入出力クラス
    class EnglishWordIO // 静的クラス
    {
        // EnglishWord.csv中の英語と日本語訳を読み込むメソッド
        public static List<string> Read()
        {
            List<string> list = new List<string>();
            // ファイルがなければそのままリターン
            if (File.Exists(@"Data\EnglishWord.csv") == false)
            {
                return list;
            }

            // contents.csv の読み込み
            try
            {
                using (StreamReader reader = new StreamReader
                    (@"Data\EnglishWord.csv", Encoding.Default))
                {
                    // ファイルを1行ずつ読み出す
                    // List<string>クラスのインスタンスに格納してから呼び出し元に返却
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return list;
            }
        }

        // EnglishWord.csvに英単語と日本語訳を書き込むメソッド
        public static void Write(List<string> list)
        {
            // Dataディレクトリがなければ作成する
            if (Directory.Exists("Data") == false)
            {
                Directory.CreateDirectory("Data");
            }

            // 予告の内容を書き込む
            try
            {
                using (StreamWriter writer = new StreamWriter(@"Data\EnglishWord.csv", false, Encoding.Default))
                {
                    // 引数渡しされたList<string>の要素を1行ずつファイルに書き込む
                    foreach (string s in list)
                    {
                        writer.Write(s);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CSVファイルの特定の行を上書きして保存するメソッド
        public static void OverwriteCsvFileRow(int targetRowIndex, string newData)
        {
            try
            {
                // ファイルが存在しない場合は、ファイルを作成する
                if (File.Exists(@"Data\EnglishWord.csv") == false)
                {
                    File.Create(@"Data\EnglishWord.csv");
                }

                // CSVファイルの全ての行を読み込む
                string[] lines = File.ReadAllLines(@"Data\EnglishWord.csv");

                // 対象の行が存在するか確認
                if (targetRowIndex >= 0 && targetRowIndex < lines.Length)
                {
                    // 対象の行を新しいデータで上書き
                    lines[targetRowIndex] = newData;

                    // ファイルに書き戻す
                    File.WriteAllLines(@"Data\EnglishWord.csv", lines, Encoding.Default);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
