namespace Observer.Base;

public class AmazonBot : Subject
{
    public void Scrapper()
    {
        // Do some scrapping
        var foundOffer = new Offer("New phone", 990.36f, "Amazoff");
        
        NotifyObservers(foundOffer);
    }
}