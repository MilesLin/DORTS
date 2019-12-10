using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Block_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();

            var result = await wc.DownloadStringTaskAsync("http://slowwly.robertomurray.co.uk/delay/3000/url/https://jsonplaceholder.typicode.com/todos/1");
            textBox1.Text = result;
        }
    }
}
