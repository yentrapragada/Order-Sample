using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService
{
    public abstract class Orders
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string AccountNumber { get; set; }
        public List<string> Services { get; set; }

        public abstract string AddService();
        public abstract string CancelOrder();
        public abstract string SendBilling();

    }
}
