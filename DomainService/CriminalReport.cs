using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using DomainModel;

namespace DomainService
{
    public sealed class CriminalReport : Orders, IOrderAction
    {
        private static CriminalReport CriminalInstance = null;

        public static CriminalReport GetInstance
        {
            get
            {
                if (CriminalInstance == null)
                {
                    CriminalInstance = new CriminalReport();
                }
                return CriminalInstance;
            }
        }
        
        public override string AddService()
        {
            return "Criminal Report Service Added";
        }

        public override string CancelOrder()
        {
            return "Criminal Report Order Cancel";
        }

        public OrderList CreateOrderList()
        {
            OrderId = 101;
            CustomerName = "Customer #2";
            AccountNumber = "Undefined";
            OrderList ListOfOrder = new OrderList();
            ListOfOrder.AccountNumber = AccountNumber;
            ListOfOrder.CustomerName = CustomerName;
            ListOfOrder.OrderId = OrderId;
            ListOfOrder.ServiceCount = 3;
            return ListOfOrder;
        }

        public override string SendBilling()
        {
            return "Criminal Report Bill Sent";
        }
    }
}
