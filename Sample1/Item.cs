namespace Sample1
{
    public abstract class Item<T> : IItem<T>
    {
        public string Description
        {
            get => _description;
        }
        
        public decimal UnitPrice
        {
            get => _unitPrice;
        }
        
        private string _description;
        private decimal _unitPrice;
        
        public virtual T WithDescription(string description)
        {
            _description = description;
            return (T)(IItem<T>)this;
        }
        
        public virtual T WithUnitPrice(decimal unitPrice)
        {
            _unitPrice = unitPrice;
            return (T)(IItem<T>)this;
        }
    }
}
