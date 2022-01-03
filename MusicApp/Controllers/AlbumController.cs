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
    public class AlbumController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AlbumController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Album> objList = _db.Album;
            return View(objList);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Album obj)
        {
            if (ModelState.IsValid)
            {
                //obj.GenreId = 1;
                _db.Album.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Album.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Album.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Album.Find(id);
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

            var obj = _db.Album.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Album obj)
        {
            if (ModelState.IsValid)
            {
                _db.Album.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
