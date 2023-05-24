namespace Sample1
{
    public interface IMeat
    {
        decimal Weight { get; }
        Meat WithWeight(decimal weight);
    }
}
