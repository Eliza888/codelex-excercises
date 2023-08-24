using System;

namespace VendingMachine
{
    public interface IProduct
    {
        string Name { get; }
        Money Price { get; }
        int Available { get; }
    }
}