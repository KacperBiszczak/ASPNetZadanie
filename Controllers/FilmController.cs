using ASPNetZadanie.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetZadanie.Controllers
{
    public class FilmController : Controller
    {
        private static IList<Filmy> films = new List<Filmy>
        {
            new Filmy(){Id = 1, Name = "Auta", Description = "Bajka o autach", Price = 10},
            new Filmy(){Id = 2, Name = "Terrifier 3", Description = "Horror", Price = 20},
            new Filmy(){Id = 3, Name = "Venom", Description = "Film o symbiotach na ziemii", Price = 15}
        };
       

        // GET: FilmController
        public ActionResult Index()
        {
            return View(films);
        }

        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {
            return View(films.FirstOrDefault(x => x.Id == id));
        }

        // GET: FilmController/Create
        public ActionResult Create()
        {
            return View(new Filmy());
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Filmy film)
        {
            film.Id = films.Count + 1;
            films.Add(film);
            return RedirectToAction(nameof(Index));
            
            
        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Filmy film)
        {
            Filmy filmEdit = films.FirstOrDefault(x => x.Id == id);
            filmEdit.Name = film.Name;
            filmEdit.Description = film.Description;
            filmEdit.Price = film.Price;
            return RedirectToAction(nameof(Index));
        }

        // GET: FilmController/Delete/5
        public ActionResult Delete(int id)
        {
            films.Remove(films.FirstOrDefault(x => x.Id == id));
            return View();
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
