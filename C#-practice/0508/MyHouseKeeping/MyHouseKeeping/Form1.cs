using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace MyHouseKeeping
{
    public partial class FormView : Form
    {
        public string ConnectionString = "Server=127.0.0.1;Port=3306;Database=mydb;User ID=root;Password=mysql;";
        public FormView()
        {
            InitializeComponent();
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            LoadData();
            //とりあえずのカテゴリーデータ
            //categoryDataSet1.CategoryTable.AddCategoryTableRow("給料", "入金");
            //categoryDataSet1.CategoryTable.AddCategoryTableRow("食費", "出金");
            string sqlStr = "Select * from categoryTable";
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sqlStr, conn))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataRow drow;
                        while (dr.Read())
                        {
                            drow = categoryDataSet1.CategoryTable.NewRow();
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                drow[i] = dr[i];
                            }
                            categoryDataSet1.CategoryTable.Rows.Add(drow);
                        }
                    }
                }
            }

        }

        private void LoadData()
        {
            string sqlStr = "Select * from moneyTable";
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                moneyDataSet.MoneyTable.Clear();
                using (MySqlCommand cmd = new MySqlCommand(sqlStr, conn))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        DataRow drow;
                        while (dr.Read())
                        {
                            drow = moneyDataSet.MoneyTable.NewRow();
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                drow[i] = dr[i];
                            }
                            moneyDataSet.MoneyTable.Rows.Add(drow);
                        }
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }
        private void AddData()
        {
            //カテゴリーデータをコンボボックスに渡す
            ItemForm frmItem = new ItemForm(categoryDataSet1);
            DialogResult drRet = frmItem.ShowDialog();
            if (drRet == DialogResult.OK)
            {
                DateTime dt = frmItem.monCalendar.SelectionRange.Start;
                string br = frmItem.cmbCategory.Text;
                string hm = frmItem.txtItem.Text;
                int kg = int.Parse(frmItem.mtxtMoney.Text);
                string bk = frmItem.txtRemarks.Text;
                SaveData(dt, br, hm, kg, bk);
                //再表示する
                LoadData();
            }
        }
        private void SaveData(DateTime dt, string br, string hm, int kg, string bk)
        {
            string strSql = "INSERT INTO moneyTable (`日付`,`分類`,`品名`,`金額`,`備考`)  VALUES (@日付, @分類, @品名,@金額,@備考)";
            //string strSql = "INSERT INTO  moneyTable VALUES (null,@日付, @分類, @品名,@金額,@備考)";
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try {

                    MySqlCommand cmd = new MySqlCommand(strSql, conn);
                    conn.Open();
                    cmd.CommandType = CommandType.Text;

                    //strSQLの@の部分にパラメータを展開する
                    cmd.Parameters.Clear();
                    MySqlParameter param = cmd.CreateParameter();
                    param = cmd.CreateParameter();
                    param.ParameterName = "@日付";
                    param.MySqlDbType = MySqlDbType.Date;
                    param.Direction = ParameterDirection.Input;
                    param.Value = dt;
                    cmd.Parameters.Add(param);

                    param = cmd.CreateParameter();
                    param.ParameterName = "@分類";
                    param.MySqlDbType = MySqlDbType.VarChar;
                    param.Size = 30;
                    param.Direction = ParameterDirection.Input;
                    param.Value = br;
                    cmd.Parameters.Add(param);

                    param = cmd.CreateParameter();
                    param.ParameterName = "@品名";
                    param.MySqlDbType = MySqlDbType.VarChar;
                    param.Size = 30;
                    param.Direction = ParameterDirection.Input;
                    param.Value = hm;
                    cmd.Parameters.Add(param);

                    param = cmd.CreateParameter();
                    param.ParameterName = "@金額";
                    param.MySqlDbType = MySqlDbType.Int32;
                    param.Direction = ParameterDirection.Input;
                    param.Value = kg;
                    cmd.Parameters.Add(param);

                    param = cmd.CreateParameter();
                    param.ParameterName = "@備考";
                    param.MySqlDbType = MySqlDbType.VarChar;
                    param.Direction = ParameterDirection.Input;
                    param.Size = 30;
                    param.Value = bk;
                    cmd.Parameters.Add(param);

                    //リターンのないSQLを実行する
                    cmd.ExecuteNonQuery();
                } catch(Exception ex) {
                    MessageBox.Show("書き込み失敗");
                }
            }

        }
    }
}
