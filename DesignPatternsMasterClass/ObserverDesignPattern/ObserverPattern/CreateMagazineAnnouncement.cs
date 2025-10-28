using ObserverDesignPattern.DAL.Context;
using ObserverDesignPattern.DAL.Entities;

namespace ObserverDesignPattern.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        ObserverDbContext observerDbContext = new ObserverDbContext();
        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }


        public void CreateNewUser(AppUser AppUser)
        {
            observerDbContext.Loggings.Add(new Logging
            {
                FullName = AppUser.FullName,
                Magazine = "Teknoloji Dergisi",
                Content = "Dergi bültenine yeni kayıt oldu.",
            });
            observerDbContext.SaveChanges();
        }
    }
}
