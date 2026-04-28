using Csv;　//ライブラリを使うのに必要
using System.Data;　//DataTableを使うのに必要
using System.Text;　//Encordingを使うのに必要

namespace CsvReadWrite
{
    public partial class Form1 : Form
    {
        //内部でデータを保持するテーブルを用意
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        //CSV取得ボタンクリック時の操作
        private void buttonCsvRead_Click(object sender, EventArgs e)
        {
            //ファイルを開くウィンドウでcsvファイルを選択し、OKボタンをクリックしたとき
            if (openFileDialogCsv.ShowDialog() == DialogResult.OK)
            {
                //ファイルを開くウィンドウで選んだcsvのファイル名をテキストボックスに反映
                textBoxInputCsvFileName.Text = openFileDialogCsv.FileName;
                //ファイルの全内容を文字列に読み込みます。日本語が読めるように
                //文字はutf-16でエンコードします。
                string csv = File.ReadAllText(openFileDialogCsv.FileName,Encoding
                 .GetEncoding("utf-16"));
                dataTable.TableName = "CSVTable"; //内部でテーブルを生成します
                dataTable.Columns.Clear();　　　　//内部テーブルのヘッダーを初期化(2聯足で読み込んだ時の対応)
                dataTable.Clear();                //内部テーブルのデータを初期化(2聯足で読み込んだ時の対応)

                //csvからヘッダー部分のデータを取得し、内部のテーブルカラムに設定
                //csvから1行取得し、結果をLine変数に入れる
                foreach (ICsvLine line in CsvReader.ReadFromText(csv))
                {
                    //1行分のデータのヘッダー情報を取り出す
                    foreach (var item in line.Headers)
                    {
                        dataTable.Columns.Add(item);//内部のデータのカラムに設定
                    }
                    break;//2列目以降のデータもカラム名は同じなので、csvの読み込みを終了
                }
                //読み込んだcsvのデータを、内部のテーブルに割り当てる
                //もう一度csvから1行取得し、結果をLine変数に入れる
                foreach (ICsvLine line in CsvReader.ReadFromText(csv))
                {
                    dataTable.Rows.Add(line.Values);//1レコード分をまとめて設定
                }
                dataGridViewCsv.DataSource = dataTable;//表示用のDataGridViewに内部のテーブルを割当
            }
        }

        //csv出力ボタンクリック時の処理
        private void buttonCsvWrite_Click(object sender, EventArgs e)
        {
            //ファイルを保存するウィンドウでcsvファイルを選択し、OKボタンをクリックしたとき
            if (saveFileDialogCsv.ShowDialog() == DialogResult.OK)
            {
                //ファイルを保存するウィンドウで選んだcsvのファイル名をテキストボックスに反映
                textBoxOutputCsvFileName.Text = saveFileDialogCsv.FileName;
                //headerという変数に内部のテーブルカラム名を設定
                string[] header = new string[dataTable.Columns.Count];
                //カラムの数だけループしてカラムのデータを設定
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    header[i] = dataTable.Columns[i].ColumnName;
                }
                //newLineという変数に内部のテーブル表のイメージ(2次元配列)で設定
                string[][] newLine = new string[dataTable.Rows.Count][];
                //データの数分ループして、データを取得
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    newLine[i] = new string[dataTable.Columns.Count];
                    //該当するカラム、列の値を内部のテーブルから、newLineに設定
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        //nullの場合は""としてnewLineに設定
                        newLine[i][j] = (string)dataTable.Rows[i][j] ?? "";
                    }
                }

                //データからcsv形式の文字列を生成します
                string outcsv = CsvWriter.WriteToText(header, newLine);
                //FileNameという名前で、outcsvの値を保持します。っ文字はutf-16でエンコードします。
                File.WriteAllText(saveFileDialogCsv.FileName, outcsv, Encoding.GetEncoding("utf-16"));
             }     
        }
    }
}
