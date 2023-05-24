namespace Sample1
{
    public interface IDairy
    {
        ulong Quantity { get; }
        Dairy WithQuantity(ulong quantity);
    }
}
