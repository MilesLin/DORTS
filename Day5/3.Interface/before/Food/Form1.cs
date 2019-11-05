using Food.Model;
using System;
using System.Windows.Forms;

namespace Food
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Platform.SelectedIndex = (int)Vendor.UberEat;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CalBtn_Click(object sender, EventArgs e)
        {
            DeliverData deliverData = new DeliverData
            {
                FoodName = FoodName.Text,
                Price = FoodPrice.Value,
                Distance = Distance.Value
            };

            Vendor vendor = (Vendor)Enum.Parse(typeof(Vendor), Platform.Text);

            decimal sum = 0;
            switch (vendor)
            {
                case Vendor.UberEat:
                    sum = CalUberEat(deliverData);
                    break;

                case Vendor.FoodPanda:
                    sum = CalFoodPanda(deliverData);
                    break;

                case Vendor.HonestBee:
                    sum = CalHonestBee(deliverData);
                    break;
            }

            Sum.Text = sum.ToString();
        }

        private decimal CalUberEat(DeliverData deliverData)
        {
            decimal sum = deliverData.Price * 1.2m + deliverData.Distance * 0.05m;
            return sum;
        }

        private decimal CalFoodPanda(DeliverData deliverData)
        {
            decimal sum = deliverData.Price * 1.15m + deliverData.Distance * 0.1m;
            return sum;
        }

        private decimal CalHonestBee(DeliverData deliverData)
        {
            decimal sum = (deliverData.Price * 1.1m + deliverData.Distance * 0.08m) * 0.9m;
            return sum;
        }
    }
}