using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using DomainModel;

namespace DomainService
{
    public class Paramed : Orders, IOrderAction
    {
        private static Paramed ParamedInstance = null;

        public static Paramed GetInstance
        {
            get
            {
                if (ParamedInstance == null)
                {
                    ParamedInstance = new Paramed();
                }
                return ParamedInstance;
            }
        }
        public override string AddService()
        {
            return "Paramed Service Added";
        }

        public override string CancelOrder()
        {
            return "Paramed Order Canceled";
        }

        public OrderList CreateOrderList()
        {
            OrderId = 102;
            CustomerName = "Customer #3";
            AccountNumber = "Undefined";
            OrderList ListOfOrder = new OrderList();
            ListOfOrder.AccountNumber = AccountNumber;
            ListOfOrder.CustomerName = CustomerName;
            ListOfOrder.OrderId = OrderId;
            ListOfOrder.ServiceCount = 1;
            return ListOfOrder;
        }

        public override string SendBilling()
        {
            return "Paramed Service Bill Sent";
        }
    }
}
