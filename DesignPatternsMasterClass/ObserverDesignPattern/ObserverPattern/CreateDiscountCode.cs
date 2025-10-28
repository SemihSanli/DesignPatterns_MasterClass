using ObserverDesignPattern.DAL.Context;
using ObserverDesignPattern.DAL.Entities;

namespace ObserverDesignPattern.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        ObserverDbContext observerDbContext = new ObserverDbContext();
        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }


        public void CreateNewUser(AppUser AppUser)
        {
            observerDbContext.Discounts.Add(new Discount
            {
                DiscountCode = "EKIM25",
                DiscountAmount = 25,
                DiscountStatus = true
            });
            observerDbContext.SaveChanges();
        }
    }
}
