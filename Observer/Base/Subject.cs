namespace Observer.Base;

public abstract class Subject
{
    protected List<IObserver> Observers { get; } = [];

    public virtual void RegisterObserver(IObserver observer)
    {
        this.Observers.Add(observer);
    }
    
    public virtual void RemoveObserver(IObserver observer)
    {
        this.Observers.Remove(observer);
    }
    
    public virtual void NotifyObservers(List<Offer> offers)
    {
        foreach (var observer in this.Observers)
        {
            foreach (var offer in offers)
            {
                observer.Update(offer);
            }
        }
    }
    
    public virtual void NotifyObservers(Offer offer)
    {
        foreach (var observer in this.Observers)
        {
            observer.Update(offer);
        }
    }
}