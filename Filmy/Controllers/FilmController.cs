using Filmy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Filmy.Controllers
{
    public class FilmController : Controller
    {
        private static IList<Film> filmies = new List<Film>
        {
            new Film(){Id=1, Tytul="Batman", Ocena=3, Opis="Opis filmu1"},
            new Film(){Id=2, Tytul="Batman2", Ocena=4, Opis="Opis filmu2"},
            new Film(){Id=3, Tytul="Batman3", Ocena=5, Opis="Opis filmu3"},
        };
        // GET: FilmController
        public ActionResult Index()
        {
            return View(filmies);
        }

        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {
            return View(filmies.FirstOrDefault(x=>x.Id == id));
        }

        // GET: FilmController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            film.Id = filmies.Count + 1;
            filmies.Add(film);
            return RedirectToAction("Index");
        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(filmies.FirstOrDefault(x => x.Id == id));
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Film film)
        {
            Film film1 = filmies.FirstOrDefault(x => x.Id == id);
                
            film1.Tytul=film.Tytul;
            film1.Ocena = film.Ocena;
            film1.Opis = film.Opis;
            return RedirectToAction("Index");
        }

        // GET: FilmController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(filmies.FirstOrDefault(x => x.Id == id));
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            filmies.Remove(filmies.FirstOrDefault(x => x.Id == id)!);
            return RedirectToAction("Index");
        }
    }
}
