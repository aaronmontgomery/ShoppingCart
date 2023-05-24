namespace Sample1
{
    public class Meat : Item<Meat>, IMeat
    {
        public decimal Weight
        {
            get => _weight;
        }

        private decimal _weight;
        
        public override Meat WithDescription(string description)
        {
            return base.WithDescription(description);
        }
        
        public override Meat WithUnitPrice(decimal unitPrice)
        {
            return base.WithUnitPrice(unitPrice);
        }
        
        public Meat WithWeight(decimal weight)
        {
            _weight = weight;
            return this;
        }
    }
}
