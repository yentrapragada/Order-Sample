using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace Interface
{
    public interface IOrderAction
    {
        OrderList CreateOrderList();
    }
}
