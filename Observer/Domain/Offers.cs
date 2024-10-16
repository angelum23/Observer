using Observer.Base;

namespace Observer.Domain;

public class Offers : IObserver
{
    public List<Offer> OffersList { get; } = [];
    
    public void Update(Offer offer)
    {
        OffersList.Add(offer);

        Console.WriteLine("---Offers---");
        for (var i = 0; i < OffersList.Count; i++)
        {
            Console.WriteLine($"Offer {i+1}: {OffersList[i].ProductName} for {OffersList[i].Price} at {OffersList[i].ShopName}");
        }
        Console.WriteLine("------------");
    }
}