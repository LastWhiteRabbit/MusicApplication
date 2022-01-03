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
    public class TrackController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TrackController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Track> objList = _db.Track;
            return View(objList); 
        }
        public IActionResult Create()
        {
            IEnumerable<SelectListItem> TypeDropDown = _db.Genre.Select(x => new SelectListItem
            {
                Text = x.GenreName,
                Value = x.Id.ToString()
            });

            ViewBag.TypeDropDown = TypeDropDown;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Track obj)
        {
            if (ModelState.IsValid)
            {
                //obj.GenreId = 1;
                _db.Track.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Track.Find(id);
            if(obj == null)
            {
                return NotFound();
            }

            _db.Track.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Track.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        public IActionResult Update(int? id)
        {
            IEnumerable<SelectListItem> TypeDropDown = _db.Genre.Select(x => new SelectListItem
            {
                Text = x.GenreName,
                Value = x.Id.ToString()
            });

            ViewBag.TypeDropDown = TypeDropDown;
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Track.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Track obj)
        {
            if (ModelState.IsValid)
            {
                _db.Track.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
