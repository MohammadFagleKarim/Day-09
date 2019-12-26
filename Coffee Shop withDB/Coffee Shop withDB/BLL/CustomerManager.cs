using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_Shop_withDB.Repository;
using System.Data;

namespace Coffee_Shop_withDB.BLL
{
    public class CustomerManager
    {
        CustomersRepository _customersRepository = new CustomersRepository();

        public bool CustomersAdd(string customerName, string customerContact, string customerAddress)
        {
            return _customersRepository.CustomersAdd(customerName, customerContact, customerAddress);
        }

        public bool IsContactExists(string customerContact)
        {
            return _customersRepository.IsContactExists(customerContact);
        }

        public bool CustomerDelete(int customerId)
        {
            return _customersRepository.CustomerDelete(customerId);
        }

        public bool CustomerUpdate(string customerName, string customerContact, string customerAddress, int customerId)
        {
            return _customersRepository.CustomerUpdate(customerName, customerContact, customerAddress, customerId);
        }

        public DataTable CustomerDisplay()
        {
            return _customersRepository.CustomerDisplay();
        }

        public DataTable CustomerSearch(int customerId)
        {
            return _customersRepository.CustomerSearch(customerId);
        }
    }
}
