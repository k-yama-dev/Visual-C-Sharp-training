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
            
            valueLeft = inputCheck(input1TextBox.Text,out valueLeft);
            valueRight = inputCheck(input2TextBox.Text, out valueRight);    
           
            //取り込んだ値の計算
            valueAnswer = valueLeft + valueRight;
            //計算結果を出力
            answerTextBox.Text = valueAnswer.ToString();//文字列に変換後代入
        }
        private int inputCheck(string textvalue, out int value)
        {
            if (int.TryParse(textvalue, out value)== true)
            {
                value = int.Parse(textvalue);
            }
            else
            {
                value = 0;
            }
            return value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
