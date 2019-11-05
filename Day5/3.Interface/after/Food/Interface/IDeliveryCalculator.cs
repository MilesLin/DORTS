using Food.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Interface
{
    public interface IDeliveryCalculator
    {
        decimal CalculateFee(DeliverData deliverData);
    }
}
