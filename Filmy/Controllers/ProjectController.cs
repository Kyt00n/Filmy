using Filmy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Filmy.Controllers
{
    public class ProjectController : Controller
    {
        private static IList<Project> projects = new List<Project>()
        {
            new Project(){Id=1, Tytul="Projekt1", Opis="Opis Projektu 1", Epiki="1,2" },
            new Project(){Id=2, Tytul="Projekt2", Opis="Opis Projektu 2", Epiki = "3" }

        };
        // GET: ProjectController
        public ActionResult Index()
        {
            return View(projects);
        }

        // GET: ProjectController/Details/5
        public ActionResult Details(int id)
        {
            return View(projects.FirstOrDefault(x => x.Id == id));
        }

        // GET: ProjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Project project)
        {
            project.Id = projects.Count + 1;
            projects.Add(project);
            return RedirectToAction("Index");
        }

        // GET: ProjectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(projects.FirstOrDefault(x => x.Id == id));
        }

        // POST: ProjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Project projekt)
        {
            Project projekt1 = projects.FirstOrDefault(x => x.Id == id);
            projekt1.Tytul = projekt.Tytul;
            
            projekt1.Epiki = projekt.Epiki;
            projekt1.Opis = projekt.Opis;
            return RedirectToAction("Index");
        }

        // GET: ProjectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(projects.FirstOrDefault(x => x.Id == id));

        }

        // POST: ProjectController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            projects.Remove(projects.FirstOrDefault(x => x.Id == id)!);
            return RedirectToAction("Index");
        }
    }
}
