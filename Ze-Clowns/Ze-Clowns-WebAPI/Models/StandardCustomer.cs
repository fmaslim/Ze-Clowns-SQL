using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ze_Clowns_WebAPI.Models.Interfaces;

namespace Ze_Clowns_WebAPI.Models
{
    /// <summary>
    /// Represents a standard customer
    /// </summary>
    public class StandardCustomer :AbstractCustomer ,ITax
    {
        public static string FirstNameLabel
        {
            get { return "First Name: "; }
        }

        /// <summary>
        /// Constructor for StandardCustomer. Initializes the tax rate
        /// </summary>
        public StandardCustomer (Double price)
        {
            this.Price = price;
            this.TaxRate = 0.08;
            this.DiscountRate = 0;
        }

        /// <summary>
        /// Gets a discount for this customer
        /// </summary>
        /// <returns>Returns a discount value for this customer</returns>
       public override double GetDiscount()
        {
            return this.Price * this.DiscountRate;
        }

        public override double GetFinalPrice()
        {
            return this.Price + this.GetTax() - this.GetDiscount();
        }

        /// <summary>
        /// Gets the tax amount
        /// </summary>
        /// <returns>Returns the tax amount</returns>
        public double GetTax()
        {
            return this.Price * this.TaxRate;
        }
    }
}
