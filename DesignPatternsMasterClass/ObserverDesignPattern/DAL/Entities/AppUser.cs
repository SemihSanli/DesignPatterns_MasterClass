using Microsoft.AspNetCore.Identity;

namespace ObserverDesignPattern.DAL.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public string FullName { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
    }
}
