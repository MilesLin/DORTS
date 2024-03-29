﻿using fix_exception.Model;
using fix_exception.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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
            AddedMajor.SelectedIndex = 0;
            UpdateGrid();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student
                {
                    Email = AddedEmail.Text,
                    Name = AddedName.Text,
                    Major = (Major)Enum.Parse(typeof(Major), AddedMajor.Text)
                };

                _studentService.Add(student);
            }
            catch (Exception ex)
            {
                MessageBox.Show("出現無預期的錯誤");
            }

            UpdateGrid();

        }

        private void UpdateGrid()
        {
            var students = _studentService.GetAll();
            dataGridView1.DataSource = ToDataTable(students.Values.ToList());
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
