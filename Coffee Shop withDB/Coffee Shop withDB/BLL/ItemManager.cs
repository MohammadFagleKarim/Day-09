using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffee_Shop_withDB.Repository;
using System.Data;

namespace Coffee_Shop_withDB.BLL
{
    public class ItemManager
    {
        ItemsRepository _itemsRepository = new ItemsRepository();

        public bool ItemsAdd(string itemName, double price)
        {
            return _itemsRepository.ItemsAdd(itemName, price);
        }

        public bool IsNameExists(string itemsName)
        {
            return _itemsRepository.IsNameExists(itemsName);
        }

        public bool Delete(int itemId)
        {
            return _itemsRepository.Delete(itemId);
        }

        public bool Update(string itemName, double itemPrice, int itemId)
        {
            return _itemsRepository.Update(itemName, itemPrice, itemId);
        }

        public DataTable Display()
        {
            return _itemsRepository.Display();
        }

        public DataTable Search(string itemName)
        {
            return _itemsRepository.Search(itemName);
        }
    }
}
