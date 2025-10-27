using ChainOfResponsibilityPattern.ChainOfResponsibility;
using ChainOfResponsibilityPattern.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfResponsibilityPattern.Controllers
{
    public class CustomerProcessController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProccessViewModel customerProccessViewModel)
        {
            Employee treasure = new Treasure();
            Employee manager = new Manager();
            Employee managerAssistant = new ManagerAssistant();
            Employee areaDirector = new AreaDirector();

            treasure.SetNextAppRover(managerAssistant);
            managerAssistant.SetNextAppRover(manager);
            manager.SetNextAppRover(areaDirector);

            treasure.ProcessRequest(customerProccessViewModel);
            return View();
        }
    }
}
