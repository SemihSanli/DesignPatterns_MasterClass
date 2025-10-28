using ObserverDesignPattern.DAL.Context;
using ObserverDesignPattern.DAL.Entities;
using ObserverDesignPattern.ObserverPattern;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ObserverDbContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ObserverDbContext>();

builder.Services.AddSingleton<ObserverDesignPattern.ObserverPattern.ObserverObject>(sp =>
{
    ObserverObject observerObject = new();
    observerObject.RegisterObserver(new CreateWelcomeMessage(sp));
    observerObject.RegisterObserver(new CreateDiscountCode(sp));
    observerObject.RegisterObserver(new CreateMagazineAnnouncement(sp));

    return observerObject;
});
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
