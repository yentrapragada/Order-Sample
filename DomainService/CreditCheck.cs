using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using DomainModel;

namespace DomainService
{
    public class CreditCheck : Orders, IOrderAction
    {
        private static CreditCheck CreditCheckInstance = null;
        
        public static CreditCheck GetInstance
        {
            get
            {
                if (CreditCheckInstance == null)
                {
                    CreditCheckInstance = new CreditCheck();
                }
                return CreditCheckInstance;
            }
        }
        public override string AddService()
        {
            return "Credit Check Service Added";
        }

        public override string CancelOrder()
        {
            return "Credit Check Order Canceled";
        }

        public OrderList CreateOrderList()
        {
            OrderId = 100;
            CustomerName = "Customer #1";
            AccountNumber = "Undefined";
            OrderList ListOfOrder = new OrderList();
            ListOfOrder.AccountNumber = AccountNumber;
            ListOfOrder.CustomerName = CustomerName;
            ListOfOrder.OrderId = OrderId;
            ListOfOrder.ServiceCount = 2;
            return ListOfOrder;
        }

        public override string SendBilling()
        {
            return "Credit Check Billing Sent";
        }
    }
}
