namespace AddListBox
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
            for(int i=1; i<=50;i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
