using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookUdemy.Domain.Entites
{
    public class CarPricing
    {
        public int CarPricingId { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int PriicngId { get; set; }
        public Pricing Pricing { get; set; }
        public decimal Price { get; set; }
    }
}
