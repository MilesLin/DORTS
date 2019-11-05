using Food.Interface;
using Food.Model;

namespace Food.Service
{
    public class UberEat : IDeliveryCalculator
    {
        private const decimal priceFee = 1.2m;
        private const decimal distanceFee = 0.05m;

        public decimal CalculateFee(DeliverData deliverData)
        {
            decimal sum = deliverData.Price * priceFee + deliverData.Distance * distanceFee;
            return sum;
        }
    }
}