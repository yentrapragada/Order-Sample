using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class OrderList
    {
        public int OrderId { get; set; }
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public int ServiceCount { get; set; }
    }
}
