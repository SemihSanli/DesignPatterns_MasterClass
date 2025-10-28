using ObserverDesignPattern.DAL.Entities;

namespace ObserverDesignPattern.ObserverPattern
{
    public class ObserverObject
    {
        private readonly List<IObserver> _observers;

        public ObserverObject()
        {
            _observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void UnregisterObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObservers(AppUser appUser)
        {
            _observers.ForEach(observer => observer.CreateNewUser(appUser));
        }
    }
}
