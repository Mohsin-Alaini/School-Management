using Microsoft.AspNetCore.Mvc;
using School_Management.Models.Interface;
using School_Management.Models;

namespace School_Management.Controllers
{
    public class SubjectController : Controller
    {
        public readonly IBaseRepository<Subject> _repo;
        public SubjectController(IBaseRepository<Subject> repository)
        {
            _repo = repository;
        }

        public IActionResult Index()
        {
            IEnumerable<Subject> SubjectList = _repo.GetAll();
            return View(SubjectList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Subject subject)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(subject);
                return RedirectToAction("Index");
            }
            return View(subject);

        }

        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var SubjectFromDb = _repo.Find(id);
            if (SubjectFromDb == null)
            {
                return NotFound();
            }
            return View(SubjectFromDb);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Subject subject)
        {
            if (ModelState.IsValid)
            {
                _repo.Update(subject);
                return RedirectToAction("Index");
            }
            return View(subject);
        }

        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var SubjectFromDb = _repo.Find(id);
            if (SubjectFromDb == null)
            {
                return NotFound();
            }
            return View(SubjectFromDb);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public IActionResult DeletePost(Subject subject)
        {
            if (subject == null)
            {
                return NotFound();
            }
            _repo.Delete(subject);
            return RedirectToAction("Index");
        }
    }
}
