public class Product
{
    private string _nameProduct;
    private string _idProduct;
    private double _priceProduct;
    private int _quantityProduct;

    public Product(string nameProduct, string idProduct, double priceProduct, int quantityProduct)
    {
        _nameProduct = nameProduct;
        _idProduct = idProduct;
        _priceProduct = priceProduct;
        _quantityProduct = quantityProduct;
    }

    public double GetTotalCost()
    {
        return _priceProduct * _quantityProduct;
    }
    public string GetName()
    {
        return _nameProduct;
    }

    public string GetProductId()
    {
        return _idProduct;
    }
}