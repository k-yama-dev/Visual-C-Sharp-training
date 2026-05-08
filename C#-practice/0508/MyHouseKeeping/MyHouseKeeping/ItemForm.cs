using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHouseKeeping
{
    public partial class ItemForm : Form
    {
        public ItemForm(CategoryDataSet dsCategory)
        {
            InitializeComponent();
            categoryDataSet.Merge(dsCategory);
            this.Text = "新規";
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
