using System;
using System.Collections.Generic;
using System.Text;
using Teacher4.DataLayer.Entities.Order;

namespace Teacher4.Core.Services.Interfaces
{
    public interface IOrderService
    {
        int AddOrder(string userName, int courseId);

        void UpdatePriceOrder(int orderId);

        Order GetOrderForUserPanel(string userName, int orderId);

        bool FinalyOrder(string userName, int orderId);

        List<Order> GetUserOrders(string userName);
        bool IsUserInCourse(string userName, int courseId);
    }
}
