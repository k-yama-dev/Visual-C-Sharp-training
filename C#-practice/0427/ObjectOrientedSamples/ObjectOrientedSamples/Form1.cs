namespace ObjectOrientedSamples
{
    public partial class Form1 : Form
    {
        //windowsフォームの処理やデータのコード

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.Red;
            label1.Text = "こーんにちわーぁ！";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Hide();
            MessageBox.Show("Hello How Low!?","It's like a...",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
