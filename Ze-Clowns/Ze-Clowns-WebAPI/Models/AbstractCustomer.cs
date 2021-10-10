using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ze_Clowns_WebAPI.Models
{
    public abstract class AbstractCustomer
    {
        public abstract Double GetDiscount();

        public virtual String GetShipping()
        {
            return "3-day shipping";
        }

    }
}
