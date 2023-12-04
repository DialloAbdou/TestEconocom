using Carre.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carre.API.Controllers
{
    public class CarreColorController : Controller
    {
        private readonly ICarreService _carreService;
        public CarreColorController(ICarreService carreService)
        {
            _carreService = carreService;
        }

        [HttpGet("{max}")]
        public IActionResult GetColorsCarres(int max)
        {
            Dictionary<int , string> DicoCarrecolors = new Dictionary<int , string>();
            DicoCarrecolors = _carreService.GetListeColorsCarres(max);
            return Ok(DicoCarrecolors);
        }

    }
}
