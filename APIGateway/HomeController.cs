using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VehicleRegistration;

namespace APIGateway
{
    public class HomeController : Controller
    {

        private readonly IRegistrationService registrationService;

        public HomeController(IRegistrationService registrationService)
        {
            this.registrationService = registrationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet(Name = "GetAppProcessFlow")]
        public async Task<IActionResult> GetAppProcessFlowAsync(long applicationId)
        {
            var ds = await this.registrationService.GetAPFDropDowns();

            return View(ds);
        }
    }
}
