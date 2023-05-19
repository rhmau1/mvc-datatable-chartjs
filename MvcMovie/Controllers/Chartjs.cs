using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using MvcMovie.Data;

namespace MvcMovie.Controllers
{
    public class Chartjs : Controller
    {
        private readonly MvcMovieContext _context;

        public Chartjs(MvcMovieContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }     

        [HttpPost]
        public List<Object> GetMoviesData()
        {
            List<object> data = new List<object>();
            List<string> labels = _context.Movie.Select(p=>p.Title).ToList();
            data.Add(labels);
            List<decimal> harga = _context.Movie.Select(p => p.Price).ToList();
            data.Add(harga);
            return data;
        }
    }
}
