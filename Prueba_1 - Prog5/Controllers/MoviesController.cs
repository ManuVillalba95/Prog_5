using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using Prueba_1___Prog5.Data;

namespace Prueba_1___Prog5.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Details/5
        [HttpGet]
        public IActionResult Details(int? id)
        {
        DA_Movie dA_Movie = new DA_Movie();
            var dt = dA_Movie.Obtener();
            if (id == null)
            {
                return NotFound();
            }

            //Simulación de creación de un objeto (model)
            //Mas adelante vamos a ver como usar una base de datos
            var movie = new Movie
            {
                Genre = "Terror",
                Id = 1,
                Price = 1,
                ReleaseDate = DateTime.Now,
                Title = "La noche del terror"
            };


            return View(movie);
        }
    }
}
