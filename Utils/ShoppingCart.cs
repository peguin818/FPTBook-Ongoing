using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FPTBook.Utils
{
    public static class SessionExtensions
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObject<T>(this ISession session, string key) where T : class
        {
            var value = session.GetString(key);
            return value == null ? null : JsonConvert.DeserializeObject<T>(value);
        }
    }

    public class CartItem
    {
        public long? BookID;
        public string? Name;
        public float Price;
        public int Quantity;
        public CartItem(long BookID, string Name, float Price, int Quantity)
        {
            this.BookID = BookID;
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    }

    public class ShoppingCart
    {
        public List<CartItem> Items { get; set; }
        public ShoppingCart()
        {
            Items = new List<CartItem>();
        }
        public CartItem AddItem(long BookID, string Name, float Price, int Quantity)
        {
            CartItem item = new CartItem(BookID, Name, Price, Quantity);
            bool isExist = false;
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].BookID == BookID)
                {
                    Items[i].Quantity += Quantity;
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
                Items.Add(item);
            return item;
        }
        public void EditItem(long BookID, int Quantity)
        {
            foreach (CartItem item in Items)
            {
                if (item.BookID == BookID)
                {
                    if (Quantity == 0)
                        Items.Remove(item);
                    else
                        item.Quantity = Quantity;
                    break;
                }
            }
        }
        public void RemoveItem(long BookID)
        {
            EditItem(BookID, 0);
        }
    }
    public class ReportItem
    {
        public string? Name;
        public int Quantity;
        public ReportItem(string Name, int Quantity)
        {
            this.Name = Name;
            this.Quantity = Quantity;
        }
    }
}