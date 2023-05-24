namespace Sample1
{
    public interface IItem<T>
    {
        string Description { get; }
        decimal UnitPrice { get; }
        T WithDescription(string description);
        T WithUnitPrice(decimal unitPrice);
    }
}
