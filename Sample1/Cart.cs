using System.Collections.Generic;

namespace Sample1
{
    public class Cart : ICart
    {
        public TypeOfCart TypeOfCart
        {
            get => _typeOfCart;
            set => _typeOfCart = value;
        }
        
        public int NumberOfItems
        {
            get => _items.Count;
        }
        
        public IList<dynamic> Items
        {
            get => _items;
        }
        
        private TypeOfCart _typeOfCart;
        private readonly IList<dynamic> _items = new List<dynamic>();
        
        public void AddItem<T>(T item)
        {
            _items.Add(item);
        }
        
        public decimal TotalPrice()
        {
            decimal totalPrice;
            
            totalPrice = 0;
            foreach (var item in _items)
            {
                totalPrice += item.UnitPrice;
            }
            
            return totalPrice;
        }
        
        public string Contents()
        {
            List<string> contents;
            
            contents = new List<string>();
            foreach (var item in _items)
            {
                contents.Add(item.Description);
            }
            
            return string.Join(", ", contents);
        }
    }
}
