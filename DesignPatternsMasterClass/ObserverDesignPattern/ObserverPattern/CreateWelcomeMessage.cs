using ObserverDesignPattern.DAL.Context;
using ObserverDesignPattern.DAL.Entities;

namespace ObserverDesignPattern.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        ObserverDbContext observerDbContext = new ObserverDbContext();
        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

  
        public void CreateNewUser(AppUser AppUser)
        {
            observerDbContext.WelcomeMessages.Add(new WelcomeMessage
            {
                FullName = AppUser.FullName,
                Content = "Dergi bültenine kayıt olduğunuz için teşekkürler!",
            });
            observerDbContext.SaveChanges();
        }
    }
}
