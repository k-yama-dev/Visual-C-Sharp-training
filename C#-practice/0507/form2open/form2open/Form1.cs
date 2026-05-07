namespace form2open
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2のインスタンス（実体）を作る
            Form2 form2 = new Form2();

            // Form2を表示する
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = (string)this.textForm4.Text;
            Form4 form4 = new Form4(a);
            form4.ShowDialog();
            
        }
    }
}
