using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ze_Clowns_WebAPI.Models.Enums
{
    public enum EmployeeType
    {
        CEO, 
        CIO,
        Director,
        Manager,
        Architect,
        Lead_Developer,
        Senior_Developer,
        Mid_Developer,
        Junior_Developer
    }

    public enum CustomerType
    {
        VIP=10,
        Premium,
        Regular
    }
}
