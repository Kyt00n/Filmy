using Filmy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Filmy.Controllers
{
    public class EpicController : Controller
    {
        private static IList<Epic> epics = new List<Epic>()
        {
            new Epic(){Id=1, Tytul="Epic1", Opis="Opis Epika 1", Status = Enums.Status.rozpoczęty, Zadania="1,2,3" },
            new Epic(){Id=2, Tytul="Epic2", Opis="Opis Epika 2", Status = Enums.Status.zatrzymany, Zadania="4" },
            new Epic(){Id=3, Tytul="Epic3", Opis="Opis Epika 3", Status = Enums.Status.rozpoczęty, Zadania = "5,6,7"}
            
        };
        // GET: EpicController
        public ActionResult Index()
        {
            return View(epics);
        }

        // GET: EpicController/Details/5
        public ActionResult Details(int id)
        {
            return View(epics.FirstOrDefault(x => x.Id == id));
        }

        // GET: EpicController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EpicController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Epic epic)
        {
            epic.Id = epics.Count + 1;
            epics.Add(epic);
            return RedirectToAction("Index");
        }

        // GET: EpicController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(epics.FirstOrDefault(x => x.Id == id));
        }

        // POST: EpicController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Epic epic)
        {
            Epic epic1 = epics.FirstOrDefault(x => x.Id == id);
            epic1.Tytul = epic.Tytul;
            epic1.Status = epic.Status;
            epic1.Zadania = epic.Zadania;
            epic1.Opis = epic.Opis;
            return RedirectToAction("Index");

        }

        // GET: EpicController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(epics.FirstOrDefault(x => x.Id == id));
        }

        // POST: EpicController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Epic epic)
        {
            epics.Remove(epics.FirstOrDefault(x => x.Id == id)!);
            return RedirectToAction("Index");
        }
    }
}
