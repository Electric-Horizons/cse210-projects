class Product
{
    private string name;
    private int productId;
    private float pricePerUnit;
    private int quantity;

    public Product(string name, int productId, float pricePerUnit, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public float TotalCost()
    {
        return pricePerUnit * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public int GetProductId()
    {
        return productId;
    }
}