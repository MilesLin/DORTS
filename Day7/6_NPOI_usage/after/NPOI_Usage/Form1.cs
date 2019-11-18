using fix_exception.Model;
using fix_exception.Service;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace fix_exception
{
    public partial class Form1 : Form
    {
        private readonly StudentService _studentService;

        public Form1()
        {
            _studentService = new StudentService();
            InitializeComponent();
            UpdateGrid();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            /*----------Result----------
                ---------------------
                |ID	|Name	|Course |
                |1	|Miles1	|Math1  |
                |2	|Miles2	|Math2  |
                ---------------------
            ---------------------------*/

            // Create Workbook and Specify Excel Version
            // [.xlsx => Excel 2007+ (new XSSFWorkbook)], [.xls => Excel 97-2003 (new HSSFWorkbook)]
            IWorkbook workbook = new XSSFWorkbook();

            // Use workbook to Create Sheet
            ISheet sheet = workbook.CreateSheet("sheetname");

            // Use sheet to Create Row
            sheet.CreateRow(0);

            // Use sheet to Create Cell and Set Cell Value at top row of created
            sheet.GetRow(0).CreateCell(0).SetCellValue("Email");
            sheet.GetRow(0).CreateCell(1).SetCellValue("Name");
            sheet.GetRow(0).CreateCell(2).SetCellValue("Major");

            List<Student> students = _studentService.GetAll();

            // Use sheet to Create New Row and Set Cell Value at each row of created
            for (int i = 1; i < 3; i++)
            {
                sheet.CreateRow(i);
                sheet.GetRow(i).CreateCell(0).SetCellValue(students[i - 1].Email);
                sheet.GetRow(i).CreateCell(1).SetCellValue(students[i - 1].Name);
                sheet.GetRow(i).CreateCell(2).SetCellValue(students[i - 1].Major.ToString());
            }

            // Call MemoryStream to Write it
            MemoryStream ms = new MemoryStream();

            // note : Inside workbook.Write() had called ms.close(), so you can't read it from MemoryStream
            //        if you want to output file, you should make MemoryStream's content Convert to Array
            workbook.Write(ms);

            // open save dialog
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "mytest.xlsx";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                string fileName = savefile.FileName;
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    // Save File
                    fs.Write(ms.ToArray(), 0, ms.ToArray().Length);
                    fs.Flush();
                }
            }
        }

        private void UpdateGrid()
        {
            var students = _studentService.GetAll();
            dataGridView1.DataSource = ToDataTable(students.ToList());
        }

        private static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
}