using Food.Interface;
using Food.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Service
{
    public class FoodPanda: IDeliveryCalculator
    {
        private const decimal priceFee = 1.15m;
        private const decimal distanceFee = 0.1m;

        public decimal CalculateFee(DeliverData deliverData)
        {
            decimal sum = deliverData.Price * priceFee + deliverData.Distance * distanceFee;
            return sum;
        }
    }
}
