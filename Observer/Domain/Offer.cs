namespace Observer;

public class Offer
{
    public string ProductName { get; set; }
    public float Price { get; set; }
    public string ShopName { get; set; }
    
    public Offer(string productName, float price, string shopName)
    {
        this.ProductName = productName;
        this.Price = price;
        this.ShopName = shopName;
    }

}