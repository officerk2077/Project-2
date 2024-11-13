using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KienAuto.Models
{
    public class ShoppingCart
    {
        private List<CartItem> _items = new List<CartItem>();

        public void AddItem(int itemId, string itemName, decimal price, int quantity)
        {
            var existingItem = _items.FirstOrDefault(i => i.ItemId == itemId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                _items.Add(new CartItem
                {
                    ItemId = itemId,
                    ItemName = itemName,
                    Price = price,
                    Quantity = quantity
                });
            }
        }

        public void RemoveItem(int itemId)
        {
            var item = _items.FirstOrDefault(i => i.ItemId == itemId);
            if (item != null)
            {
                _items.Remove(item);
            }
        }
        public void ClearCart()
        {
            _items.Clear();
        }
        public decimal GetTotal()
        {
            return _items.Sum(i => i.Price * i.Quantity);
        }

        public List<CartItem> GetItems()
        {
            return _items;
        }

        public void Clear()
        {
            _items.Clear();
        }
    }
}