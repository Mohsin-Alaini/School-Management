using Microsoft.AspNetCore.Mvc;
using School_Management.Models.Interface;
using School_Management.Models;

namespace School_Management.Controllers
{
    public class TeacherController : Controller
    {
        public readonly IBaseRepository<Teacher> _repo;
        public TeacherController(IBaseRepository<Teacher> repository)
        {
            _repo = repository;
        }

        public IActionResult Index()
        {
            IEnumerable<Teacher> TeachertList = _repo.GetAll();
            return View(TeachertList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(teacher);
                return RedirectToAction("Index");
            }
            return View(teacher);

        }

        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var TeacherFromDb = _repo.Find(id);
            if (TeacherFromDb == null)
            {
                return NotFound();
            }
            return View(TeacherFromDb);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _repo.Update(teacher);
                return RedirectToAction("Index");
            }
            return View(teacher);
        }

        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var TeacherFromDb = _repo.Find(id);
            if (TeacherFromDb == null)
            {
                return NotFound();
            }
            return View(TeacherFromDb);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public IActionResult DeletePost(Teacher teacher)
        {
            if (teacher == null)
            {
                return NotFound();
            }
            _repo.Delete(teacher);
            return RedirectToAction("Index");
        }
    }
}
