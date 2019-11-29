using Entity2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Entity2
{
    public partial class Form1 : Form
    {
        private readonly DBContext _db;

        public Form1()
        {
            _db = new DBContext();

            _db.Database.Log = s =>
            {
                System.Diagnostics.Debug.WriteLine(s);
            };

            InitializeComponent();
            InitializeDBData();
        }

        #region 編輯與搜尋

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string name = searchName.Text;
            if (!string.IsNullOrEmpty(name))
            {
                // 請用 LINQ 寫查詢的程式碼
                IEnumerable<Employee> result = null;

                dataGridView1.DataSource = result.ToList();
            }
        }

        // 按下 [新增] 鈕執行此事件處理函式
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string position = txtPosition.Text;
            int.TryParse(txtSalary.Text, out int salary);
            string telephone = txtTel.Text;
            // 請新增一筆 Employee

            Form1_Load(sender, e);
        }

        // 按下 [修改] 鈕執行此事件處理函式
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(empId.Text);
            string name = txtName.Text;
            string position = txtPosition.Text;
            int.TryParse(txtSalary.Text, out int salary);
            string telephone = txtTel.Text;
            
            // 請更改 Employee 資料

            Form1_Load(sender, e);
        }

        // 按 [刪除] 鈕執行此事件處理函式
        private void btnDel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(empId.Text);
            
            // 請刪除 Employee 資料
            
            Form1_Load(sender, e);
        }

        #endregion

        #region 其他

        private void InitializeDBData()
        {
            var hasData = _db.Employee.Any();

            if (!hasData)
            {
                _db.Employee.Add(new Employee { Name = "Bob", Position = "Manager", Salary = 500, Telephone = "02-21284393" });
                _db.Employee.Add(new Employee { Name = "Kevin", Position = "IT", Salary = 600, Telephone = "04-25443993" });
                _db.Employee.Add(new Employee { Name = "Mary", Position = "IT", Salary = 700, Telephone = "05-303948123" });
                _db.Employee.Add(new Employee { Name = "Joe", Position = "Developer", Salary = 900, Telephone = "09-43091234" });
                _db.Employee.Add(new Employee { Name = "Peter", Position = "Developer", Salary = 500, Telephone = "02-30385712" });
                _db.SaveChanges();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            empId.Text = dataGridView1.CurrentRow.Cells["Id"]?.Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells["Name"]?.Value.ToString();
            txtPosition.Text = dataGridView1.CurrentRow.Cells["Position"]?.Value.ToString();
            txtSalary.Text = dataGridView1.CurrentRow.Cells["Salary"]?.Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells["Telephone"]?.Value.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Employee.ToList();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        #endregion
    }
}