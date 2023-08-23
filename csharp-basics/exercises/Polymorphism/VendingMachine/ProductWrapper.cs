using VendingMachine;

public class ProductWrapper : IProduct
{
    private Product _product;

    public ProductWrapper(Product product)
    {
        _product = product;
    }

    public string Name => _product.Name;
    public Money Price => _product.Price;
    public int Available => _product.Available;
}