using Dapper;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Service;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly EmployeeService empSvc;

        public Form1()
        {
            empSvc = new EmployeeService();
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

            empSvc.Add(new Employee
            {
                Id = id,
                EmpName = name,
                Sex = sex
            });

            UpdateGridView();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(EditIdTextbox.Text);
            string name = EditNameTextbox.Text;
            Sex sex = (Sex)Enum.Parse(typeof(Sex), EditSex.Text);

            empSvc.Edit(new Employee
            {
                Id = id,
                EmpName = name,
                Sex = sex
            });

            UpdateGridView();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(EditIdTextbox.Text);

            EditIdTextbox.Text = "";
            EditNameTextbox.Text = "";
            EditSex.SelectedIndex = (int)Sex.男;

            empSvc.Delete(id);

            UpdateGridView();
        }

        /// <summary>
        /// 更新資料列表 (update grid view)
        /// </summary>
        private void UpdateGridView()
        {
            DataTable myDataTable = empSvc.QueryAll();

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
            string dbPath = @".\dorts.sqlite";
            string cnStr = "data source=" + dbPath;
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