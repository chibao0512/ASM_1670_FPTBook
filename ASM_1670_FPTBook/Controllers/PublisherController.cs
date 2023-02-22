using ASM_1670_FPTBook.Data;
using ASM_1670_FPTBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASM_1670_FPTBook.Controllers
{
    public class PublisherController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PublisherController(ApplicationDbContext db)
        {
            _db = db;
        }
        // index
        public IActionResult Index()
        {
            return View();
        }

        // create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Publisher publisher)
        {
            if(ModelState.IsValid)
            {
                _db.publishers.Add(publisher);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publisher);
        }

        // edit
        public IActionResult Edit(int id)
        {
            Publisher publisher = _db.publishers.Find(id);
            if(publisher == null)
            {
                return RedirectToAction("Index");
            }
            return View(publisher);
        }

        [HttpPost]
        public IActionResult Edit(Publisher publisher, int id)
        {
            if(ModelState.IsValid)
            {
                publisher.Publisher_Id = id;
                _db.publishers.Remove(publisher);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publisher);
        }

        // delete
        public IActionResult Delete(int id)
        {
            Publisher publisher = _db.publishers.Find(id);
            _db.publishers.Remove(publisher);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
