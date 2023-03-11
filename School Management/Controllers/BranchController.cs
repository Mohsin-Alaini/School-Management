using Microsoft.AspNetCore.Mvc;
using School_Management.Models.Interface;
using School_Management.Models;

namespace School_Management.Controllers
{
    public class BranchController : Controller
    {
        public readonly IBaseRepository<Branch> _repo;
        public BranchController(IBaseRepository<Branch> repository)
        {
            _repo = repository;
        }

        public IActionResult Index()
        {
            IEnumerable<Branch> BranchList = _repo.GetAll();
            return View(BranchList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Branch branch)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(branch);
                return RedirectToAction("Index");
            }
            return View(branch);

        }

        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var BranchFromDb = _repo.Find(id);
            if (BranchFromDb == null)
            {
                return NotFound();
            }
            return View(BranchFromDb);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Branch branch)
        {
            if (ModelState.IsValid)
            {
                _repo.Update(branch);
                return RedirectToAction("Index");
            }
            return View(branch);
        }

        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var BranchFromDb = _repo.Find(id);
            if (BranchFromDb == null)
            {
                return NotFound();
            }
            return View(BranchFromDb);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public IActionResult DeletePost(Branch branch)
        {
            if (branch == null)
            {
                return NotFound();
            }
            _repo.Delete(branch);
            return RedirectToAction("Index");
        }
    }
}
