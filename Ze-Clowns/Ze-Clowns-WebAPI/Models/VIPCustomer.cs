using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ze_Clowns_WebAPI.Models.Interfaces;

namespace Ze_Clowns_WebAPI.Models
{
    public class VIPCustomer : AbstractCustomer, ITax
    {
        public VIPCustomer(Double price)
        {
            this.Price = price;
            this.TaxRate = 0.06;
            this.DiscountRate = 0.1;

        }
        public override double GetDiscount()
        {
            return this.Price * this.DiscountRate;
        }

        public override double GetFinalPrice()
        {
            return this.Price + this.GetTax() - this.GetDiscount();
        }

        public double GetTax()
        {
            return this.Price * this.TaxRate;
        }
    }
}
