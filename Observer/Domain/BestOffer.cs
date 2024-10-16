using Observer.Base;

namespace Observer;

public class BestOffer : IObserver
{
    public void Update(Offer offer)
    {
        Console.WriteLine("Best offer found: " + offer.ProductName + " for " + offer.Price + " at " + offer.ShopName);
    }
}