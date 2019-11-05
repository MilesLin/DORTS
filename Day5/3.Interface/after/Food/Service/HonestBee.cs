using Food.Interface;
using Food.Model;

namespace Food.Service
{
    public class HonestBee : IDeliveryCalculator
    {
        private const decimal priceFee = 1.1m;
        private const decimal distanceFee = 0.08m;
        private const decimal discount = 0.9m;

        public decimal CalculateFee(DeliverData deliverData)
        {
            decimal sum = (deliverData.Price * priceFee + deliverData.Distance * distanceFee) * discount;
            return sum;
        }
    }
}