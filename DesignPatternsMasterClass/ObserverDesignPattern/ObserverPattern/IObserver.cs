using ObserverDesignPattern.DAL.Entities;

namespace ObserverDesignPattern.ObserverPattern
{
    public interface IObserver
    {
        public void CreateNewUser(AppUser AppUser);
    }
}
