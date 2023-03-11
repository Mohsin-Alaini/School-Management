using Microsoft.AspNetCore.Mvc;
using School_Management.Models;
using School_Management.Models.Interface;

namespace School_Management.Controllers
{
    public class StudentController : Controller
    {
        public readonly IBaseRepository<Student> _repo;
        public StudentController(IBaseRepository<Student> repository)
        {
            _repo = repository;
        }

        public IActionResult Index()
        {
            IEnumerable<Student> StudentList = _repo.GetAll();
            return View(StudentList);
        } 

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(student);
                return RedirectToAction("Index");
            }
            return View(student);

        }

        public IActionResult Edit(int id)
        {
            if (id == null || id ==0 )
            {
                return NotFound();
            }
            var studentFromDb = _repo.Find(id);
            if (studentFromDb == null)
            {
                return NotFound();
            }
            return View(studentFromDb);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit (Student student)
        {
            if (ModelState.IsValid)
            {
                _repo.Update(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            if(id == null || id == 0 )
            {
                return NotFound();
            }
            var studentFromDb = _repo.Find(id);
            if(studentFromDb== null)
            {
                return NotFound();
            }
            return View(studentFromDb);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public IActionResult DeletePost(Student student)
        {
            if(student == null)
            {
                return NotFound();
            }
            _repo.Delete(student);
            return RedirectToAction("Index");
        } 
    }
}
