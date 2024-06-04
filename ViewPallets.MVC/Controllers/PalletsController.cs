using Microsoft.AspNetCore.Mvc;
using ViewPallets.Application.Services;

namespace ViewPallets.MVC.Controllers
{
    public class PalletsController : Controller
    {
        private readonly IPalletService _palletService;

        public PalletsController(IPalletService palletService)
        {
            _palletService = palletService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("Pallets/Informations/{palletNumber}")]
        public async Task<IActionResult> Informations(string palletNumber)
        {
            var dto = await _palletService.FindPalletDetails(palletNumber);
            if(dto==null)
                return RedirectToAction("Index");
            return View(dto);
        }
    }
}
