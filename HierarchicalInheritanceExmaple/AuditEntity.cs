using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritanceExmaple
{
    public class AuditEntity

    {
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UpdatedBy { get; set; }
        public int UpdatedOn { get; set; }
    }

    public class Employee : AuditEntity
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string salary { get; set; }


    }
    public class Company : AuditEntity
    {
        public string CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string WebsiteUrl { get; set; }
    }
   
}
