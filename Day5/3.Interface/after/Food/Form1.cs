using Food.Interface;
using Food.Model;
using Food.Service;
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

            IDeliveryCalculator caculator = GetCalculator(vendor);

            decimal sum = caculator.CalculateFee(deliverData);

            Sum.Text = sum.ToString();
        }

        private IDeliveryCalculator GetCalculator(Vendor vendor)
        {
            switch (vendor)
            {
                case Vendor.UberEat:
                    return new UberEat();

                case Vendor.FoodPanda:
                    return new FoodPanda();

                case Vendor.HonestBee:
                    return new HonestBee();
            }
            return null;
        }
    }
}