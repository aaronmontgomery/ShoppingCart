namespace Sample1
{
    public class Dairy : Item<Dairy>, IDairy
    {
        public ulong Quantity
        {
            get => _quantity;
        }

        private ulong _quantity;
        
        public override Dairy WithDescription(string description)
        {
            return base.WithDescription(description);
        }
        
        public override Dairy WithUnitPrice(decimal unitPrice)
        {
            return base.WithUnitPrice(unitPrice);
        }
        
        public Dairy WithQuantity(ulong quantity)
        {
            _quantity = quantity;
            return this;
        }
    }
}
