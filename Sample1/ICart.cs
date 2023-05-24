using System.Collections.Generic;

namespace Sample1
{
    public interface ICart
    {
        TypeOfCart TypeOfCart { get; set; }
        int NumberOfItems { get; }
        IList<dynamic> Items { get; }
        void AddItem<T>(T item);
        decimal TotalPrice();
        string Contents();
    }
}
