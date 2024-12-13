public class Order
{
    private List<Product> products;
    private Customer customer;
    private double shippingCost;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in products)
        {
            totalPrice += product.GetTotalCost();
        }
        shippingCost = customer.IsInUSA() ? 5 : 35;
        return totalPrice + shippingCost;
    }

public string GetPackingLabel()
{
    string label = "PACKING LABEL:\n";
    label += string.Format("{0,-35} {1,-15} {2,-5}\n", "ITEM:", "ID:", "QTY:");
    
    foreach (var product in products)
    {
        label += string.Format("{0,-35} {1,-15} {2,-5}\n", product.GetProductName(), product.GetProductId(), product.GetQuantity());
    }
    return label;
}


    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\n{customer.GetCustomerName()}\n{customer.GetAddress()}\n";
    }

    public string GetDiscountedPrice()
    {
        double totalPrice = CalculateTotalPrice();
        double discount = totalPrice * 0.13;
        double discountedPrice = totalPrice - discount;

        return $"TOTAL PRICE: ${totalPrice}\n" +
                "Congradulations on your Friday the 13th Discount!\n"+
               $"Discount (13%): -${discount:F2}\n" +
               $"Adjusted Total: ${discountedPrice:F2}\n";
    }
}
