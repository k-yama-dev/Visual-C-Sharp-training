using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace form2open
{
    public partial class Form4 : Form
    {
        private string message;

        public Form4(string mess)
        {
            InitializeComponent();
            message = mess;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
