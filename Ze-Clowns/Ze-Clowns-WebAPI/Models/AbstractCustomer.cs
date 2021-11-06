using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ze_Clowns_WebAPI.Models
{
    public abstract class AbstractCustomer
    {
        public Double Price { get; set; }
        protected Double TaxRate { get; set; }
        protected Double DiscountRate { get; set; }



        public abstract Double GetDiscount();

        public virtual String GetShipping()
        {
            return "3-day shipping";
        }

        public abstract Double GetFinalPrice();
        
    }
}
