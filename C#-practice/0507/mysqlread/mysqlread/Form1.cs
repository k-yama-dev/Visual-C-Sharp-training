using MySqlConnector;
namespace mysqlread
{
    public partial class Form1 : Form
    {
        public string sql = " select id,title,price,author from books ";
        public string ConnectionString =
            "Server=127.0.0.1;"
                + "Port=3306;"
                + "Database=sample_db;"
                + "User ID=root;"
                + "Password=mysql;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear(); // 前に作った「見出し」を一旦消す！
            listView1.View = View.Details;

            listView1.Columns.Add("id");
            listView1.Columns.Add("title");
            listView1.Columns.Add("price");
            listView1.Columns.Add("author");
            listView1.Columns[0].Width = 100;
            listView1.Columns[1].Width = 300;
            listView1.Columns[2].Width = 200;
            listView1.Columns[3].Width = 200;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem();
                                item.Text = reader.GetInt32(0).ToString();
                                item.SubItems.Add(reader.GetString(1).ToString());
                                item.SubItems.Add(reader.GetInt32(2).ToString());
                                item.SubItems.Add(reader.GetString(3).ToString());
                                listView1.Items.Add(item);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
