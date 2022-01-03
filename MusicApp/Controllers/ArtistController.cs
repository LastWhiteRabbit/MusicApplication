using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MusicApp.Data;
using MusicApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Controllers
{
    public class ArtistController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ArtistController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Artist> objList = _db.Artist;
            return View(objList);
        }
        public IActionResult Create()
        {


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Artist obj)
        {
            if (ModelState.IsValid)
            {
                //obj.GenreId = 1;
                _db.Artist.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Artist.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Artist.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Artist.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Artist.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Artist obj)
        {
            if (ModelState.IsValid)
            {
                _db.Artist.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
