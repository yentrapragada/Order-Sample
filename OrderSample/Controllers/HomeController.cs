using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainService;
using DomainModel;

namespace OrderSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetOrderList()
        {
            List<OrderList> ListOfOrder = new List<OrderList>();
            Paramed ParamedOrder = Paramed.GetInstance;
            CreditCheck CreditOrder = CreditCheck.GetInstance;
            CriminalReport CriminalOrder = CriminalReport.GetInstance;
            var Param = ParamedOrder.CreateOrderList();
            var Credit = CreditOrder.CreateOrderList();
            var Criminal = CriminalOrder.CreateOrderList();
            ListOfOrder.Add(new OrderList { AccountNumber = Credit.AccountNumber, CustomerName = Credit.CustomerName, OrderId = Credit.OrderId, ServiceCount = Credit.ServiceCount });
            ListOfOrder.Add(new OrderList { AccountNumber = Criminal.AccountNumber, CustomerName = Criminal.CustomerName, OrderId = Criminal.OrderId, ServiceCount = Criminal.ServiceCount });
            ListOfOrder.Add(new OrderList { AccountNumber = Param.AccountNumber, CustomerName = Param.CustomerName, OrderId = Param.OrderId, ServiceCount = Param.ServiceCount });

            return Json(ListOfOrder, JsonRequestBehavior.AllowGet);
        }
    }
}