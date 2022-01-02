using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ze_Clowns_WebAPI.Models
{
    public enum DepartmentEnum
    {
        DepartmentID,
        Name,
        GroupName,
        ModifiedDate
    }

    public class Department
    {
        public Int16 DepartmentID { get; set; }
        public String Name { get; set; }
        public String GroupName { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
