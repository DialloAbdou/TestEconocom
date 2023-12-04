using Carre.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carre.API.Controllers
{
    public class CarreColorController : Controller
    {
        private readonly CarreService carreService;
        public CarreColorController()
        {
            carreService = new CarreService();
        }

        [HttpGet("{max}")]
        public IActionResult GetColorsCarres(int max)
        {
            Dictionary<int , string> DicoCarrecolors = new Dictionary<int , string>();
            DicoCarrecolors = carreService.GetListeColorsCarres(max);
            return Ok(DicoCarrecolors);
        }

    }
}
