using MediatR;
using Microsoft.AspNetCore.Mvc;
using ViewPallets.Application.PalletCQRS.Queries.GetPalletInformations;

namespace ViewPallets.MVC.Controllers
{
    public class PalletsController : Controller
    {
        private readonly IMediator _mediator;

        public PalletsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("Pallets/Informations/{palletNumber}")]
        public async Task<IActionResult> Informations(string palletNumber)
        {
            var dto = await _mediator.Send(new GetPalletInformationsQuery()
            {
                palletNumberMediatR = palletNumber
            });

            if(dto==null)
                return RedirectToAction("Index");
            return View(dto);
        }
    }
}
