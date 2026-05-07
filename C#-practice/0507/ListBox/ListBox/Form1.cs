namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                // 数値の i を文字列に変換してリストボックスに追加！
                listBox1.Items.Add(i.ToString());
            }

        }
    }
}
