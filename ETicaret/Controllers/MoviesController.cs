using ETicaret.Data.Services;
using ETicaret.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ETicaret.Controllers
{
    public class MoviesController : Controller
    {
        readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync(n=> n.Cinema);            
            return View(data);
        }

        public async Task<IActionResult> Details(int id) 
        {
            var movie = await _service.GetMovieByIdAsync(id);
            return View(movie);
        }

        public async Task<IActionResult> Create() 
        {


            var movieDdVm = await _service.GetMovieDropdownsVMValues();

            ViewBag.Cinemas = new SelectList(movieDdVm.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDdVm.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDdVm.Actors, "Id", "FullName");

            return View(new MovieVM());
        }
    }
}
