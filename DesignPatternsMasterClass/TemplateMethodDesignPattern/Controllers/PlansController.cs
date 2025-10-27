using Microsoft.AspNetCore.Mvc;
using TemplateMethodDesignPattern.TemplatePattern;

namespace TemplateMethodDesignPattern.Controllers
{
    public class PlansController : Controller
    {
        public IActionResult BasicPlan()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
            ViewBag.v2=netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Price(129.90);
            ViewBag.v4=netflixPlans.Resolution("HD (720p)");
            ViewBag.v5 = netflixPlans.Content(" Mevcut Film-Dizi Kütüphanesine Erişim");
            return View();
        }
        public IActionResult StandardPlan()
        {
            NetflixPlans netflixPlans = new StandardPlan();
            ViewBag.v1 = netflixPlans.PlanType("Standart Plan");
            ViewBag.v2 = netflixPlans.CountPerson(2);
            ViewBag.v3 = netflixPlans.Price(179.99);
            ViewBag.v4 = netflixPlans.Content("Film-Dizi-Animasyon");
            ViewBag.v5 = netflixPlans.Resolution("Full HD( 1080P )");
            return View();
        }
        public IActionResult UltraPlan()
        {
            NetflixPlans netflixPlans = new UltraPlan();
            ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlans.CountPerson(4);
            ViewBag.v3 = netflixPlans.Price(399.90);
            ViewBag.v4 = netflixPlans.Content("Tüm Kategorilere Ve Kütüphaneye Eklenecek Yeni İçeriklere İlk Günden erişim");
            ViewBag.v5 = netflixPlans.Resolution("Ultra HD (4K) Dolby Atmos,Dolby Vision, HDR10 ");
            return View();
        }
    }
}
