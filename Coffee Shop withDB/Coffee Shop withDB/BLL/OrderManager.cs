using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_Shop_withDB.Repository;
using System.Data;

namespace Coffee_Shop_withDB.BLL
{
    public class OrderManager
    {
        OrdersRepository _OrdersRepository = new OrdersRepository();

        public bool OrdersAdd(string itemName, int itemQuantity, double totalPrice, string customerName)
        {
            return _OrdersRepository.OrdersAdd(itemName, itemQuantity, totalPrice, customerName);
        }

        public bool IsCustomerExists(string customerName)
        {
            return _OrdersRepository.IsCustomerExists(customerName);
        }

        public bool OrdersDelete(int orderId)
        {
            return _OrdersRepository.OrdersDelete(orderId);
        }

        public bool OrdersUpdate(string itemName, int itemQuantity, double totalPrice, string customerName, int orderId)
        {
            return _OrdersRepository.OrdersUpdate(itemName, itemQuantity, totalPrice, customerName, orderId);
        }

        public DataTable OrderDisplay()
        {
            return _OrdersRepository.OrderDisplay();
        }

        public DataTable CustomerSearch(int orderId)
        {
            return _OrdersRepository.CustomerSearch(orderId);
        }
    }
}
