using Dapper;
using System.Data;
using System.Data.SQLite;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Service
{
    public class EmployeeService
    {
        private const string dbPath = @".\dorts.sqlite";
        private const string cnStr = "data source=" + dbPath;
        private readonly SQLiteConnection cn;

        public EmployeeService()
        {
            cn = new SQLiteConnection(cnStr);
        }

        public DataTable QueryAll()
        {
            DataTable myDataTable = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select Id, EmpName, CASE WHEN Sex = 0 THEN '男' ELSE '女' END AS Sex from Employee", cn);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            myDataTable = ds.Tables[0];

            return myDataTable;
        }

        public void Add(Employee employee)
        {
            cn.Execute($"INSERT INTO Employee (Id, EmpName, Sex) VALUES({employee.Id}, '{employee.EmpName}', {(int)employee.Sex})");
        }

        public void Edit(Employee employee)
        {
            cn.Execute($"UPDATE Employee SET EmpName = '{employee.EmpName}', Sex = {(int)employee.Sex} WHERE Id = {employee.Id}");
        }

        public void Delete(int id)
        {
            cn.Execute($"DELETE FROM Employee WHERE Id = {id}");
        }
    }
}