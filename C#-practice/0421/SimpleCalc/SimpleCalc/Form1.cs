namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            //変数の宣言
            int valueLeft;
            int valueRight;
            int valueAnswer;　//それぞれの型宣言
            //値の取り込み
            valueLeft = int.Parse(input1TextBox.Text);
            valueRight = int.Parse(input2TextBox.Text);　//型変換後代入
            //取り込んだ値の計算
            valueAnswer = valueLeft + valueRight;
            //計算結果を出力
            answerTextBox.Text = valueAnswer.ToString();//文字列に変換後代入
        }
    }
}
