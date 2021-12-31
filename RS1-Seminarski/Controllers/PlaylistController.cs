using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RS1_Seminarski.Data;
using RS1_Seminarski.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Seminarski.Controllers
{
    public class PlaylistController : Controller
    {
        public readonly ApplicationDbContext _db;

        public PlaylistController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Playlist> objList = _db.Playlist;
            return View(objList);
        }

        public IActionResult Create()
        {
            IEnumerable<SelectListItem> TypeDropDown = _db.Track.Select(x => new SelectListItem
            {
                Text = x.TrackName,
                Value = x.Id.ToString()
            });

            ViewBag.TypeDropDown = TypeDropDown;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Playlist obj)
        {
            if (ModelState.IsValid)
            {
                //obj.GenreId = 1;
                _db.Playlist.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Playlist.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Playlist.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Playlist.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        public IActionResult Update(int? id)
        {
            IEnumerable<SelectListItem> TypeDropDown = _db.Track.Select(x => new SelectListItem
            {
                Text = x.TrackName,
                Value = x.Id.ToString()
            });

            ViewBag.TypeDropDown = TypeDropDown;
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Playlist.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Playlist obj)
        {
            if (ModelState.IsValid)
            {
                _db.Playlist.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
