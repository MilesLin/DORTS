using Dapper;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string dbPath = @".\dorts.sqlite";
        private const string cnStr = "data source=" + dbPath;

        public Form1()
        {
            InitializeComponent();
            InitDB();
            UpdateGridView();
            AddSex.SelectedIndex = (int)Sex.男;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int id = int.Parse(AddIdTextBox.Text);
            string name = AddNameTextBox.Text;
            Sex sex = (Sex)Enum.Parse(typeof(Sex), AddSex.Text);

            #region 新增資料

            var cn = new SQLiteConnection(cnStr);
            cn.Execute($"INSERT INTO Employee (Id, EmpName, Sex) VALUES({id}, '{name}', {(int)sex})");

            #endregion 新增資料

            UpdateGridView();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(EditIdTextbox.Text);
            string name = EditNameTextbox.Text;
            Sex sex = (Sex)Enum.Parse(typeof(Sex), EditSex.Text);

            #region 編輯資料

            var cn = new SQLiteConnection(cnStr);
            cn.Execute($"UPDATE Employee SET EmpName = '{name}', Sex = {(int)sex} WHERE Id = {id}");

            #endregion 編輯資料

            UpdateGridView();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(EditIdTextbox.Text);

            #region 刪除資料

            var cn = new SQLiteConnection(cnStr);
            cn.Execute($"DELETE FROM Employee WHERE Id = {id}");

            #endregion 刪除資料

            EditIdTextbox.Text = "";
            EditNameTextbox.Text = "";
            EditSex.SelectedIndex = (int)Sex.男;

            UpdateGridView();
        }

        /// <summary>
        /// 更新資料列表 (update grid view)
        /// </summary>
        private void UpdateGridView()
        {
            #region 取得資料

            var cn = new SQLiteConnection(cnStr);
            DataTable myDataTable = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select Id, EmpName, CASE WHEN Sex = 0 THEN '男' ELSE '女' END AS Sex from Employee", cn);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            myDataTable = ds.Tables[0];

            #endregion 取得資料

            dataGridView1.DataSource = myDataTable;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            EditIdTextbox.Text = dataGridView1.CurrentRow.Cells["Id"]?.Value.ToString();
            EditNameTextbox.Text = dataGridView1.CurrentRow.Cells["EmpName"]?.Value.ToString();
            int sexIndex = (int)(Sex)Enum.Parse(typeof(Sex), dataGridView1.CurrentRow.Cells["Sex"]?.Value.ToString());
            EditSex.SelectedIndex = sexIndex;
        }

        /// <summary>
        /// SQLite 資料庫初始化
        /// </summary>
        private void InitDB()
        {
            var cn = new SQLiteConnection(cnStr);
            string createTablIfNotExists = @"
                create table if not exists Employee (
                    Id                  INTEGER     PRIMARY KEY     NOT NULL,
                    EmpName             NVARCHAR(255)                    NOT NULL,
                    Sex                 INTEGER
                );";

            cn.Execute(createTablIfNotExists);

            SQLiteDataAdapter daCheck = new SQLiteDataAdapter("select Id, EmpName, Sex from Employee", cn);
            DataSet dsCheck = new DataSet();
            dsCheck.Clear();
            daCheck.Fill(dsCheck);
            if (dsCheck.Tables[0].Rows.Count < 1)
            {
                cn.Execute("INSERT INTO Employee (Id, EmpName, Sex) VALUES(1, 'Joe', 0)");
                cn.Execute("INSERT INTO Employee (Id, EmpName, Sex) VALUES(2, 'Bob', 0)");
            }
        }
    }
}