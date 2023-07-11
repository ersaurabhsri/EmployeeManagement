using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Foundation.Models
{
    public class EmployeeDetails
    {
        public int id { get; set; }
        public string name { get; set; }
        public int DeparmentId { get; set; }
        public int age { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }
}
