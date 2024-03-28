class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public float TotalPrice()
    {
        float total = 0;
        foreach (var product in products)
        {
            total += product.TotalCost();
        }
        total += customer.IsInUSA() ? 5 : 35; // Shipping cost
        return total;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (var product in products)
        {
            label += $"{product.GetName()} - ID: {product.GetProductId()}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Customer: {customer.GetName()}\nAddress: {customer.GetAddress().GetAllFields()}";
    }
}