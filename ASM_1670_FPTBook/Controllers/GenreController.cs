using ASM_1670_FPTBook.Data;
using ASM_1670_FPTBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASM_1670_FPTBook.Controllers
{
    public class GenreController : Controller
    {
        private readonly ApplicationDbContext _db;
        public GenreController(ApplicationDbContext db)
        {
            _db = db;
        }

        // index
        public IActionResult Index()
        {
            IEnumerable<Genre> genre = _db.genres.ToList();
            return View(genre);
        }

        // create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            if(ModelState.IsValid)
            {
                _db.genres.Add(genre);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(genre);
        }

        // edit
        public IActionResult Edit(int id)
        {
            Genre genre= _db.genres.Find(id);
            if(genre==null)
            {
                return RedirectToAction("Index");
            }
            return View(genre);
        }
        [HttpPost]
        public IActionResult Edit(Genre genre, int id) 
        {
            if(ModelState.IsValid)
            {
                genre.Gen_Id = id;
                _db.genres.Update(genre);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(genre);
        }

        // delete
        public IActionResult Delete(int id)
        {
            Genre genre = _db.genres.Find(id);
            _db.genres.Remove(genre);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
