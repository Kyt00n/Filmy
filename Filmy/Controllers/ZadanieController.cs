using Filmy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Filmy.Controllers
{
    public class ZadanieController : Controller
    {
        private static IList<Zadanie> tasks = new List<Zadanie>()
        {
            new Zadanie(){Id=1, Tytul="Zadanie1", Opis="Opis Zadania 1", Przypisani="Eryk Olsza", Punkty=Enums.StoryPoints.One},
            new Zadanie(){Id=2, Tytul="Zadanie2", Opis="Opis Zadania 2", Przypisani="Eryk Olsza", Punkty=Enums.StoryPoints.Two},
            new Zadanie(){Id=3, Tytul="Zadanie3", Opis="Opis Zadania 3", Przypisani="Eryk Olsza", Punkty=Enums.StoryPoints.Thirteen},
            new Zadanie(){Id=4, Tytul="Zadanie4", Opis="Opis Zadania 4", Przypisani="Eryk Olsza", Punkty=Enums.StoryPoints.None},
            new Zadanie(){Id=5, Tytul="Zadanie5", Opis="Opis Zadania 5", Przypisani="Eryk Olsza", Punkty=Enums.StoryPoints.Eight},
            new Zadanie(){Id=6, Tytul="Zadanie6", Opis="Opis Zadania 6", Przypisani="Eryk Olsza", Punkty=Enums.StoryPoints.Eight},
            new Zadanie(){Id=7, Tytul="Zadanie7", Opis="Opis Zadania 7", Przypisani="Eryk Olsza", Punkty=Enums.StoryPoints.Eight},
        };
        // GET: TaskController
        public ActionResult Index()
        {
            return View(tasks);
        }

        // GET: TaskController/Details/5
        public ActionResult Details(int id)
        {
            return View(tasks.FirstOrDefault(x=>x.Id == id));
        }

        // GET: TaskController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Zadanie zadanie)
        {
            zadanie.Id = tasks.Count + 1;
            tasks.Add(zadanie);
            return RedirectToAction("Index");
        }

        // GET: TaskController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(tasks.FirstOrDefault(x=> x.Id == id));
        }

        // POST: TaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Zadanie zadanie)
        {
            Zadanie zadanie1 = tasks.FirstOrDefault(x=>x.Id == id);
            zadanie1.Tytul = zadanie.Tytul;
            zadanie1.Opis = zadanie.Opis;
            zadanie1.Przypisani = zadanie.Przypisani;
            zadanie1.Punkty = zadanie.Punkty;
            return RedirectToAction("Index");
        }

        // GET: TaskController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(tasks.FirstOrDefault(x=> x.Id== id));
        }

        // POST: TaskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Zadanie zadanie)
        {
            tasks.Remove(tasks.FirstOrDefault(x => x.Id == id)!);
            return RedirectToAction("Index");
        }
    }
}
