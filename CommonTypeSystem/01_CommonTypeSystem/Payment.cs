public class Payment
{
    public Payment(string productName, double price)
    {
        this.ProductName = productName;
        this.Price = price;
    }

    public string ProductName { get; set; }

    public double Price { get; set; }

    public override string ToString()
    {
        return string.Format("{0} {1}", this.ProductName, this.Price);
    }
}
