namespace ClassSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAnimalInstanceCreate_Click(object sender, EventArgs e)
        {
            Animal cat = new Animal();//catという名前のインスタンス生成
            Animal dog = new Animal();//dogという名前のインスタンス生成

            //catインスタンスに具体的な値を設定
            cat.name = "Cat ネコ";
            cat.color = "White ホワイト";
            //catインスタンスの値をtextBoxに表示
            textBoxName1.Text = cat.name;
            texBoxtColor1.Text = cat.color;
            textBoxSing1.Text = cat.Sing();

            //dogインスタンスに具体的な値を設定
            dog.name = "Dog イヌ";
            dog.color = "Brown ブラウン";
            //dogインスタンスの値をtextBoxに表示
            textBoxName2.Text = dog.name;
            textBoxColor2.Text = dog.color;
            textBoxSing2.Text = dog.Sing();
        }
    }
}
